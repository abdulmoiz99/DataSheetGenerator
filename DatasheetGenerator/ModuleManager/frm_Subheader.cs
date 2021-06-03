using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatasheetGenerator.ModuleManager
{
    public partial class frm_Subheader : Form
    {
        int mode = 1; // 1. New , 2.Edit
        int selectedId = 0;
        public frm_Subheader()
        {
            InitializeComponent();
        }
        public void ToogleControls()
        {
            if (mode == 1) // New
            {
                btn_New.BackgroundColor = Color.FromArgb(0, 118, 190);
                btn_Edit.BackgroundColor = Color.DarkGray;
                selectedId = 0;

            }
            else // Edit
            {
                btn_New.BackgroundColor = Color.DarkGray;
                btn_Edit.BackgroundColor = Color.FromArgb(0, 118, 190);
            }
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool containsValue(string value)
        {
            foreach (DataGridViewRow row in dgv_Values.Rows)
            {
                if (row.Cells[0].Value.ToString().ToUpper() == value.ToUpper())
                {
                    return true;
                }
            }
            return false;
        }
        private void btn_AddValue_Click(object sender, EventArgs e)
        {
            if (txt_Value.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (containsValue(txt_Value.Text))
            {
                MessageBox.Show("Subheader Already Contains This Value", "Cannot Add Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dgv_Values.Rows.Add(txt_Value.Text);
                txt_Value.Text = string.Empty;
            }
        }

        private void frm_Subheader_Load(object sender, EventArgs e)
        {
            ToogleControls();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            mode = 1;
            ToogleControls();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            mode = 2;
            ToogleControls();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_SubHeaderName.Text == "")
            {
                MessageBox.Show("Please Enter Subheader Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dgv_Values.RowCount <= 0)
            {
                MessageBox.Show("Please Add Values To List", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (mode == 1) // Save
            {

            }
            else if (mode == 2) // Edit
            {

            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("No Record Selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult YorN = MessageBox.Show("Are You Sure To Deleted The Selected Record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (YorN == DialogResult.Yes)
            {
                if (SQL.NonScalarQuery("Update Bundles set BundleActive = 0 where BundleID = " + selectedId + ""))
                {
                    MessageBox.Show("Record Removed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else MessageBox.Show("Unable To Remove Record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
