using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace DatasheetGenerator
{
    class SQL
    {
        // private static String userName = String.Empty;
        // private static SqlConnection con = new SqlConnection(@"Data Source=" + DataSource + ";Initial Catalog=MobileShop;Integrated Security=True;Pooling=False");// ReadCS().ToString()); 
        //public static MySqlConnection con = new MySqlConnection(@"Data Source=.\Abdul; AttachDbFilename=" + Application.StartupPath + "\\KonvekaSelectionProgram.mdf; Integrated Security=True; Connect Timeout=10;User Instance=True");

        // public static MySqlConnection con = new MySqlConnection(@"Data Source=.\Abdul; AttachDbFilename=" + Application.StartupPath + "\\KonvekaSelectionProgram.mdf; Integrated Security=True; Connect Timeout=10;User Instance=True");
        public static MySqlConnection con = new MySqlConnection(@"server=sql6.freemysqlhosting.net;port=3306;user id=sql6397749; password=CU6wE3Q1ve; database=sql6397749;");

        //public static String DataSource = ReadCS();
        //  private static readonly SqlConnection con = new SqlConnection(DataSource);// ReadCS().ToString()); 
        public static bool IsServerConnected(string connectionString)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (MySqlException)
                {
                    return false;
                }
            }
        }
        public static MySqlConnection Con
        {
            get
            { return con; }
        }
        public static string ReadCS()
        {
            var lines = "";
            string Path = Application.StartupPath + @"\SQL.dat";
            // string Path = @"C:\Users\moiza\source\repos\SchoolManagementSoftware\SchoolManagementSoftware\bin\Debug\Conn\SQL.txt";
            if (!File.Exists(Path))
            {
                MessageBox.Show("Unable To Find Connection File ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (var streamReader = new StreamReader(Path))
                {
                    try
                    {
                        lines = streamReader.ReadLine();
                    }
                    catch (FileNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message, "SQL");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "SQl");
                    }
                }
            }

            return lines;
        }
        public static string ScalarQuery(string Query)
        {
            String Result = string.Empty;
            try
            {

                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
                Con.Open();
                var cmd = new MySqlCommand(Query, Con);
                Result = cmd.ExecuteScalar().ToString();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("SQL " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Scalar Query" + ex.Message);
            }
            finally
            {
                Con.Close();
            }
            return Result;
        }

       

        public static void NonScalarQuery(String Query)
        {
            try
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
                Con.Open();
                var cmd = new MySqlCommand(Query, Con);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("SQL " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL" + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
        public static void NonScalarQueryTransaction(String Query, MySqlTransaction ST)
        {
            try
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
                Con.Open();
                MySqlCommand cmd = new MySqlCommand(Query, Con, ST);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("SQL " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL" + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
    }
}
