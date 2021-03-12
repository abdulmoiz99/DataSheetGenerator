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
            frm.Show();
            //frm.MdiParent = this;
            //frm.Dock = DockStyle.Fill;
            //frm.Show();
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
            if (this.MdiChildren.Length > 0) this.ActivateMdiChild(this.MdiChildren[0]);
            if (Datasheet.IsCreated)
            {
                CloseAllForm();
                var frm = new frm_Editor();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
        }

        private void btn_LatestDatasheet_Click(object sender, EventArgs e)
        {
            CloseAllForm();
            var frm = new frm_Home(); // latest datasheet

            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}
