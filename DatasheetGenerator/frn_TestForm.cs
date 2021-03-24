using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
              

        }

        private static Image GetImage()
        {
            Image image = new Bitmap(420, 420); ;
            try
            {
                if (SQL.con.State == ConnectionState.Closed) SQL.con.Open();
                //Retrieve BLOB from database into DataSet.
                MySqlCommand cmd = new MySqlCommand("select Id,Image from MediaLibrary where ID = 3", SQL.con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "MediaLibrary");
                int c = ds.Tables["MediaLibrary"].Rows.Count;

                if (c > 0)
                {
                    Byte[] byteBLOBData = new Byte[0];
                    byteBLOBData = (Byte[])(ds.Tables["MediaLibrary"].Rows[c - 1]["Image"]);
                    MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                    image = Image.FromStream(stmBLOBData);
                    
                }
                return image;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return image;
            }
        }

        private void AddImage(string ImageId, string labelText, Image image, FlowLayoutPanel flowLayoutPanel)
        {
            var panel = new Panel();
            panel.Size = new Size(203, 210);
            panel.Tag = ImageId;

            var label = new Label();
            label.Text = labelText;
            label.Font = new Font("Roboto", 11);
            label.ForeColor = Color.FromArgb(117, 117, 117);
            label.AutoSize = false;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Size = new Size(203, 37);
            label.Dock = DockStyle.Top;

            var pictureBox = new PictureBox();
            pictureBox.Size = new Size(203, 164);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.BackColor = Color.Beige;
            pictureBox.Image = image;

            var button = new XanderUI.XUIButton();
            button.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            button.Font = new Font("Roboto Slab", 12);
            button.ButtonText = "Remove";
            button.Size = new Size(203, 36);
            button.BackgroundColor = Color.FromArgb(117, 117, 117);
            button.TextColor = Color.White;
            button.Dock = DockStyle.Bottom;

            panel.Controls.Add(label);
            panel.Controls.Add(pictureBox);
            panel.Controls.Add(button);

            flowLayoutPanel.Controls.Add(panel);
        }
    }
}
