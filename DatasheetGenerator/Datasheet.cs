using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatasheetGenerator
{
    class Datasheet
    {
        public static bool IsCreated = false;
        public static bool IsEditing = false;
        public static string Id { get; set; }
        public static string ProductFamilly { get; set; }
        public static string Name { get; set; }

        public static DataTable GetDataTable(string Query)
        {
            if (SQL.con.State == ConnectionState.Closed) SQL.con.Open();
            DataTable datasheets = new DataTable();
            MySqlCommand command = new MySqlCommand(Query, SQL.con);
            var adapter = new MySqlDataAdapter(command);
            adapter.Fill(datasheets);
            return datasheets;
        }
        public static bool Exist(string datasheetName)
        {
            string result = "0";
            result = SQL.ScalarQuery("SELECT EXISTS(SELECT * FROM Datasheet WHERE name = '" + datasheetName + "' and active = 1)");
            if (result == "1")
            {
                return true;
            }
            else return false;
        }
    }
}
