using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyRentalManagementSystem.Model;
//using MySql.Data.MySqlClient;

namespace PropertyRentalManagementSystem.View_Model
{
    internal class CreateAccountView_Model
    {
        Connection connection = new Connection();
        public bool UsersLogin(UsersLogin usersLogin)
        {
            bool isSaved = false;

            using (MySqlConnection conn = new MySqlConnection(connection.ConnectionString))
            {
                conn.Open();
                using (MySqlCommand comm = new MySqlCommand("INSERT INTO tbl_user(username, password, email, contact_number, age, role) VALUES (@username, @password, @email, @contact_number, @age, @role)", conn))
                {
                    comm.Parameters.AddWithValue("@username", usersLogin.username);
                    comm.Parameters.AddWithValue("@password", usersLogin.password);
                    comm.Parameters.AddWithValue("@email", usersLogin.email);
                    comm.Parameters.AddWithValue("@contact_number", usersLogin.contact_number);
                    comm.Parameters.AddWithValue("@age", usersLogin.age);
                    comm.Parameters.AddWithValue("@role", usersLogin.role);
                    comm.ExecuteNonQuery();
                }
                using (MySqlCommand comm = new MySqlCommand("INSERT INTO tbl_user(username, password) VALUES (@username,@password)", conn))
                {
                    comm.Parameters.AddWithValue("@username", usersLogin.username);
                    comm.Parameters.AddWithValue("@password", usersLogin.password);
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        isSaved = true;
                    }
                    else
                    {
                        isSaved = false;
                    }
                }
            }
            return isSaved;
        }
    }
}
