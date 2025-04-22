using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyRentalManagementSystem.Model
{
    internal class AdminUser
    {
        private int adminID;
        private string username;
        private string password;
        public string fullName;
        private string email;

        public int AdminID
        {
            get { return adminID; }
            set { adminID = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Fullname
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public AdminUser(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }
    }
}
