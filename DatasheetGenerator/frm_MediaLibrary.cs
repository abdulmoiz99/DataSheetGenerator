using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatasheetGenerator
{
    public partial class frm_MediaLibrary : Form
    {
        public frm_MediaLibrary()
        {
            InitializeComponent();
        }


        private void frm_MediaLibrary_Load(object sender, EventArgs e)
        {
            Main.fillDgv(dgv_Images, "SELECT ID, Name, Description, Type, Image FROM MediaLibrary WHERE Active = 1;");
            cmb_Types.SelectedIndex = 0;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Name.Clear();
            txt_Description.Clear();
            imageBox.Image = null;
            cmb_Types.SelectedIndex = 0;
            dgv_Images.ClearSelection();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text == String.Empty)
            {
                MessageBox.Show("Please enter name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (imageBox.Image == null)
            {
                MessageBox.Show("Please upload Image!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (SQL.con.State == ConnectionState.Closed) SQL.con.Open();
                    var query = new MySqlCommand("Insert into MediaLibrary (Name, Image, Description, Active, Type) Values ('" + txt_Name.Text + "', @pic, '" + txt_Description.Text + "', 1," + cmb_Types.SelectedIndex + ");", SQL.con);
                    var stream = new MemoryStream();
                    imageBox.Image.Save(stream, imageBox.Image.RawFormat);
                    byte[] data = stream.GetBuffer();
                    MySqlParameter parameter = new MySqlParameter("@pic", MySqlDbType.Blob);
                    parameter.Value = data;
                    query.Parameters.Add(parameter);
                    query.ExecuteNonQuery();
                    MessageBox.Show("Data Inserted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SQL.con.Close();
                    Main.fillDgv(dgv_Images, "SELECT ID, Name, Description, Type, Image FROM MediaLibrary WHERE Active = 1;");
                    dgv_Images.ClearSelection();
                    txt_Name.Clear();
                    cmb_Types.SelectedIndex = 0;
                    txt_Description.Clear();
                    imageBox.Image = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imageBox.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void dgv_Images_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (dgv.SelectedRows.Count > 0)
            {
                txt_ID.Text = dgv.SelectedRows[0].Cells["id"].Value.ToString();
                txt_Name.Text = dgv.SelectedRows[0].Cells["name"].Value.ToString();
                txt_Description.Text = dgv.SelectedRows[0].Cells["description"].Value.ToString();
                cmb_Types.SelectedIndex = (int)dgv.SelectedRows[0].Cells["type"].Value;
                imageBox.Image = ByteToImage((byte[])dgv.SelectedRows[0].Cells["image"].Value);
            }
        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_Images.SelectedRows.Count > 0)
            {
                SQL.NonScalarQuery("UPDATE MediaLibrary SET Active = 0 WHERE ID = " + txt_ID.Text + ";");
                MessageBox.Show("Data Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Main.fillDgv(dgv_Images, "SELECT ID, Name, Description, Type, Image FROM MediaLibrary WHERE Active = 1;");
                dgv_Images.ClearSelection();
                txt_Name.Clear();
                txt_Description.Clear();
                imageBox.Image = null;
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text == String.Empty)
            {
                MessageBox.Show("Please enter name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (imageBox.Image == null)
            {
                MessageBox.Show("Please upload Image!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                try
                {
                    if (SQL.con.State == ConnectionState.Closed) SQL.con.Open();
                    var query = new MySqlCommand("UPDATE MediaLibrary SET Name = '" + txt_Name.Text + "', Description = '" + txt_Description.Text + "', Type = " + cmb_Types.SelectedIndex + ", Image = @pic WHERE ID = " + txt_ID.Text + ";", SQL.con);
                    var stream = new MemoryStream();
                    imageBox.Image.Save(stream, imageBox.Image.RawFormat);
                    byte[] data = stream.GetBuffer();
                    MySqlParameter parameter = new MySqlParameter("@pic", MySqlDbType.Blob);
                    parameter.Value = data;
                    query.Parameters.Add(parameter);
                    query.ExecuteNonQuery();
                    MessageBox.Show("Data Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SQL.con.Close();
                    int tempIndex = dgv_Images.SelectedRows[0].Index;
                    Main.fillDgv(dgv_Images, "SELECT ID, Name, Description, Type, Image FROM MediaLibrary WHERE Active = 1;");
                    dgv_Images.ClearSelection();
                    dgv_Images.Rows[tempIndex].Selected = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
