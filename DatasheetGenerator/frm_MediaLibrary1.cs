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
    public partial class frm_MediaLibrary1 : Form
    {
        public frm_MediaLibrary1()
        {
            InitializeComponent();
        }

        private void xuiButton4_Click(object sender, EventArgs e)
        {
            dgv_Symbol.Rows.Add("New Symbol");
            dgv_Symbol.CurrentCell = dgv_Symbol.Rows[dgv_Symbol.RowCount - 1].Cells[0];
            dgv_Symbol.ClearSelection();
            dgv_Symbol.Rows[dgv_Symbol.RowCount - 1].Selected = true;
        }


        private void btn_ReplaceSymbol_Click(object sender, EventArgs e)
        {
            if (dgv_Symbol.CurrentRow != null) 
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Image symbol = Image.FromFile(dialog.FileName);
                    dgv_Symbol.CurrentRow.Cells[1].Value = symbol;
                    symbolBox.Image = symbol;
                }
            }
        }

        private void txt_Symbol_TextChanged(object sender, EventArgs e)
        {
            if (dgv_Symbol.CurrentRow != null) dgv_Symbol.CurrentCell.Value = txt_Symbol.Text;
        }

        private void btn_DeleteSymbol_Click(object sender, EventArgs e)
        {
            if (dgv_Symbol.CurrentRow != null) 
            {
                dgv_Symbol.Rows.Remove(dgv_Symbol.CurrentRow);
                if (dgv_Symbol.RowCount <= 0) 
                {
                    symbolBox.Image = symbolBox.InitialImage;
                    txt_Symbol.Clear();
                } 
            }
        }

        private void dgv_Symbol_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Symbol.Rows.Count > 0) 
            {
                DataGridViewRow row = dgv_Symbol.CurrentRow;

                txt_Symbol.Text = row.Cells[0].Value.ToString();

                if (row.Cells[1].Value != null)
                {
                    symbolBox.Image = (Image)row.Cells[1].Value;
                }
                else
                {
                    symbolBox.Image = symbolBox.InitialImage;
                }
            }

            txt_Symbol.Focus();
            txt_Symbol.SelectAll();
        }

        private void btn_AddImage_Click(object sender, EventArgs e)
        {
            dgv_Image.Rows.Add("New Image");
            dgv_Image.CurrentCell = dgv_Image.Rows[dgv_Image.RowCount - 1].Cells[0];
            dgv_Image.ClearSelection();
            dgv_Image.Rows[dgv_Image.RowCount - 1].Selected = true;
        }

        private void btn_ReplaceImage_Click(object sender, EventArgs e)
        {
            if (dgv_Image.CurrentRow != null)
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Image image = Image.FromFile(dialog.FileName);
                    dgv_Image.CurrentRow.Cells[1].Value = image;
                    imageBox.Image = image;
                }
            }
        }

        private void txt_Image_TextChanged(object sender, EventArgs e)
        {
            if (dgv_Image.CurrentRow != null) dgv_Image.CurrentCell.Value = txt_Image.Text;
        }

        private void btn_DeleteImage_Click(object sender, EventArgs e)
        {
            if (dgv_Image.CurrentRow != null)
            {
                dgv_Image.Rows.Remove(dgv_Image.CurrentRow);
                if (dgv_Image.RowCount <= 0)
                {
                    imageBox.Image = imageBox.InitialImage;
                    txt_Image.Clear();
                }
            }
        }

        private void dgv_Image_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Image.Rows.Count > 0)
            {
                DataGridViewRow row = dgv_Image.CurrentRow;

                txt_Image.Text = row.Cells[0].Value.ToString();

                if (row.Cells[1].Value != null)
                {
                    imageBox.Image = (Image)row.Cells[1].Value;
                }
                else
                {
                    imageBox.Image = imageBox.InitialImage;
                }
            }

            txt_Image.Focus();
            txt_Image.SelectAll();
        }

        private void frm_MediaLibrary_Load(object sender, EventArgs e)
        {
            //
        }

        private void btn_UpdateSymbol_Click(object sender, EventArgs e)
        {

        }

        private void btn_UpdateImage_Click(object sender, EventArgs e)
        {

        }
    }
}
