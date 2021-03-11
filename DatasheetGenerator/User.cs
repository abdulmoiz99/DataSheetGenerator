using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DatasheetGenerator
{
    class User
    {
        public static int UserId { get; set; }
        public static string UserName { get; set; }

        public static bool Exist(string name)
        {
            string result = "0";
            result = SQL.ScalarQuery("SELECT EXISTS(SELECT * FROM Login WHERE name = '" + name + "' and active = '1');");
            if (result == "1") return true;
            else return false;
        }
        public static bool CreateUser(string name, string email, string username, string password)
        {
            return SQL.NonScalarQuery("Insert into Login (Name          ,email          ,username          ,password          ,Active)" +
                                              "   values ('" + name + "','" + email + "','" + username + "','" + password + "',1);");
        }
        public static bool IsEmailValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
