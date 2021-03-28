using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XanderUI;

namespace DatasheetGenerator
{
    class Datasheet
    {
        public static bool IsCreated = false;
        public static bool IsEditing = false;
        public static bool NewProductFamilyCreated = true;  //Set true so that it will update the list when the form is loaded for the first time 


        public static string Id { get; set; }
        public static string ProductFamilly { get; set; }
        public static string Name { get; set; }

        public static DataTable GetDataTable(string Query)
        {
            if (SQL.con.State == ConnectionState.Open)
            {
                SQL.con.Close();

            }
            SQL.con.Open();
            DataTable datasheets = new DataTable();
            MySqlCommand command = new MySqlCommand(Query, SQL.con);
            var adapter = new MySqlDataAdapter(command);
            adapter.Fill(datasheets);
            adapter.Dispose();
            return datasheets;
        }
        public static string GetLatestId()
        {
            return SQL.ScalarQuery("SELECT MAX(id) FROM Datasheet;");
        }
        public static bool Exist(string datasheetName)
        {
            string result = "0";
            result = SQL.ScalarQuery("SELECT EXISTS(SELECT * FROM Datasheet WHERE name = '" + datasheetName + "' and active = 1)");
            if (result == "1")
            {
                return true;
            }
            else return false;
        }
        private static Image GetImage(string ImageID)
        {
            Image image = new Bitmap(420, 420); ;
            try
            {
                if (SQL.con.State == ConnectionState.Closed) SQL.con.Open();
                //Retrieve BLOB from database into DataSet.
                MySqlCommand cmd = new MySqlCommand("select Id,Image from MediaLibrary where ID = " + ImageID + "", SQL.con);
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
        private static string getImageLabelText(string ImageID)
        {
            return SQL.ScalarQuery("select Name from MediaLibrary where ID = " + ImageID + "");
        }
        public static bool ContainsImage(string ImageId, FlowLayoutPanel flowLayoutPanel)
        {
            foreach (Control control in flowLayoutPanel.Controls)
            {
                if (ImageId == control.Tag.ToString())
                {
                    return true;
                }
            }
            return false;
        }
        public static void AddSymbolList(FlowLayoutPanel flowLayoutPanel, bool editSheet) // If the sheet is for adding purpose or editing 
        {
            //Display product family 
            var symbol = Datasheet.GetDataTable("select Id,Name from MediaLibrary where Type = 1 and Active = 1");
                
            if (flowLayoutPanel.Controls != null) flowLayoutPanel.Controls.Clear();
            foreach (DataRow media in symbol.Rows)
            {
                var checkBox = new XUICheckBox();
                checkBox.AutoSize = false;
                checkBox.CheckboxStyle = XUICheckBox.Style.iOS;
                checkBox.Text = media["Name"].ToString();
                checkBox.Tag = media["ID"].ToString();
                if (editSheet == true && CheckSymbol(media["ID"].ToString()) == true)
                {
                    checkBox.Checked = true;
                }
                checkBox.ForeColor = Color.FromArgb(117, 117, 117);
                checkBox.Size = new Size(251, 36);
                checkBox.Font = new Font("Roboto Medium", 10);
                flowLayoutPanel.Controls.Add(checkBox);
            }
        }
        public static bool VerifyUser(string username, string password)
        {
            string result = "0";
            result = SQL.ScalarQuery("SELECT EXISTS(SELECT * FROM Login WHERE username = '" + username + "' and  password = '" + password + "' and  active = '1');");
            if (result == "1") return true;
            else return false;
        }
        private static bool CheckSymbol(string symbolID)
        {

            string result = "0";
            result = SQL.ScalarQuery("SELECT EXISTS(SELECT * FROM DatasheetSymbol WHERE  D_ID= " + Convert.ToInt32(Datasheet.Id) + " and S_ID = " + Convert.ToInt32(symbolID) + " ) ;");
            if (result == "1") return true;
            else return false;

        }
        public static void AddImage(string ImageId, string description, EventHandler Button_Click, FlowLayoutPanel flowLayoutPanel)
        {
            List<object> values = new List<object>();

            var panel = new FlowLayoutPanel();
            panel.Size = new Size(155, 210);

            var label = new Label();
            label.Text = getImageLabelText(ImageId);
            label.Font = new Font("Roboto", 10);
            label.ForeColor = Color.FromArgb(117, 117, 117);
            label.AutoSize = false;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Size = new Size(150, 20);
            label.Dock = DockStyle.Top;

            var pictureBox = new PictureBox();
            pictureBox.Size = new Size(150, 100);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Image = GetImage(ImageId);
            pictureBox.Dock = DockStyle.Top;

            var textBox = new TextBox();
            textBox.Size = new Size(150, 40);
            textBox.Multiline = true;
            textBox.Font = new Font("Roboto", 10);
            textBox.ForeColor = Color.FromArgb(117, 117, 117);
            textBox.Text = description;

            var button = new XanderUI.XUIButton();
            button.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            button.Font = new Font("Roboto Slab", 12);
            button.ButtonText = "Remove";
            button.Size = new Size(150, 30);
            button.BackgroundColor = Color.FromArgb(117, 117, 117);
            button.TextColor = Color.White;
            button.Dock = DockStyle.Bottom;
            button.Click += Button_Click;

            panel.Controls.Add(label);
            panel.Controls.Add(pictureBox);
            panel.Controls.Add(textBox);
            panel.Controls.Add(button);

            values.Add(ImageId);
            values.Add(textBox);

            panel.Tag = values;

            button.Tag = panel;

            panel.BringToFront();

            flowLayoutPanel.Controls.Add(panel);
        }
    }
}
