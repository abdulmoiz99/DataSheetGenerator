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

        private void btn_Create_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (txt_Name.Text == "")
            {
                MessageBox.Show("Please enter datasheet name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cmb_ProductFamily.SelectedIndex < 0)
            {
                MessageBox.Show("Please select product family", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Datasheet.Exist(txt_Name.Text, cmb_ProductFamily.SelectedValue.ToString()))
            {
                MessageBox.Show("Datasheet With Same Name Already Exisit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Cursor.Current = Cursors.Default;
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                if (SQL.NonScalarQuery("Insert into Datasheet (Name                   ,PF_ID                                  ,Flag ,Type  ,DateCreated    ,DateModified    ,Active) " +
                                                  "values ('" + txt_Name.Text + "'," + cmb_ProductFamily.SelectedValue + ",0    ,1         ,'" + date + "' ,'" + date + "'  ,1);"))
                {
                    Datasheet.ProductFamilly = cmb_ProductFamily.Text;
                    Datasheet.ProductFamillyID = Convert.ToInt32(cmb_ProductFamily.SelectedValue.ToString());
                    Datasheet.Name = txt_Name.Text;
                    Datasheet.IsCreated = true;
                    Datasheet.IsEditing = false;
                    Datasheet.Id = Datasheet.GetLatestId();
                    Datasheet.NewDataSheet = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Unable To Create New Datasheet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btn_AddNewProductFamily_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm = new frm_CreateProdcutFamily();
            frm.ShowDialog();
            this.Close();
        }
    }
}
