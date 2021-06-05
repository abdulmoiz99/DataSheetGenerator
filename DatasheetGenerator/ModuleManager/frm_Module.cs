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
            dgv_Preview.Rows.Add("", "Subheader", "Value");
        }
    }
}
