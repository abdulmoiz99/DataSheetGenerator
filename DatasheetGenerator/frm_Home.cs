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
    public partial class frm_Home : Form
    {
        string productFamilyID = "";
        public frm_Home(string productFamilyID)
        {
            InitializeComponent();
            this.productFamilyID = productFamilyID;
        }
        private void Delete_Item_Click(object sender, EventArgs e)
        {
            var item = sender as MenuItem;
            SQL.NonScalarQuery("Update Datasheet set Active = 0 where Id = " + item.Tag.ToString() + ";");
        }
        private void Copy_Item_Click(object sender, EventArgs e)
        {
        }
        private void frm_Home_Load(object sender, EventArgs e)
        {
            var datasheets = Datasheet.GetDataTable("SELECT DateModified, Name, Id FROM Datasheet where PF_ID = " + productFamilyID + " AND Active = 1;");

            foreach (DataRow row in datasheets.Rows)
            {
                Label label = new Label();
                label.AutoSize = false;
                label.Size = new Size(402, 27);
                label.Font = new Font("Roboto", 11f);
                label.ForeColor = Color.FromArgb(117, 117, 117);
                label.Text = row[0] + " | " + row[1];
                label.Tag = row[2].ToString();
                label.MouseDown += Label_MouseDown;
                label.MouseEnter += Label_MouseEnter;
                label.MouseLeave += Label_MouseLeave;
                label.Click += Label_Click;
                datasheetPanel.Controls.Add(label);
            }
        }
        private void Label_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Left) 
            {
                var label = sender as Label;
                Datasheet.Id = label.Tag.ToString();
                DialogResult YorN = MessageBox.Show("Are you sure to view/edit datasheet? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (YorN == DialogResult.Yes)
                {
                    Datasheet.IsEditing = true;
                    this.Refresh();
                    this.Close();
                }
            }
        }
        private void Label_MouseLeave(object sender, EventArgs e)
        {
            var label = sender as Label;
            label.ForeColor = Color.FromArgb(117, 117, 117); //gray
        }
        private void Label_MouseEnter(object sender, EventArgs e)
        {
            var label = sender as Label;
            label.ForeColor = Color.FromArgb(140, 192, 99);
        }
        private void Label_MouseDown(object sender, MouseEventArgs e)
        {
            var label = sender as Label;
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu menu = new ContextMenu();

                MenuItem copyItem = menu.MenuItems.Add("Copy ");
                copyItem.Click += new EventHandler(Copy_Item_Click);

                MenuItem deleteItem = menu.MenuItems.Add("Delete ");
                deleteItem.Click += new EventHandler(Delete_Item_Click);

                label.ContextMenu = menu;

                copyItem.Tag = label.Tag;
                deleteItem.Tag = label.Tag;
            }
        }
    }
}
