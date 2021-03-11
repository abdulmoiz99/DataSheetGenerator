using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatasheetGenerator
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }
        private void label8_MouseEnter(object sender, EventArgs e)
        {
            lab_CreateUser.Font = new Font(lab_CreateUser.Font.Name, lab_CreateUser.Font.SizeInPoints, FontStyle.Underline);

        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            lab_CreateUser.Font = new Font(lab_CreateUser.Font.Name, lab_CreateUser.Font.SizeInPoints, FontStyle.Regular);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text == "admin" && txt_Passoword.Text == "admin")
            {
                this.Hide();
                var frm = new frm_Dashboard();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
               MessageBox.Show("Invalid username or password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void lab_CreateUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm = new frm_CreateUser    ();
            frm.ShowDialog();
            this.Close();
        }
    }
}
