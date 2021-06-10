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
            Editor.GenerateGrid(dgv_Preview, "", "Header Name",
                    dataGridView1_EditingControlShowing,
                    dataGridView1_CellClick,
                    dataGridView1_CellFormatting,
                    dataGridView1_RowsAdded);



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
                    if (row.Index == dgv_Preview.Rows.Count - 1) break;
                    row.Cells["Value2"].Value = "Text Field";

                }
            }
        }
        private void FillDgvComboBox(DataGridViewComboBoxColumn column)
        {
            foreach (DataGridViewRow row in dgv_Preview.Rows)
            {

                if (row.Cells["ID"].Value != null)
                {
                    //  DataGridViewComboBoxCell comboBoxCell = (DataGridViewComboBoxCell)row.Cells[2];
                    column.Items.Clear();
                    var SubheaderValues = Datasheet.GetDataTable("SELECT * FROM SubheaderDetail where SubheaderMasterID  = " + row.Cells["ID"].Value.ToString() + ";");
                    foreach (DataRow values in SubheaderValues.Rows)
                    {
                        column.Items.Add(values["SubheaderDetailValue"].ToString());
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

                FillDgvComboBox(col);

                dgv_Preview.Columns.Insert(2, col);
                foreach (DataGridViewRow row in dgv_Preview.Rows)
                {
                    if (row.Index == dgv_Preview.Rows.Count - 1) break;
                    row.Cells[col.Name].Value = (row.Cells[col.Name] as DataGridViewComboBoxCell).Items[0];
                }
            }
        }
    }
}
