using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XanderUI;

namespace DatasheetGenerator
{
    public partial class frm_Editor1 : Form
    {
        int count = 1;
        AutoCompleteStringCollection data;


        public frm_Editor1()
        {
            InitializeComponent();
        }
        public AutoCompleteStringCollection AutoCompleteLoadValue1()
        {
            if (SQL.con.State == ConnectionState.Closed) SQL.con.Open();
            var cmd = new MySqlCommand("select value1,value2 from Subheader;", SQL.con);
            MySqlDataReader dr = cmd.ExecuteReader();
            AutoCompleteStringCollection mycoll = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                mycoll.Add(dr["Value1"].ToString());
                mycoll.Add(dr["Value2"].ToString());
            }
            return mycoll;
        }
        private void UpdateHeaderDetails(DataGridView dataGridView, string HeaderText, int Position, DataGridView refGrid)
        {
            int rowIndex = dataGridView.Rows.Add(HeaderText, Position);
            dataGridView.Rows[rowIndex].Tag = refGrid;
        }

        private void GenerateGrid(DataGridView dataGridView, string HeaderID, string HeaderText)
        {
            dataGridView.AllowUserToAddRows = false;
            //Adding column names
            dataGridView.Columns.Add("Value1", HeaderText);
            dataGridView.Columns.Add("value2", "");
            dataGridView.Columns.Add("ID", HeaderID);

            DataGridViewImageColumn column = new DataGridViewImageColumn();
            column.Name = "newColumnName2";
            column.HeaderText = "";
            column.FillWeight = 10;
            column.DefaultCellStyle.NullValue = null;

            dataGridView.Columns.Add(column);

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

            dataGridView.Rows.Add("Product Name", "Text Field", Properties.Resources.icons8_multiply_24);
            dataGridView.Rows.Add("Product Code", "Text Field", Properties.Resources.icons8_multiply_24);
            dataGridView.Rows.Add("Product Description", "Text Field", Properties.Resources.icons8_multiply_24);
            dataGridView.AllowUserToAddRows = true;

            //Disabling Selection Color
            dataGridView.DefaultCellStyle.SelectionBackColor = dataGridView.DefaultCellStyle.BackColor;
            dataGridView.DefaultCellStyle.SelectionForeColor = dataGridView.DefaultCellStyle.ForeColor;

            //Hiding ID column
            dataGridView.Columns[2].Visible = false;

            dataGridView.EditingControlShowing += dataGridView1_EditingControlShowing;
            dataGridView.CellClick += DataGridView_CellClick;
            dataGridView.CellFormatting += DataGridView_CellFormatting;
            dataGridView.RowsAdded += DataGridView_RowsAdded;
        }

