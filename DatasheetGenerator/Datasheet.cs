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

namespace DatasheetGenerator
{
    class Datasheet
    {
        public static bool IsCreated = false;
        public static bool IsEditing = false;
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
        public static void AddImage(string ImageId, EventHandler Button_Click, FlowLayoutPanel flowLayoutPanel)
        {
            var panel = new FlowLayoutPanel();
            panel.Size = new Size(155, 210);
            panel.Tag = ImageId;

            var label = new Label();
            label.Text = getImageLabelText(ImageId);
            label.Font = new Font("Roboto", 10);
            label.ForeColor = Color.FromArgb(117, 117, 117);
            label.AutoSize = false;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Size = new Size(150, 30);
            label.Dock = DockStyle.Top;

            var pictureBox = new PictureBox();
            pictureBox.Size = new Size(150, 120);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Image = GetImage(ImageId);
            pictureBox.Dock = DockStyle.Top;

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
            panel.Controls.Add(button);

            panel.BringToFront();

            flowLayoutPanel.Controls.Add(panel);
        }
    }
}
