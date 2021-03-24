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
    public partial class frm_Editor : Form
    {
        int HeaderChangedIndex = 0;
        int count = 1;
        AutoCompleteStringCollection data;
        public void DisplayAddHeaderPanel()
        {
            pnl_AddHeader.Location = new Point(this.ClientSize.Width / 2 - pnl_AddHeader.Size.Width / 2, this.ClientSize.Height / 2 - pnl_AddHeader.Size.Height / 2);
            pnl_AddHeader.Anchor = AnchorStyles.None;
            pnl_AddHeader.Visible = true;
            pnl_AddHeader.BringToFront();
            txt_HeaderName.Focus();
        }
        public frm_Editor()
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
        private void btn_AddHeader_Click(object sender, EventArgs e)
        {
            DisplayAddHeaderPanel();
            //var frm = new frm_AddHeaderPopup();
            //frm.ShowDialog();
            //this.Refresh();
        }
        private void GenerateGrid(DataGridView dataGridView, string HeaderText)
        {
            dataGridView.AllowUserToAddRows = false;
            //Adding column names
            dataGridView.Columns.Add("newColumnName", HeaderText);
            dataGridView.Columns.Add("newColumnName1", "");

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

        private void UpdateHeaderDetails(DataGridView dataGridView, string HeaderText, int Position, DataGridView refGrid)
        {
            int rowIndex = dataGridView.Rows.Add(HeaderText, Position);
            dataGridView.Rows[rowIndex].Tag = refGrid;
        }
        private void frm_Editor_Activated(object sender, EventArgs e)
        {

        }
        private void dgv_HeaderDetails_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                var row = dgv_HeaderDetails.Rows[e.RowIndex];
                HeaderChangedIndex = Convert.ToInt32(row.Cells[1].Value);
            }
        }
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void dgv_HeaderDetails_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dgv_HeaderDetails.CurrentCell.ColumnIndex == 1) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }
        private void dgv_HeaderDetails_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Name Change
            if (e.ColumnIndex == 0)
            {
                DataGridView dataGridView = (DataGridView)dgv_HeaderDetails.Rows[e.RowIndex].Tag;

                if (dgv_HeaderDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                {
                    dgv_HeaderDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = dataGridView.Columns[0].HeaderText;
                }
                else
                {
                    dataGridView.Columns[0].HeaderText = dgv_HeaderDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                }
            }
            //Position Change
            else if (e.ColumnIndex == 1)
            {
                if (dgv_HeaderDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                {
                    dgv_HeaderDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = HeaderChangedIndex;
                }

                else
                {
                    dgv_HeaderDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Convert.ToInt32(dgv_HeaderDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);

                    foreach (DataGridViewRow row in dgv_HeaderDetails.Rows)
                    {
                        if (row.Cells[1].Value.ToString() == dgv_HeaderDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() && row.Index != e.RowIndex)
                        {
                            row.Cells[1].Value = HeaderChangedIndex;
                        }
                    }
                }
            }
        }
        private void dgv_HeaderDetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                dgv_HeaderDetails.Sort(dgv_HeaderDetails.Columns[1], ListSortDirection.Ascending);
                Header.ReOrder(dgv_HeaderDetails);
                for (int i = 0; i < dgv_HeaderDetails.RowCount; i++)
                {
                    var dgv = (DataGridView)dgv_HeaderDetails.Rows[i].Tag;
                    flowLayoutPanel1.Controls.Add(dgv);
                    flowLayoutPanel1.Controls.SetChildIndex(dgv, i + 1);
                }
            }
        }
        private void frm_Editor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.H)
            {
                var frm = new frm_AddHeaderPopup();
                frm.ShowDialog();
            }
        }
        private void xuiButton5_Click_1(object sender, EventArgs e)
        {

            if (dgv_HeaderDetails.IsCurrentCellInEditMode)
            {
                dgv_HeaderDetails.EndEdit();
            }
        }
        private void dgv_HeaderDetails_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            flowLayoutPanel1.Controls.Remove((DataGridView)e.Row.Tag);
        }
        private void dgv_HeaderDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_HeaderDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningRow;
                flowLayoutPanel1.Controls.Remove((DataGridView)row.Tag);
                dgv_HeaderDetails.Rows.Remove(row);
                Header.ReOrder(dgv_HeaderDetails);
                count--;
                dgv_HeaderDetails.ClearSelection();
            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (count <= 1)
            {
                MessageBox.Show("No Record To Save");
                return;
            }
            Cursor.Current = Cursors.WaitCursor;
            Dictionary<string, Dictionary<string, string>> headers = Header.GetHeaders(flowLayoutPanel1);
            string HeaderID = "0";


            if (SQL.Con.State == ConnectionState.Open)
            {
                SQL.Con.Close();
            }
            SQL.Con.Open();

            MySqlCommand myCommand = SQL.con.CreateCommand();
            MySqlTransaction transaction;

            // Start a local transaction
            transaction = SQL.con.BeginTransaction();
            // Must assign both transaction object and connection
            // to Command object for a pending local transaction
            myCommand.Connection = SQL.con;
            myCommand.Transaction = transaction;

            try
            {
                //Saving Symbol to the database
                foreach (XUICheckBox symbol in flowPanel_Symbol.Controls.OfType<XUICheckBox>())
                {
                    if (symbol.Checked == true)
                    {
                        myCommand.CommandText = @"Insert Into DatasheetSymbol(D_ID                  ,S_ID) 
                                                                   values('" + Datasheet.Id + "'," + symbol.Tag + ")";
                        myCommand.ExecuteNonQuery();
                    }

                }
                foreach (string header in headers.Keys)
                {


                    string headerText = header;

                    //Inserting values into Header Table
                    myCommand.CommandText = @"Insert Into Header(Name           ,DS_ID) 
                                                          values('" + header + "'," + Datasheet.Id + ")";
                    myCommand.ExecuteNonQuery();
                    //Get the latest value from headerTable
                    myCommand.CommandText = "Select  MAX(ID) from Header where DS_ID =  " + Datasheet.Id + "";
                    HeaderID = myCommand.ExecuteScalar().ToString(); ;


                    foreach (string subHeader in headers[header].Keys)
                    {
                        string value1 = subHeader;
                        string value2 = headers[header][subHeader];

                        //Inserting values into Sub - Header Table // H_ID = Header ID
                        myCommand.CommandText = @"Insert into Subheader(Value1      ,Value2          ,H_ID) 
                                                                 values('" + value1 + "','" + value2 + "'," + HeaderID + ")";

                        myCommand.ExecuteNonQuery();
                    }
                }
                transaction.Commit();
                MessageBox.Show("Record Added Successfully");
                this.Close();
            }
            catch (Exception ex)
            {

                transaction.Rollback();

                MessageBox.Show(ex.Message);
            }
            finally
            {
                SQL.con.Close();
                Cursor.Current = Cursors.Default;
            }

        }
        public void UpdateImageDetails()
        {
            int type = 0;
            if (cmb_Category.SelectedIndex == 0) type = 2;
            else if (cmb_Category.SelectedIndex == 1) type = 3;
            else if (cmb_Category.SelectedIndex == 2) type = 4;
            cmb_Image.SelectedIndex = -1;
            Main.fillCombo(cmb_Image, "MediaLibrary", "Name", "ID", "Type = " + type + "");
        }
        private void frm_Editor_Load(object sender, EventArgs e)
        {
            lab_ProductFamily.Text = Datasheet.ProductFamilly;
            data = AutoCompleteLoadValue1();

            Datasheet.AddSymbolList(flowPanel_Symbol, false);

            try { cmb_Category.SelectedIndex = 0; }
            catch (Exception) { }
            UpdateImageDetails();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            pnl_AddHeader.Visible = false;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_HeaderName.Clear();
            pnl_AddHeader.Visible = false;
        }

        private void btn_AddNewHeader_Click(object sender, EventArgs e)
        {
            HeaderController.Header.AddNewHeader();
            HeaderController.Header.SetHeaderText(txt_HeaderName.Text);

            if (HeaderController.Header.CheckNewHeader())
            {
                var dgv = new DataGridView();
                dgv.Size = new Size(546, 277);
                GenerateGrid(dgv, HeaderController.Header.GetHeaderText());
                UpdateHeaderDetails(dgv_HeaderDetails, HeaderController.Header.GetHeaderText(), count, dgv);
                dgv.Tag = count++;
                flowLayoutPanel1.Controls.Add(dgv);
                flowLayoutPanel1.Controls.SetChildIndex(dgv, count - 1);
                HeaderController.Header.DisableNewHeader();
                dgv_HeaderDetails.ClearSelection();
                txt_HeaderName.Clear();
            }
            pnl_AddHeader.Visible = false;
        }

        private void pnl_AddHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xuiCustomGroupbox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_AddImage_Click(object sender, EventArgs e)
        {
            if (cmb_Image.SelectedIndex < 0)
            {
                MessageBox.Show("No Image Selcted", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string ImageID = cmb_Image.SelectedValue.ToString();
            int category = cmb_Category.SelectedIndex;
            if (category == 0) //Dimensional Drawings
            {
                if (Datasheet.ContainsImage(ImageID, flowPanel_DimensionalDrawings))
                {
                    MessageBox.Show("Image Already Added", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Datasheet.AddImage(cmb_Image.SelectedValue.ToString(), Button_Click, flowPanel_DimensionalDrawings);
                }
            }
            else if (category == 1) //Product Images
            {
                if (Datasheet.ContainsImage(ImageID, flowPanel_ProductImages))
                {
                    MessageBox.Show("Image Already Added", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Datasheet.AddImage(cmb_Image.SelectedValue.ToString(), Button_Click, flowPanel_ProductImages);
                }
            }
            else if (category == 2) //Wiring Diagrams
            {
                if (Datasheet.ContainsImage(ImageID, flowPanel_WiringDiagrams))
                {
                    MessageBox.Show("Image Already Added", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Datasheet.AddImage(cmb_Image.SelectedValue.ToString(), Button_Click, flowPanel_WiringDiagrams);
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var button = sender as XUIButton;

            if (button != null)
            {
                var control = button.Tag as Control;
                var panel = control.Parent as FlowLayoutPanel;
                panel.Controls.Remove(control);
            }
        }
        
        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateImageDetails();
        }

        private void cmb_Image_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgv_HeaderDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
