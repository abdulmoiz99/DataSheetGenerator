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
    public partial class frm_Dashboard : Form
    {
        public frm_Dashboard()
        {
            InitializeComponent();
        }
        private void frm_Dashboard_Load(object sender, EventArgs e)
        {
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.White;
        }
        private void btn_NewDatasheet_Click(object sender, EventArgs e)
        {
            CloseAllForm();
            var frm = new frm_CreateDatasheet();
            frm.ShowDialog();
        }
        private void CloseAllForm()
        {
            foreach (Form form in MdiChildren)
            {
                form.Close();
            }
        }
        private void btn_MediaLinrary_Click(object sender, EventArgs e)
        {
            CloseAllForm();
            var frm = new frm_MediaLibrary();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
        private void frm_Dashboard_Activated(object sender, EventArgs e)
        {
            if (Datasheet.NewProductFamilyCreated)
            {
                //Display product family 
                var ProductFamily = Datasheet.GetDataTable("select * from ProductFamily;");
                flowLayoutPanel1.Controls.Clear();
                foreach (DataRow productfamily in ProductFamily.Rows)
                {
                    var label = new Label();
                    label.AutoSize = false;
                    label.Text = productfamily["Name"].ToString();
                    label.Tag = productfamily["ID"].ToString();

                    label.ForeColor = Color.FromArgb(117, 117, 117);
                    label.Size = new Size(225, 33);
                    label.Font = new Font("Roboto Medium", 12);
                    flowLayoutPanel1.Controls.Add(label);

                    label.MouseDown += Label_Click;
                    label.MouseEnter += Label_MouseEnter;
                    label.MouseLeave += Label_MouseLeave;
                }
                Datasheet.NewProductFamilyCreated = false;
            }
           

            //if (this.MdiChildren.Length > 0) this.ActivateMdiChild(this.MdiChildren[0]);
            if (Datasheet.IsCreated)
            {
                Datasheet.IsCreated = false;
                CloseAllForm();
                var frm = new frm_Editor();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            else if (Datasheet.IsEditing)
            {
                Datasheet.IsEditing = false;
                CloseAllForm();
                var frm = new frm_Editor();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
        }
        private void Label_Click(object sender, EventArgs e)
        {
            var label = sender as Label;
            CloseAllForm();
            var frm = new frm_Home(label.Tag.ToString()); // Product family id is stored in tag
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
        private void Label_MouseLeave(object sender, EventArgs e)
        {
            var label = sender as Label;
            label.ForeColor = Color.FromArgb(117, 117, 117); //gray
        }
        private void Label_MouseEnter(object sender, EventArgs e)
        {
            var label = sender as Label;
            label.ForeColor = Color.FromArgb(0, 101, 177); //blue
        }
    }
}
