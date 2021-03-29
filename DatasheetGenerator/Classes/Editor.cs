﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatasheetGenerator
{
    class Editor
    {
        private static Dictionary<string, List<string>> subHeaders = new Dictionary<string, List<string>>();
        public static void DisplayCenterPanel(Panel panel, MaterialSkin.Controls.MaterialSingleLineTextField textBox, Form form)
        {
            panel.Location = new Point(form.ClientSize.Width / 2 - panel.Size.Width / 2, form.ClientSize.Height / 2 - panel.Size.Height / 2);
            panel.Anchor = AnchorStyles.None;
            panel.Visible = true;
            panel.BringToFront();
            textBox.Focus();
        }
        public static AutoCompleteStringCollection AutoCompleteLoadValue1()
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
        public static void GenerateGrid(DataGridView dataGridView, string HeaderID,  string HeaderText,
            DataGridViewEditingControlShowingEventHandler EditingControlShowing,
            DataGridViewCellEventHandler CellClick,
            DataGridViewCellFormattingEventHandler CellFormatting,
            DataGridViewRowsAddedEventHandler RowAdded,
            DataTable SubHeader = null, bool IsEditing = false)
        {
            dataGridView.AllowUserToAddRows = false;
            //Adding column names
            dataGridView.Columns.Add("ID", HeaderID);
            dataGridView.Columns.Add("Value1", HeaderText);
            dataGridView.Columns.Add("Value2", "");

            DataGridViewImageColumn column = new DataGridViewImageColumn();
            column.Name = "deleteCell";
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
            dataGridView.Columns["Value1"].HeaderCell.Style.Font = new Font("Roboto Medium", 13);//Header
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
            dataGridView.Columns["Value1"].DefaultCellStyle.ForeColor = Color.FromArgb(82, 82, 84);
            dataGridView.Columns["Value2"].DefaultCellStyle.ForeColor = Color.FromArgb(82, 82, 84);
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

            if (IsEditing)
            {
                foreach (DataRow subheader in SubHeader.Rows)
                {
                    dataGridView.Rows.Add(subheader["ID"].ToString(),  subheader["Value1"].ToString(),subheader["Value2"].ToString(), Properties.Resources.icons8_multiply_24);
                }
            }

            //dataGridView.Rows.Add("Product Name", "Text Field", Properties.Resources.icons8_multiply_24);
            //dataGridView.Rows.Add("Product Code", "Text Field", Properties.Resources.icons8_multiply_24);
            //dataGridView.Rows.Add("Product Description", "Text Field", Properties.Resources.icons8_multiply_24);
            dataGridView.AllowUserToAddRows = true;

            //Disabling Selection Color
            dataGridView.DefaultCellStyle.SelectionBackColor = dataGridView.DefaultCellStyle.BackColor;
            dataGridView.DefaultCellStyle.SelectionForeColor = dataGridView.DefaultCellStyle.ForeColor;

            //Hiding ID column
            dataGridView.Columns["ID"].Visible = false;

            dataGridView.EditingControlShowing += EditingControlShowing;
            dataGridView.CellClick += CellClick;
            dataGridView.CellFormatting += CellFormatting;
            dataGridView.RowsAdded += RowAdded;
        }
        public static void UpdateImageDetails(SergeUtils.EasyCompletionComboBox CategoryComboBox, SergeUtils.EasyCompletionComboBox ImageComboBox)
        {
            int type = 0;
            if (CategoryComboBox.SelectedIndex == 0) type = 2; //Dimensional Drawings
            else if (CategoryComboBox.SelectedIndex == 1) type = 3; //Product Images
            else if (CategoryComboBox.SelectedIndex == 2) type = 4; //Wiring Diagrams
            Main.fillCombo(ImageComboBox, "MediaLibrary", "Name", "ID", "Type = " + type + "");

        }

        public static void AddSubheader(string headerID, string subHeaderID) 
        {
            List<string> subHeader;

            if (subHeaders.ContainsKey(headerID))
            {
                subHeader = subHeaders[headerID];
            }
            else 
            {
                subHeader = new List<string>();
                subHeaders.Add(headerID, subHeader);             
            }

            subHeader.Add(subHeaderID);
        }

        public static void DeleteHeadersFromDatabase() 
        {
            foreach (string headerID in subHeaders.Keys) 
            {
                List<string> subHeader = subHeaders[headerID];
                foreach (string subHeaderID in subHeader) 
                {
                    //Paste delete query here
                    //Parameters given: headerID, subHeaderID
                }
            }

            subHeaders.Clear();
        }
    }
}