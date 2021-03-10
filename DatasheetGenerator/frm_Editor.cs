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

namespace DatasheetGenerator
{
    public partial class frm_Editor : Form
    {
        int HeaderChangedIndex = 0;
        int count = 1;
        public frm_Editor()
        {
            InitializeComponent();
        }
        private void btn_AddHeader_Click(object sender, EventArgs e)
        {
            var frm = new frm_AddHeaderPopup();
            frm.ShowDialog();
            this.Refresh();
        }
        private void GenerateGrid(DataGridView dataGridView, string HeaderText)
        {
            dataGridView.AllowUserToAddRows = false;
            //Adding column names
            dataGridView.Columns.Add("newColumnName", HeaderText);
            dataGridView.Columns.Add("newColumnName1", "");


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

            dataGridView.Rows.Add("Product Name", "Text Field");
            dataGridView.Rows.Add("Product Code", "Text Field");
            dataGridView.Rows.Add("Prodcut Description", "Text Field");
            dataGridView.AllowUserToAddRows = true;

            //Disabling Selection Color
            dataGridView.DefaultCellStyle.SelectionBackColor = dataGridView.DefaultCellStyle.BackColor;
            dataGridView.DefaultCellStyle.SelectionForeColor = dataGridView.DefaultCellStyle.ForeColor;

        }
        private void UpdateHeaderDetails(DataGridView dataGridView, string HeaderText, int Position, DataGridView refGrid)
        {
            int rowIndex = dataGridView.Rows.Add(HeaderText, Position);
            dataGridView.Rows[rowIndex].Tag = refGrid;
        }
        private void frm_Editor_Activated(object sender, EventArgs e)
        {
            if (HeaderController.Header.CheckNewHeader())
            {
                var dgv = new DataGridView();
                dgv.Size = new Size(546, 277);
                GenerateGrid(dgv, HeaderController.Header.GetHeaderText());
                UpdateHeaderDetails(dgv_HeaderDetails, HeaderController.Header.GetHeaderText(), count, dgv);
                dgv.Tag = count++;
                flowLayoutPanel1.Controls.Add(dgv);
                HeaderController.Header.DisableNewHeader();
                dgv_HeaderDetails.ClearSelection();
            }
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

                foreach (DataGridViewRow row in dgv_HeaderDetails.Rows)
                {
                    flowLayoutPanel1.Controls.Add((DataGridView)row.Tag);
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


            if (SQL.Con.State == ConnectionState.Closed) SQL.Con.Open();


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
                foreach (string header in headers.Keys)
                {


                    string headerText = header;

                    //Inserting values into Header Table
                    myCommand.CommandText = @"Insert Into sql6397749.Header(Name           ,DS_ID) 
                                                                                            values('" + header + "'," + Header.DatasheetID + ")";
                    myCommand.ExecuteNonQuery();
                    //Get the latest value from headerTable
                    myCommand.CommandText = "Select  MAX(ID) from Header where DS_ID =  " + Header.DatasheetID + "";
                    HeaderID = myCommand.ExecuteScalar().ToString(); ;


                    foreach (string subHeader in headers[header].Keys)
                    {
                        string value1 = subHeader;
                        string value2 = headers[header][subHeader];

                        //Inserting values into Sub - Header Table // H_ID = Header ID
                        myCommand.CommandText = @"Insert into sql6397749.Subheader(Value1      ,Value2          ,H_ID) 
                                                                                      values('" + value1 + "','" + value2 + "'," + HeaderID + ")";

                        myCommand.ExecuteNonQuery();
                    }
                }
                transaction.Commit();
                MessageBox.Show("Record Added Successfully");
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






















            //using (MySqlTransaction trans = SQL.Con.BeginTransaction())
            //{
            //    try
            //    {

            //        foreach (string header in headers.Keys)
            //        {


            //            string headerText = header;

            //            //Inserting values into Header Table
            //            SQL.NonScalarQueryTransaction(@"Insert Into sql6397749.Header(Name           ,DS_ID) 
            //                                                                                values('" + header + "'," + Header.DatasheetID + ")", trans);

            //            //Get the latest value from headerTable
            //            HeaderID = SQL.ScalarQuery("Select  MAX(ID) from Header where DS_ID =  " + Header.DatasheetID + "");

            //            foreach (string subHeader in headers[header].Keys)
            //            {
            //                string value1 = subHeader;
            //                string value2 = headers[header][subHeader];

            //                //Inserting values into Sub - Header Table // H_ID = Header ID
            //                SQL.NonScalarQueryTransaction(@"Insert into sql6397749.Subheader1(Value1      ,Value2          ,H_ID) 
            //                                                                          values('" + value1 + "','" + value2 + "'," + HeaderID + ")", trans);
            //            }
            //        }
            //        trans.Commit();
            //        MessageBox.Show("Saved");

            //    }
            //    catch (Exception ex)
            //    {

            //         trans.Rollback();


            //    }
            //    finally
            //    {
            //        SQL.Con.Close();
            //    }
            //}
        }
    }
}
