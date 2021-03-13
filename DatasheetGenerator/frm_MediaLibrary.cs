using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            Main.fillDgv(dgv_Media, "select * from MediaLibrary");
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
            btn_Edit.Enabled = false;
            btn_Delete.Enabled = false;
            btn_New.Enabled = false;
            btn_Cancel.Enabled = true;
            btn_Save.Enabled = true;
            txt_Name.Enabled = true;
            dgv_Media.Enabled = false;
            txt_Name.Focus();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            mode = 2;
            btn_Edit.Enabled = false;
            btn_New.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Save.Enabled = true;
            btn_Cancel.Enabled = true;
            txt_Name.Enabled = true;
            dgv_Media.Enabled = true;
            txt_Name.Focus();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            mode = 0;
            btn_Edit.Enabled = true;
            btn_Delete.Enabled = false;
            btn_New.Enabled = true;
            btn_Cancel.Enabled = false;
            btn_Save.Enabled = false;
            txt_Name.Enabled = false;
            dgv_Media.Enabled = true;
        }

        private void dgv_Media_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_Name.Text = "";
                int index = e.RowIndex;
                if (index > -1)
                {
                    selectedIndex = index;
                    DataGridViewRow selectedrow = dgv_Media.Rows[index];
                    txt_Name.Text = selectedrow.Cells["Name"].Value.ToString();
                    txt_Description.Text = selectedrow.Cells["Description"].Value.ToString();
                }
                index = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text == "")
            {
                MessageBox.Show("Please Enter Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (mode == 1)
            {
               // SQL.NonScalarQuery("Insert Into FormSetup(FormName) values ('" + txt_Name.Text + "')");
                MessageBox.Show("Record Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                AllClear();
                btn_Cancel_Click(sender, e);
                frm_MediaLibrary_Load(sender, e);
            }
            else if (mode == 2)
            {
                if (selectedIndex == -1)
                {
                    MessageBox.Show("No Record Selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               // SQL.NonScalarQuery("Update FormSetup set FormName = '" + txt_Name.Text + "' where FormID=" + txt_DataGridViewIndex.Text + "");
                MessageBox.Show("Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                AllClear();
                btn_Cancel_Click(sender, e);
                frm_MediaLibrary_Load(sender, e);
            }
        }
    }
}
