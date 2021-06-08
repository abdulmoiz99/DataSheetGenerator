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
        public frm_Editor()
        {
            InitializeComponent();
        }

        private void DataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
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
            Editor.DisplayCenterPanel(pnl_AddHeader, txt_HeaderName, this);
        }
        //   private void GenerateGrid(DataGridView dataGridView, string HeaderID, string HeaderText, DataTable SubHeader)

        private void DataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            var dgv = sender as DataGridView;
            dgv.Rows[dgv.RowCount - 2].Cells["deleteCell"].Value = Properties.Resources.icons8_multiply_24;
        }

        private void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (dgv.Rows[e.RowIndex].IsNewRow && e.ColumnIndex == 3)
            {
                e.Value = null;
            }
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (e.ColumnIndex == 3 && e.RowIndex >= 0 && e.RowIndex != dgv.RowCount - 1)
            {
                DataGridViewRow row = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningRow;
                //if (Datasheet.IsEditing) //Add Subheader function.
                dgv.Rows.Remove(row);
            }
        }
        private void UpdateHeaderDetails(DataGridView dataGridView, string HeaderText, int Position, DataGridView refGrid)
        {
            int rowIndex = dataGridView.Rows.Add(HeaderText, Position);
            dataGridView.Rows[rowIndex].Tag = refGrid;
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
                    dgv_HeaderDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = dataGridView.Columns["Value1"].HeaderText;
                }
                else
                {
                    dataGridView.Columns["Value1"].HeaderText = dgv_HeaderDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
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
            else if (Datasheet.IsEditing)
            {
                UpdateRecord();
            }
            else
            {
                SaveRecord(false);
                MessageBox.Show("Record Save Successfully");
            }

        }
        public void UpdateRecord()
        {
            SaveRecord(true);
            MessageBox.Show("Record Updated Successfully");
        }
        private void SaveRecord(bool UpdateRecord, bool IsDraft = false)
        {
            Cursor.Current = Cursors.WaitCursor;
            Dictionary<string, Dictionary<string, string>> headers = Header.GetHeaders(flowLayoutPanel1);


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
            string HeaderID = "0";

            if (IsDraft)
            {
                myCommand.CommandText = @"update Datasheet set userID = " + User.Id + " where ID = " + Datasheet.Id + "";
                myCommand.ExecuteNonQuery();
            }
            if (UpdateRecord)
            {
                //Remove Previous Record
                myCommand.CommandText = @"update Datasheet set Active = 0  where ID = " + Datasheet.Id + "";
                myCommand.ExecuteNonQuery();

                    
                //Add New Record
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                myCommand.CommandText = "Insert into Datasheet (Name                    ,PF_ID                             ,Flag ,Type  ,DateCreated    ,DateModified    ,Active) " +
                                                       "values ('" + Datasheet.Name + "'," + Datasheet.ProductFamillyID + ",0    ,1         ,'" + date + "' ,'" + date + "'  ,1);";
                myCommand.ExecuteNonQuery();

                myCommand.CommandText = "SELECT MAX(id) FROM Datasheet;";
                Datasheet.Id  = myCommand.ExecuteScalar().ToString();


            }
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
                //Saving Header and Sub-Headers
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
                        myCommand.CommandText = @"Insert into Subheader(Value1      ,Value2          ,H_ID                ,DS_ID) 
                                                                 values('" + value1 + "','" + value2 + "'," + HeaderID + "," + Datasheet.Id + ")";

                        myCommand.ExecuteNonQuery();
                    }
                }

                //Saving Images to Database
                foreach (Control panel in flowPanel_DimensionalDrawings.Controls) //Dimensional Drawings
                {
                    List<object> values = (List<object>)panel.Tag;
                    TextBox textBox = (TextBox)values[1];
                    myCommand.CommandText = @"Insert into DatasheetImages(ImageID             ,DatasheetID           ,Description     ,Type) 
                                                                   values('" + values[0].ToString() + "'," + Datasheet.Id + ",'" + textBox.Text + "', 2)";
                    myCommand.ExecuteNonQuery();

                }
                foreach (Control panel in flowPanel_ProductImages.Controls)//Prodcut Images
                {
                    List<object> values = (List<object>)panel.Tag;
                    TextBox textBox = (TextBox)values[1];
                    myCommand.CommandText = @"Insert into DatasheetImages(ImageID             ,DatasheetID           ,Description     ,Type) 
                                                                   values(" + values[0].ToString() + "," + Datasheet.Id + ",'" + textBox.Text + "', 3)";
                    myCommand.ExecuteNonQuery();
                }
                foreach (Control panel in flowPanel_WiringDiagrams.Controls) //Wiring Diagrams
                {
                    List<object> values = (List<object>)panel.Tag;
                    TextBox textBox = (TextBox)values[1];
                    myCommand.CommandText = @"Insert into DatasheetImages(ImageID             ,DatasheetID           ,Description     ,Type) 
                                                                   values(" + values[0].ToString() + "," + Datasheet.Id + ",'" + textBox.Text + "', 4)";
                    myCommand.ExecuteNonQuery();
                }
                transaction.Commit();
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

        private void frm_Editor_Load(object sender, EventArgs e)
        {
            try
            {

                Cursor.Current = Cursors.WaitCursor;
                Datasheet.NewDataSheet = false;
                lab_ProductFamily.Text = Datasheet.ProductFamilly;
                data = Editor.AutoCompleteLoadValue1();

                //When Editing the datasheet
                if (Datasheet.IsEditing)
                {
                    Datasheet.AddSymbolList(flowPanel_Symbol, true);

                    var Header = Datasheet.GetDataTable("select Id,Name from Header where DS_ID = " + Datasheet.Id + "");
                    string headerID = "";
                    string headerText = "";
                    foreach (DataRow header in Header.Rows)
                    {
                        headerID = header["ID"].ToString();
                        headerText = header["Name"].ToString(); //HeaderController.Header.GetHeaderText(headerID);
                        var dgv = new DataGridView();
                        dgv.Size = new Size(500, 277);
                        var subHeader = Datasheet.GetDataTable("select * from Subheader where H_Id = " + headerID + ";");

                        //Generating Grid with existing data
                        Editor.GenerateGrid(dgv, Datasheet.Id, headerText,
                            DataGridView_EditingControlShowing,
                            DataGridView_CellClick,
                            DataGridView_CellFormatting,
                            DataGridView_RowsAdded,
                            subHeader, true);

                        UpdateHeaderDetails(dgv_HeaderDetails, headerText, count, dgv);
                        dgv.Tag = count++;
                        flowLayoutPanel1.Controls.Add(dgv);
                        flowLayoutPanel1.Controls.SetChildIndex(dgv, count - 1);
                    }
                    //TO load existing images 
                    AddExistingImages();
                }
                else
                {
                    //When Adding a New Datasheet
                    Datasheet.AddSymbolList(flowPanel_Symbol, false);

                    try { cmb_Category.SelectedIndex = 0; }
                    catch (Exception) { }
                    Editor.UpdateImageDetails(cmb_Category, cmb_Image);
                }
                Cursor.Current = Cursors.WaitCursor;

                try { cmb_Category.SelectedIndex = 0; }
                catch (Exception) { }


                //Fill combobox for copying to a new draft
                Main.fillComboWithoutCondition(cmb_ProductFamily, "ProductFamily", "Name", "ID");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void AddExistingImages()
        {
            //Adding Images to FlowLayout
            var DimensionalDrawings = Datasheet.GetDataTable("select * from DatasheetImages where Type = 2  and DatasheetId = " + Datasheet.Id + "; ");
            foreach (DataRow Images in DimensionalDrawings.Rows)
            {
                Datasheet.AddImage(Images["ImageID"].ToString(), Images["Description"].ToString(), Button_Click, flowPanel_DimensionalDrawings);
            }

            var ProductImages = Datasheet.GetDataTable("select * from DatasheetImages where Type = 3  and DatasheetId = " + Datasheet.Id + "; ");
            foreach (DataRow Images in ProductImages.Rows)
            {
                Datasheet.AddImage(Images["ImageID"].ToString(), Images["Description"].ToString(), Button_Click, flowPanel_ProductImages);
            }

            var WiringDiagrams = Datasheet.GetDataTable("select * from DatasheetImages where Type = 4 and DatasheetId = " + Datasheet.Id + " ; ");
            foreach (DataRow Images in WiringDiagrams.Rows)
            {
                Datasheet.AddImage(Images["ImageID"].ToString(), Images["Description"].ToString(), Button_Click, flowPanel_WiringDiagrams);
            }
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
        private bool IsHeaderNameExists(string name)
        {
            foreach (DataGridViewRow row in dgv_HeaderDetails.Rows)
            {
                if (row.Cells[0].Value.ToString() == name)
                {
                    return true;
                }
            }

            return false;
        }

        private void btn_AddNewHeader_Click(object sender, EventArgs e)
        {
            if (txt_HeaderName.Text == "")
            {
                MessageBox.Show("Please Enter Header Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (IsHeaderNameExists(txt_HeaderName.Text)) //Header Name Already Exist
            {
                MessageBox.Show("Header Name Alreay Exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var dgv = new DataGridView();
                dgv.Size = new Size(500, 277);

                Editor.GenerateGrid(dgv, "", txt_HeaderName.Text,
                    DataGridView_EditingControlShowing,
                    DataGridView_CellClick,
                    DataGridView_CellFormatting,
                    DataGridView_RowsAdded);

                UpdateHeaderDetails(dgv_HeaderDetails, txt_HeaderName.Text, count, dgv);
                dgv.Tag = count++;
                flowLayoutPanel1.Controls.Add(dgv);
                flowLayoutPanel1.Controls.SetChildIndex(dgv, count - 1);
                HeaderController.Header.DisableNewHeader();
                dgv_HeaderDetails.ClearSelection();
                txt_HeaderName.Clear();
                pnl_AddHeader.Visible = false;
            }
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
                    Datasheet.AddImage(cmb_Image.SelectedValue.ToString(), "", Button_Click, flowPanel_DimensionalDrawings);
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
                    Datasheet.AddImage(cmb_Image.SelectedValue.ToString(), "", Button_Click, flowPanel_ProductImages);
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
                    Datasheet.AddImage(cmb_Image.SelectedValue.ToString(), "", Button_Click, flowPanel_WiringDiagrams);
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
            Editor.UpdateImageDetails(cmb_Category, cmb_Image);
        }
        private void btn_UploadImages_Click(object sender, EventArgs e)
        {
            var frm = new frm_MediaLibrary();
            frm.ShowDialog();
        }
        private void btn_AddSymbol_Click(object sender, EventArgs e)
        {
            frm_MediaLibrary frm = new frm_MediaLibrary();
            frm.Tag = flowPanel_Symbol;
            frm.ShowDialog();
        }
        private void btn_SaveAsDraft_Click(object sender, EventArgs e)
        {
            if (count <= 1)
            {
                MessageBox.Show("No Record To Save");
                return;
            }
            else if (Datasheet.IsEditing)
            {
                MessageBox.Show("Will be done soon..");
            }
            else
            {
                SaveRecord(false, true); // isDraft = true
                MessageBox.Show("Draft Saved Successfully");
            }

        }

        private void btn_SaveNewDraft_Click(object sender, EventArgs e)
        {
            if (txt_NewDraftName.Text == "")
            {
                MessageBox.Show("Enter Draft Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cmb_ProductFamily.SelectedIndex < 0)
            {
                MessageBox.Show("Please select product family", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Datasheet.Exist(txt_NewDraftName.Text, cmb_ProductFamily.SelectedValue.ToString()))
            {
                MessageBox.Show("Datasheet With Same Name Already Exisit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                if (SQL.NonScalarQuery("Insert into Datasheet (Name                           ,PF_ID                                  ,Flag ,Type  ,DateCreated    ,DateModified   ,Active  ,UserID) " +
                                                      "values ('" + txt_NewDraftName.Text + "'," + cmb_ProductFamily.SelectedValue + ",0    ,1     ,'" + date + "','" + date + "'  ,1       ," + User.Id + ")"))
                {
                    Datasheet.ProductFamilly = cmb_ProductFamily.Text;
                    Datasheet.Name = txt_NewDraftName.Text;
                    Datasheet.IsCreated = true;
                    Datasheet.Id = Datasheet.GetLatestId();
                    SaveRecord(false, true);
                    MessageBox.Show("Draft Saved Successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Unable To Create New New Draft", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btn_CopyToDraft_Click(object sender, EventArgs e)
        {
            Editor.DisplayCenterPanel(pnl_CopyToANewDraft, txt_NewDraftName, this);
        }

        private void btn_CloseDraft_Click(object sender, EventArgs e)
        {
            pnl_CopyToANewDraft.Hide();
        }

        private void btn_CloseNewDraft_Click(object sender, EventArgs e)
        {
            pnl_CopyToANewDraft.Hide();
        }

        private void btn_DownloadPDF_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Download PDF file feature will be added in the second milestone", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
