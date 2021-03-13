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
    public partial class frm_MediaLibrary : Form
    {
        public frm_MediaLibrary()
        {
            InitializeComponent();
        }

        private void xuiButton3_Click(object sender, EventArgs e)
        {
            btn_Delete.Visible = true;
        }

        private void frm_MediaLibrary_Load(object sender, EventArgs e)
        {
            Main.fillDgv(dgv_Media, "select * from MediaLibrary");
        }
    }
}
