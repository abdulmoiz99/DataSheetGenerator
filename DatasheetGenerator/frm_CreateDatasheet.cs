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
    public partial class frm_CreateDatasheet : Form
    {
        public frm_CreateDatasheet()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Datasheet.IsCreated = true;
            this.Close();
        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_CreateDatasheet_Load(object sender, EventArgs e)
        {
            Main.fillComboWithoutCondition(cmb_ProductFamily, "ProductFamily", "Name", "ID");
        }
    }
}
