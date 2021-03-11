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

        public static bool Exist()
        {
            return true;
        }
        public static bool CreateUser(string name, string email, string username, string password)
        {
            return true;
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