        private void DataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            var dgv = sender as DataGridView;
            dgv.Rows[dgv.RowCount - 2].Cells[2].Value = Properties.Resources.icons8_multiply_24;
        }

        private void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (dgv.Rows[e.RowIndex].IsNewRow && e.ColumnIndex == 2)
            {
                e.Value = null;
            }
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (e.ColumnIndex == 2 && e.RowIndex >= 0 && e.RowIndex != dgv.RowCount - 1)
            {
                DataGridViewRow row = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningRow;
                dgv.Rows.Remove(row);
            }
        }
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var dataGridView = sender as DataGridView;
            int column = dataGridView.CurrentCell.ColumnIndex;
            string headerText = dataGridView.Columns[column].HeaderText;
            var tb = e.Control as TextBox;
            if (tb != null)
            {
                tb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                tb.AutoCompleteCustomSource = data;
                tb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }
        //private void GenerateGrid(DataGridView dataGridView, string HeaderID, string HeaderText, DataTable SubHeader)
        //{
        //    dataGridView.AllowUserToAddRows = false;
        //    //Adding column names

        //    dataGridView.Columns.Add("Value1", HeaderText);
        //    dataGridView.Columns.Add("value2", "");
        //    dataGridView.Columns.Add("ID", HeaderID);

        //    //COLUMN HEADER
        //    //Set Header height
        //    dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
        //    dataGridView.ColumnHeadersHeight = 50;
        //    dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        //    //Header Font
        //    dataGridView.Columns[0].HeaderCell.Style.Font = new Font("Roboto Medium", 13);
        //    //Auto Size Column
        //    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //    //Header Border
        //    dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        //    //Header Color
        //    dataGridView.EnableHeadersVisualStyles = false;
        //    dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 101, 177);
        //    dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        //    //ROW
        //    //Row Height
        //    dataGridView.RowTemplate.Height = 40;
        //    //Row Fore Color
        //    dataGridView.Columns[0].DefaultCellStyle.ForeColor = Color.FromArgb(82, 82, 84);
        //    dataGridView.Columns[1].DefaultCellStyle.ForeColor = Color.FromArgb(82, 82, 84);
        //    //Alternating Row Setup
        //    dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(237, 238, 239);
        //    dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        //    dataGridView.DefaultCellStyle.SelectionBackColor = Color.Gray;
        //    dataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
        //    dataGridView.BackgroundColor = Color.White;

        //    //GRID BORDER
        //    dataGridView.BorderStyle = BorderStyle.Fixed3D;
        //    dataGridView.RowHeadersVisible = false;

        //    dataGridView.DefaultCellStyle.Font = new Font("Roboto", 10);

        //    foreach (DataRow row in SubHeader.Rows)
        //    {
        //        dataGridView.Rows.Add(row[1].ToString(), row[2].ToString(), row[0].ToString());
        //    }
        //    dataGridView.AllowUserToAddRows = true;

        //    //Disabling Selection Color
        //    dataGridView.DefaultCellStyle.SelectionBackColor = dataGridView.DefaultCellStyle.BackColor;
        //    dataGridView.DefaultCellStyle.SelectionForeColor = dataGridView.DefaultCellStyle.ForeColor;

        //    //Hiding ID column
        //    dataGridView.Columns[2].Visible = false;
        //}
        private void Button_Click(object sender, EventArgs e) //To remove image
        {
            var button = sender as XUIButton;

            if (button != null)
            {
                var control = button.Tag as Control;
                var panel = control.Parent as FlowLayoutPanel;
                panel.Controls.Remove(control);
            }
        }
        private void frm_Editor1_Load(object sender, EventArgs e)
        {
            lab_ProductFamily.Text = Datasheet.ProductFamilly;
            Datasheet.AddSymbolList(flowPanel_Symbols, true);
            data = AutoCompleteLoadValue1();

            Datasheet.Id = "55";

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
                GenerateGrid(dgv, Datasheet.Id, headerText);
                UpdateHeaderDetails(dgv_HeaderDetails, headerText, count, dgv);
                dgv.Tag = count++;
                flowLayoutPanel1.Controls.Add(dgv);
                HeaderController.Header.DisableNewHeader();
                dgv_HeaderDetails.ClearSelection();
            }

            AddExistingImages();
        }

        private void AddExistingImages()
        {
            //Adding Images to FlowLayout
            var DimensionalDrawings = Datasheet.GetDataTable("select * from DatasheetImages where ImageID = 2  and DatasheetId = " + Datasheet.Id + "; ");
            foreach (DataRow Images in DimensionalDrawings.Rows)
            {
                Datasheet.AddImage(Images["ImageID"].ToString(), Images["Description"].ToString(), Button_Click, flowPanel_DimensionalDrawings);
            }
            var ProductImages = Datasheet.GetDataTable("select * from DatasheetImages where ImageID = 3  and DatasheetId = " + Datasheet.Id + "; ");
            foreach (DataRow Images in ProductImages.Rows)
            {
                Datasheet.AddImage(Images["ImageID"].ToString(), Images["Description"].ToString(), Button_Click, flowPanel_ProductImages);
            }
            var WiringDiagrams = Datasheet.GetDataTable("select * from DatasheetImages where ImageID = 4 and DatasheetId = " + Datasheet.Id + " ; ");
            foreach (DataRow Images in WiringDiagrams.Rows)
            {
                Datasheet.AddImage(Images["ImageID"].ToString(), Images["Description"].ToString(), Button_Click, flowPanel_WiringDiagrams);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
