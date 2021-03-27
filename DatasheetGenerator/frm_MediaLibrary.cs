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
        int mode;
        int selectedIndex = -1;
        int selectedImageType = 1; // 1- Symbol, 2-Dimensional Drawing, 3-Product Images, 4-Wiring Drawings
        private void ImageSelection()
        {
            btn_Symbol.BackgroundColor = (selectedImageType == 1) ? Color.FromArgb(117, 117, 117) : Color.Gainsboro;
            btn_DimensionalDrawings.BackgroundColor = (selectedImageType == 2) ? Color.FromArgb(117, 117, 117) : Color.Gainsboro;
            btn_ProductImages.BackgroundColor = (selectedImageType == 3) ? Color.FromArgb(117, 117, 117) : Color.Gainsboro;
            btnm_WiringDrawings.BackgroundColor = (selectedImageType == 4) ? Color.FromArgb(117, 117, 117) : Color.Gainsboro;

            Main.fillDgv(dgv_Media, "select * from MediaLibrary where active = 1 and type = " + selectedImageType.ToString() + " ");

        }
        private void AllClear()
        {
            txt_Name.Text = "";
            txt_Description.Text = "";
        }
        public frm_MediaLibrary()
        {
            InitializeComponent();
        }



        private void frm_MediaLibrary_Load(object sender, EventArgs e)
        {
            mode = 0;
            AllClear();
            btn_Edit.Visible = true;
            btn_Delete.Visible = false;
            btn_New.Visible = true;
            btn_Cancel.Visible = false;
            btn_Save.Visible = false;
            txt_Name.Enabled = false;
            txt_Description.Enabled = false;
            dgv_Media.Enabled = false;
            txt_Name.Focus();

            ImageSelection();
        }

        private void btn_ReplaceImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            //For any other formats
            of.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (of.ShowDialog() == DialogResult.OK)
            {
                pb_Image.ImageLocation = of.FileName;
            }
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            mode = 1;
            AllClear();
            btn_Edit.Visible = false;
            btn_Delete.Visible = false;
            btn_New.Visible = false;
            btn_Cancel.Visible = true;
            btn_Save.Visible = true;
            txt_Name.Enabled = true;
            txt_Description.Enabled = true;
            dgv_Media.Enabled = false;
            txt_Name.Focus();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            mode = 2;
            btn_Edit.Visible = false;
            btn_New.Visible = false;
            btn_Delete.Visible = true;
            btn_Save.Visible = true;
            btn_Cancel.Visible = true;
            txt_Name.Enabled = true;
            txt_Description.Enabled = true;
            dgv_Media.Enabled = true;
            txt_Name.Focus();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (selectedIndex == -1)
            {
                MessageBox.Show("No Record Selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult YorN = MessageBox.Show("Are you sure to deleted the selected Image?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
                if (YorN == DialogResult.Yes)
                {
                    if (SQL.NonScalarQuery("Update MediaLibrary set active = 0 where Id = " + selectedIndex + ""))
                    {
                        MessageBox.Show("Record Deleted Successfully", "Success");
                    }
                    else
                    {
                        MessageBox.Show("Unable to Delete Selected Record ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            mode = 0;
            btn_Edit.Visible = true;
            btn_Delete.Visible = false;
            btn_New.Visible = true;
            btn_Cancel.Visible = false;
            btn_Save.Visible = false;
            txt_Name.Enabled = false;
            txt_Description.Enabled = false;
            dgv_Media.Enabled = false;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text == "")
            {
                MessageBox.Show("Please Enter Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (mode == 1)
            {
                try
                {

                    if (SQL.con.State == ConnectionState.Closed) SQL.con.Open();
                    var mySqlCommand = new MySqlCommand(" Insert Into MediaLibrary (Name                     ,Description                   , Image, Active , Type)" +
                                                                " values ( '" + txt_Name.Text + "' ,'" + txt_Description.Text + "', @pic, 1       ," + selectedImageType + ")", SQL.Con);

                    var memoryStream = new MemoryStream();
                    pb_Image.Image.Save(memoryStream, pb_Image.Image.RawFormat);
                    byte[] data = memoryStream.GetBuffer();
                    MySqlParameter parameter = new MySqlParameter("@pic", MySqlDbType.Blob);
                    parameter.Value = data;
                    mySqlCommand.Parameters.Add(parameter);
                    mySqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Record Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    AllClear();
                    btn_Cancel_Click(sender, e);
                    frm_MediaLibrary_Load(sender, e);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to save record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (mode == 2)
            {

                if (selectedIndex == -1)
                {
                    MessageBox.Show("No Record Selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        if (SQL.con.State == ConnectionState.Closed) SQL.con.Open();
                        var query = new MySqlCommand("UPDATE MediaLibrary SET Name = '" + txt_Name.Text + "', Description = '" + txt_Description.Text + "', Image = @pic WHERE ID = " + selectedImageType + ";", SQL.con);
                        var stream = new MemoryStream();
                        pb_Image.Image.Save(stream, pb_Image.Image.RawFormat);
                        byte[] data =  stream.GetBuffer();
                        MySqlParameter parameter = new MySqlParameter("@pic", MySqlDbType.Blob);
                        parameter.Value = data;
                        query.Parameters.Add(parameter);
                        query.ExecuteNonQuery();
                        MessageBox.Show("Record Updates Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AllClear();
                        btn_Cancel_Click(sender, e);
                        frm_MediaLibrary_Load(sender, e);

                    }
                        catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        MessageBox.Show("Unable to update the record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Symbol_Click(object sender, EventArgs e)
        {
            selectedImageType = 1;
            ImageSelection();
        }
        private void btn_DimensionalDrawings_Click(object sender, EventArgs e)
        {
            selectedImageType = 2;
            ImageSelection();
        }
        private void btn_ProductImages_Click(object sender, EventArgs e)
        {
            selectedImageType = 3;
            ImageSelection();
        }
        private void btnm_WiringDrawings_Click(object sender, EventArgs e)
        {
            selectedImageType = 4;
            ImageSelection();
        }

        private void frm_MediaLibrary_FormClosing(object sender, FormClosingEventArgs e)
        {
            FlowLayoutPanel symbolPanel = (FlowLayoutPanel)Tag;
            Datasheet.AddSymbolList(symbolPanel, true);
        }

        private void dgv_Media_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_Name.Text = "";
                int index = e.RowIndex;
                if (index > -1)
                {
                    selectedIndex = index;
                    DataGridViewRow selectedrow = dgv_Media.Rows[index];
                    selectedIndex = Convert.ToInt32(selectedrow.Cells["ID"].Value.ToString());
                    txt_Name.Text = selectedrow.Cells["Name1"].Value.ToString();
                    txt_Description.Text = selectedrow.Cells["Description"].Value.ToString();
                    var data = (Byte[])(selectedrow.Cells["Image1"].Value);
                    var stream = new MemoryStream(data);
                    pb_Image.Image = Image.FromStream(stream);
                }
                index = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
