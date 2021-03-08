using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatasheetGenerator
{
    public class Order
    {
        public static void ReOrder(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows) 
            {
                row.Cells[1].Value = row.Index + 1;
            }
        }
    }
}
