using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatasheetGenerator
{
    public class Header
    {
        public static string ProductFamily;
        public static int DatasheetID = 2;

        public static void ReOrder(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows) 
            {
                row.Cells[1].Value = row.Index + 1;
            }
        }
        public static Dictionary<string, Dictionary<string, string>> GetHeaders(FlowLayoutPanel panel) 
        {
            Dictionary<string, Dictionary<string, string>> headers = new Dictionary<string, Dictionary<string, string>>();

            foreach (Control control in panel.Controls)
            {
                if (control is DataGridView)
                {
                    var dgv = control as DataGridView;

                    Dictionary<string, string> subHeader = new Dictionary<string, string>();

                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (row.Cells[0].Value != null && row.Cells[1].Value != null) subHeader.Add(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString());
                    }

                    headers.Add(dgv.Columns[0].HeaderText, subHeader);
                }
            }
            return headers;
        }
    }
}
