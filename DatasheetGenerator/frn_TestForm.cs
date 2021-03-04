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
    public partial class frn_TestForm : Form
    {
        public frn_TestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void frn_TestForm_Load(object sender, EventArgs e)
        {

            //Adding column names
            dataGridView1.Columns.Add("newColumnName", "Gerneral");
            dataGridView1.Columns.Add("newColumnName1", "");

            //COLUMN HEADER
            //Set Header height
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            //Header Font
            dataGridView1.Columns[0].HeaderCell.Style.Font = new Font("Roboto Medium", 13);
            //Auto Size Column
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //Header Border
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //Header Color
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 101, 177);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            //ROW
            //Row Height
            dataGridView1.RowTemplate.Height = 40;
            //Row Fore Color
            dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.FromArgb(82, 82, 84);
            dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.FromArgb(82, 82, 84);
            //Alternating Row Setup
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(237, 238, 239);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Gray;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            //GRID BORDER
             dataGridView1.BorderStyle = BorderStyle.None;
           

            this.dataGridView1.DefaultCellStyle.Font = new Font("Roboto", 10);

            ////dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            ////dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft;



            this.dataGridView1.Rows.Add("Product Name", "Text Field");
            this.dataGridView1.Rows.Add("Product Code", "Text Field");
            this.dataGridView1.Rows.Add("Prodcut Description", "Text Field");

        }
    }
}
