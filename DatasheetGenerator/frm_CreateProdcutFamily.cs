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
    public partial class frm_CreateProdcutFamily : Form
    {
        public frm_CreateProdcutFamily()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text == "")
            {
                MessageBox.Show("Please enter product family name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SQL.NonScalarQuery("Insert into ProductFamily(Name)" +
                                                    " values ('" + txt_Name.Text + "');");
                txt_Name.Clear();
                Datasheet.NewProductFamilyCreated = true;
                MessageBox.Show("Product Family Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm = new frm_CreateDatasheet();
            frm.ShowDialog();
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm = new frm_CreateDatasheet();
            frm.ShowDialog();
            this.Close();
        }
    }
}
