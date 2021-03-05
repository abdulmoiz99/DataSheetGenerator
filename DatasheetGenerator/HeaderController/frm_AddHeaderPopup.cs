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
    public partial class frm_AddHeaderPopup : Form
    {
        public frm_AddHeaderPopup()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_HeaderName_Click(object sender, EventArgs e)
        {
            if (txt_HeaderName.Text == "Header Name") txt_HeaderName.Clear();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            HeaderController.Header.NewHeaderAdded = true;
            HeaderController.Header.HeaderText  = txt_HeaderName.Text;
            this.Close();
        }
    }
}
