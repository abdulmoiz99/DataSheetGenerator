﻿using System;
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
    public partial class frm_Drafts : Form
    {
        public frm_Drafts()
        {
            InitializeComponent();
        }

        private void frm_Drafts_Load(object sender, EventArgs e)
        {
            var datasheets = Datasheet.GetDataTable("SELECT DATE_FORMAT(DateModified, '%d-%m-%Y') AS DateModified, Name, Id FROM Datasheet where userID = " + User.Id + " AND Active = 1  order by DateModified DESC;");

            foreach (DataRow row in datasheets.Rows)
            {
                Label label = new Label();
                label.AutoSize = false;
                label.Size = new Size(402, 27);
                label.Font = new Font("Roboto", 11f);
                label.ForeColor = Color.FromArgb(117, 117, 117);
                label.Text = row["DateModified"] + " | " + row["Name"];
                label.Tag = row["Id"].ToString();
                label.MouseDown += Label_MouseDown;
                label.MouseEnter += Label_MouseEnter;
                label.MouseLeave += Label_MouseLeave;
                label.Click += Label_Click;
                draftsPanel.Controls.Add(label);
            }
        }

        private void Label_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Left)
            {
                var label = sender as Label;
                Datasheet.Id = label.Tag.ToString();
                Cursor.Current = Cursors.WaitCursor;
                Form parentForm = MdiParent;
                frm_Editor form = new frm_Editor();
                form.MdiParent = parentForm;
                form.Dock = DockStyle.Fill;
                Datasheet.IsEditing = true;
                form.Show();
                Close();
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

                copyItem.Tag = label;
                deleteItem.Tag = label;
            }
        }

        private void Delete_Item_Click(object sender, EventArgs e)
        {
            var item = sender as MenuItem;
            var label = (Label)item.Tag;
            SQL.NonScalarQuery("Update Datasheet set Active = 0 where Id = " + label.Tag.ToString() + ";");
            draftsPanel.Controls.Remove(label);
        }

        private void Copy_Item_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
