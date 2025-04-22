using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyRentalManagementSystem.Model
{
    internal class UsersLogin
    {
        private int UserID;
        private string Username;
        private string Password;
        private string Email;
        private string Contact_Number;
        private string Age;
        private string Role;

        public int userID { get { return UserID; } set { UserID = value; } }

        public string username { get { return Username; } set { Username = value; } }

        public string password { get { return Password; } set { Password = value; } }

        public string email { get { return Email; } set { Email = value; } }

        public string contact_number { get { return Contact_Number; } set { Contact_Number = value; } }

        public string age { get { return Age; } set { Age = value; } }

        public string role { get { return Role; } set { Role = value; } }



        public UsersLogin(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }
        public UsersLogin(string Username, string Password, string Email, string Contact_number, string Age, string Role)
        {
            this.Username = Username;
            this.Password = Password;
            this.Email = Email;
            this.Contact_Number = Contact_number;
            this.Age = Age;
            this.Role = Role;
        }
        public UsersLogin(string Username, string Email, string Contact_number, string Age, string Role)
        {
            this.Username = Username;

            this.Email = Email;
            this.Contact_Number = Contact_number;
            this.Age = Age;
            this.Role = Role;
        }
        public UsersLogin(int UserID, string Username, string Email, string Contact_number, string Age, string Role)
        {
            this.userID = UserID;
            this.Username = Username;
            this.Email = Email;
            this.Contact_Number = Contact_number;
            this.Age = Age;
            this.Role = Role;
        }
    }
}
