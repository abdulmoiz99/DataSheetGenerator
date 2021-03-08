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
            //if (txt_HeaderName.Text == "Header Name") txt_HeaderName.Clear();     //Not Required (Suggestion)
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            HeaderController.Header.AddNewHeader();
            HeaderController.Header.SetHeaderText(txt_HeaderName.Text);
            this.Close();
        }

        private void txt_HeaderName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Add_Click(sender, e);
            }

            else if (e.KeyCode == Keys.Escape) 
            {
                this.Close();
            }
        }
    }
}
