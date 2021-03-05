using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatasheetGenerator.HeaderController
{
    class Header
    {
        public static bool NewHeaderAdded = false;
        public static string HeaderText;


        public static bool CheckNewHeader()
        {
            if (NewHeaderAdded)
            {
                return true;
            }
            return false;
        }
    }
}
