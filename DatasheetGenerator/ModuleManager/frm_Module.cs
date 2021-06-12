using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatasheetGenerator.ModuleManager
{
    public partial class frm_Module : Form
    {
        private int mode;
        private int selectedId;

        public frm_Module()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Module_Load(object sender, EventArgs e)
        {
            Main.fillCombo(cmb_SubheaderName, "SubheaderMaster", "SubheaderMasterName", "SubheaderMasterID", "SubheaderMasterActive = 1");

        }
        public bool ContainsSubheader(string value)
        {
            foreach (DataGridViewRow row in dgv_Preview.Rows)
            {
                try
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == value)
                    {
                        return true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return false;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }
        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
            dgv_Preview.Columns[1].HeaderText = txt_Name.Text;
        }
        private void btn_AddNewProductFamily_Click(object sender, EventArgs e)
        {
            if (cmb_SubheaderName.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select Header Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ContainsSubheader(cmb_SubheaderName.SelectedValue.ToString()))
            {
                MessageBox.Show("Module Already Contain The Selected Subheader", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                dgv_Preview.Rows.Add(cmb_SubheaderName.SelectedValue, cmb_SubheaderName.Text, "Text Field");
                if (rb_DropDown.Checked) FillDgvComboBox();
            }
        }
        private void dgv_Preview_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Preview.RowCount > 1)
            {
                if (e.ColumnIndex == 0)
                {
                    var valueBox = dgv_Preview.Rows[e.RowIndex].Cells[1] as DataGridViewComboBoxCell;
                    valueBox.Items.Clear();

                    if (dgv_Preview.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Power")
                    {
                        valueBox.Items.Add("Monday");
                        valueBox.Items.Add("Tuesday");
                        valueBox.Items.Add("Wednesday");
                    }
                    if (dgv_Preview.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Width")
                    {
                        valueBox.Items.Add("Red");
                        valueBox.Items.Add("Green");
                        valueBox.Items.Add("Blue");
                    }
                }
            }
        }
        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Text.Checked)
            {
                dgv_Preview.Columns.Remove("Value2");

                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                col.Name = "Value2";
                col.HeaderText = string.Empty;
                dgv_Preview.Columns.Insert(2, col);

                foreach (DataGridViewRow row in dgv_Preview.Rows)
                {
                    row.Cells["Value2"].Value = "Text Field";
                }
            }
        }
        private void FillDgvComboBox()
        {
            foreach (DataGridViewRow row in dgv_Preview.Rows)
            {

                if (row.Cells["ID"].Value != null)
                {
                    DataGridViewComboBoxCell comboBoxCell = (DataGridViewComboBoxCell)row.Cells[2];
                    comboBoxCell.Items.Clear();
                    var SubheaderValues = Datasheet.GetDataTable("SELECT * FROM SubheaderDetail where SubheaderMasterID  = " + row.Cells["ID"].Value.ToString() + ";");
                    foreach (DataRow values in SubheaderValues.Rows)
                    {
                        comboBoxCell.Items.Add(values["SubheaderDetailValue"].ToString());
                    }
                }
            }
        }

        private void dgv_Preview_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void rb_DropDown_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_DropDown.Checked)
            {
                dgv_Preview.Columns.Remove("Value2");

                DataGridViewComboBoxColumn col = new DataGridViewComboBoxColumn();
                col.Name = "Value2";
                col.HeaderText = string.Empty;
                col.FlatStyle = FlatStyle.Flat;
                col.Items.Add("123");
              

                dgv_Preview.Columns.Insert(2, col);
                FillDgvComboBox();
                foreach (DataGridViewRow row in dgv_Preview.Rows)
                {
                    row.Cells[col.Name].Value = (row.Cells[col.Name] as DataGridViewComboBoxCell).Items[0];
                }
            }
        }

        public void ToggleControls()
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

        private void btn_New_Click(object sender, EventArgs e)
        {
            txt_Name.Clear();
            dgv_Preview.Columns.Clear();
            rb_Text.Checked = true;
            Editor.GenerateGrid(dgv_Preview, "", "Header Name",
                           dataGridView1_EditingControlShowing,
                                       dataGridView1_CellClick,
                                  dataGridView1_CellFormatting,
                                       dataGridView1_RowsAdded);
            mode = 1;         
            ToggleControls();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            mode = 2;
            ToggleControls();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string query = "";
            if (txt_Name.Text == "")
            {
                MessageBox.Show("Please Enter Module Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dgv_Preview.RowCount <= 0)
            {
                MessageBox.Show("Please Add Values To List", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (mode == 1) // Save
            {
                query = "Insert Into Module (ModuleName,                        ModuleDropDown,                             ModuleActive    )" +
                                             " values('" + txt_Name.Text + "',  " + Convert.ToInt32(rb_DropDown.Checked) + "            ,1 )";
                SQL.NonScalarQuery(query);

                query = "SELECT MAX(ModuleID) FROM Module";
                int ID = 0;
                int.TryParse(SQL.ScalarQuery(query), out ID);

                foreach (DataGridViewRow row in dgv_Preview.Rows)
                {
                    query = "Insert Into ModuleDetail (ModuleMasterID , SubheaderMasterID )" +
                                                 " values('" + ID + "'      ,'" + row.Cells[0].Value.ToString() + "')";
                    SQL.NonScalarQuery(query);
                }
                MessageBox.Show("Record Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_Name.Clear();
                rb_Text.Checked = true;
                dgv_Preview.Columns.Clear();
                Editor.GenerateGrid(dgv_Preview, "", "Header Name",
                               dataGridView1_EditingControlShowing,
                                           dataGridView1_CellClick,
                                      dataGridView1_CellFormatting,
                                           dataGridView1_RowsAdded);
            }
            else if (mode == 2) // Edit
            {

            }
        }
    }
}
