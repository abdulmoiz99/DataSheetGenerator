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
        public static DataTable GetDataTable(string Query)
        {
            if (SQL.con.State == ConnectionState.Closed)
            {
                SQL.con.Open();
            }
            DataTable datasheets = new DataTable();
            MySqlCommand command = new MySqlCommand(Query, SQL.con);
            var adapter = new MySqlDataAdapter(command);
            adapter.Fill(datasheets);
            return datasheets;
        }
    }
}
