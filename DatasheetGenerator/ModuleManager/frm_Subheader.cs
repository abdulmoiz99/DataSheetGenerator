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

                txt_Find.Enabled = false;


            }
            else // Edit
            {
                btn_New.BackgroundColor = Color.DarkGray;
                btn_Edit.BackgroundColor = Color.FromArgb(0, 118, 190);

                txt_Find.Enabled = true;
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
            Main.fillDgv(dgv_Subheader, "select * from SubheaderMaster where SubheaderMasterActive = 1;");
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
            string query = "";
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
                query = "Insert Into SubheaderMaster (SubheaderMasterName             ,SubheaderMasterActive    )" +
                                             " values('" + txt_SubHeaderName.Text + "',1 )";
                SQL.NonScalarQuery(query);

                query = "SELECT MAX(SubheaderMasterID) FROM SubheaderMaster";
                int ID = 0;
                int.TryParse(SQL.ScalarQuery(query), out ID);

                foreach (DataGridViewRow row in dgv_Values.Rows)
                {
                    query = "Insert Into SubheaderDetail (SubheaderMasterID ,SubheaderDetailValue                   ,SubheaderDetailActive    )" +
                                                 " values('" + ID + "'      ,'" + row.Cells[0].Value.ToString() + "',1 )";
                    SQL.NonScalarQuery(query);
                }
                MessageBox.Show("Record Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (mode == 2) // Edit
            {

            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (mode != 2)
            {
                MessageBox.Show("Please Select The Edit Mode First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (selectedId == 0)
            {
                MessageBox.Show("No Record Selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        
            DialogResult YorN = MessageBox.Show("Are You Sure To Deleted The Selected Record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (YorN == DialogResult.Yes)
            {
                if (SQL.NonScalarQuery("Update SubheaderMaster set SubheaderMasterActive = 0 where SubheaderMasterID = " + selectedId + ""))
                {
                    txt_SubHeaderName.Text = string.Empty;
                    txt_Value.Text = string.Empty;
                    mode = 1;
                    ToogleControls();
                    MessageBox.Show("Record Removed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else MessageBox.Show("Unable To Remove Record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txt_Find_TextChanged(object sender, EventArgs e)
        {
            Main.fillDgv(dgv_Subheader, "SELECT * FROM SubheaderMaster WHERE SubheaderMasterActive = 1 and  SubheaderMasterName LIKE '%" + txt_Find.Text + "%'");
        }

        private void dgv_Subheader_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (mode != 2) //not edit
            {
                MessageBox.Show("Please Select The Edit Mode First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int index = e.RowIndex;

                if (index > -1)
                {
                    DataGridViewRow selectedrow = dgv_Subheader.Rows[index];
                    selectedId = Convert.ToInt32(selectedrow.Cells["SubheaderMasterID"].Value);
                    txt_SubHeaderName.Text = selectedrow.Cells["SubheaderMasterName"].Value.ToString();

                    var SubheaderValues = Datasheet.GetDataTable("SELECT * FROM SubheaderDetail where SubheaderMasterID  = " + selectedId + ";");
                    dgv_Values.Rows.Clear();
                    foreach (DataRow values in SubheaderValues.Rows)
                    {
                        dgv_Values.Rows.Add(values["SubheaderDetailValue"].ToString());
                    }
                }
                index = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_Subheader_Activated(object sender, EventArgs e)
        {
            ToogleControls();
            Main.fillDgv(dgv_Subheader, "select * from SubheaderMaster where SubheaderMasterActive = 1;");
        }

        private void dgv_Values_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningRow;
                //if (Datasheet.IsEditing) //Add Subheader function.
                dgv.Rows.Remove(row);
            }
        }
    }
}
