using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatasheetGenerator.HeaderController
{
    class Header
    {
        static bool NewHeaderAdded = false;
        static string HeaderText;


        public static bool CheckNewHeader()
        {
            if (NewHeaderAdded)
            {
                return true;
            }
            return false;
        }
        public static string GetHeaderText()
        {
            return HeaderText;
        }
        public static string GetHeaderText(string ID)
        {
            return SQL.ScalarQuery("select Name from Header where ID = " + ID + "");
        }
        public static void SetHeaderText(string headerText) => HeaderText = headerText;

        public static void AddNewHeader() => NewHeaderAdded = true;
        public static void DisableNewHeader() => NewHeaderAdded = false;
    }
}
