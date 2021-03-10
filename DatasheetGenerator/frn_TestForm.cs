﻿using MySql.Data.MySqlClient;
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
        AutoCompleteStringCollection data; 
        public frn_TestForm()
        {
            InitializeComponent();
        }

        private void frn_TestForm_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn dgvslno = new DataGridViewTextBoxColumn();
            dgvslno.HeaderText = "ID";
            dgvslno.Width = 150;
            dataGridView1.Columns.Add(dgvslno);

            DataGridViewTextBoxColumn dgvpro = new DataGridViewTextBoxColumn();
            dgvpro.HeaderText = "Value";
            dgvpro.Width = 150;
            dataGridView1.Columns.Add(dgvpro);


            data = AutoCompleteLoad();
        }
        public AutoCompleteStringCollection AutoCompleteLoad()
        {
            var conn = new MySqlConnection(@"server=sql6.freemysqlhosting.net;port=3306;user id=sql6397749; password=CU6wE3Q1ve; database=sql6397749;");

            var cmd = new MySqlCommand("Select Value from TestTable", conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            AutoCompleteStringCollection mycoll = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                mycoll.Add(dr["Value"].ToString());
            }
            return mycoll;
        }
        private void GenerateGrid(DataGridView dataGridView)
        {
            //Adding column names
            dataGridView.Columns.Add("newColumnName", "Gerneral");
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
        }


        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int column = dataGridView1.CurrentCell.ColumnIndex;
            string headerText = dataGridView1.Columns[column].HeaderText;

            if (headerText.Equals("Value"))
            {
                TextBox tb = e.Control as TextBox;

                if (tb != null)
                {
                    tb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    tb.AutoCompleteCustomSource = data;
                    tb.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
            }
            else
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.AutoCompleteMode = AutoCompleteMode.None;
                }
            }
        }
    }
}