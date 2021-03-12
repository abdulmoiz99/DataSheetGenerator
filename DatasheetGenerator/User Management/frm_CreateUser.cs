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
    public partial class frm_CreateUser : Form
    {
        public frm_CreateUser()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm = new frm_Login();
            frm.ShowDialog();
            this.Close();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            CreateUser();
        }

        private void CreateUser()
        {
            if (string.IsNullOrEmpty(txt_Name.Text)) MessageBox.Show("Please Enter First and Last Name ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrEmpty(txt_Email.Text)) MessageBox.Show("Please Enter Email Address ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrEmpty(txt_Username.Text)) MessageBox.Show("Please Enter Username ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrEmpty(txt_Password.Text)) MessageBox.Show("Please Enter Password ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrEmpty(txt_ConfirmPassword.Text)) MessageBox.Show("Please Enter Confirm Password ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (User.Exist(txt_Username.Text)) MessageBox.Show("Username Alreadt Exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!User.IsEmailValid(txt_Email.Text)) MessageBox.Show("Please Enter Valid Email Address ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txt_Password.Text != txt_ConfirmPassword.Text) MessageBox.Show("Password Does not Match", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (User.CreateUser(txt_Name.Text, txt_Email.Text, txt_Username.Text, txt_Password.Text)) MessageBox.Show("User Created Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Unable to Create New User!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
