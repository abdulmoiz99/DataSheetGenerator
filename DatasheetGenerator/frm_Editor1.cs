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
    public partial class frm_Editor1 : Form
    {
        int count = 1;
        public frm_Editor1()
        {
            InitializeComponent();
        }
        private void UpdateHeaderDetails(DataGridView dataGridView, string HeaderText, int Position, DataGridView refGrid)
        {
            int rowIndex = dataGridView.Rows.Add(HeaderText, Position);
            dataGridView.Rows[rowIndex].Tag = refGrid;
        }
        private void GenerateGrid(DataGridView dataGridView, string HeaderID, string HeaderText, DataTable SubHeader)
        {
            dataGridView.AllowUserToAddRows = false;
            //Adding column names

            dataGridView.Columns.Add("Value1", HeaderText);
            dataGridView.Columns.Add("value2", "");
            dataGridView.Columns.Add("ID", HeaderID);

            //COLUMN HEADER
            //Set Header height
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridView.ColumnHeadersHeight = 50;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            //Header Font
            dataGridView.Columns[0].HeaderCell.Style.Font = new Font("Roboto Medium", 13);
            //Auto Size Column
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //Header Border
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //Header Color
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 101, 177);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            //ROW
            //Row Height
            dataGridView.RowTemplate.Height = 40;
            //Row Fore Color
            dataGridView.Columns[0].DefaultCellStyle.ForeColor = Color.FromArgb(82, 82, 84);
            dataGridView.Columns[1].DefaultCellStyle.ForeColor = Color.FromArgb(82, 82, 84);
            //Alternating Row Setup
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(237, 238, 239);
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.Gray;
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView.BackgroundColor = Color.White;

            //GRID BORDER
            dataGridView.BorderStyle = BorderStyle.Fixed3D;
            dataGridView.RowHeadersVisible = false;

            dataGridView.DefaultCellStyle.Font = new Font("Roboto", 10);

            foreach (DataRow row in SubHeader.Rows)
            {
                dataGridView.Rows.Add(row[1].ToString(), row[2].ToString(), row[0].ToString());
            }
            dataGridView.AllowUserToAddRows = true;

            //Disabling Selection Color
            dataGridView.DefaultCellStyle.SelectionBackColor = dataGridView.DefaultCellStyle.BackColor;
            dataGridView.DefaultCellStyle.SelectionForeColor = dataGridView.DefaultCellStyle.ForeColor;

            //Hiding ID column
            dataGridView.Columns[2].Visible = false;
        }
        private void frm_Editor1_Load(object sender, EventArgs e)
        {
            lab_ProductFamily.Text = Datasheet.ProductFamilly;
            Datasheet.AddSymbolList(flowPanel_Symbols, true);


            var Header = Datasheet.GetDataTable("select Id,Name from Header where DS_ID = " + Datasheet.Id + "");
            string headerID = ""; 
            string headerText = "";
            foreach (DataRow header in Header.Rows)
            {
                headerID = header[0].ToString();
                headerText = HeaderController.Header.GetHeaderText(headerID);
                var dgv = new DataGridView();
                dgv.Size = new Size(546, 277);
                var subHeader = Datasheet.GetDataTable("select id,value1,value2 from Subheader where H_ID = " + headerID + ";");
                GenerateGrid(dgv, Datasheet.Id, headerText, subHeader);
                UpdateHeaderDetails(dgv_HeaderDetails, headerText, count, dgv);
                dgv.Tag = count++;
                flowLayoutPanel1.Controls.Add(dgv);
                HeaderController.Header.DisableNewHeader();
                dgv_HeaderDetails.ClearSelection();

            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
