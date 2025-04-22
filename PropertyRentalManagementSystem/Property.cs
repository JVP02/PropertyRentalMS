using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PropertyRentalManagementSystem
{
    public partial class Property : Form
    {
        public Property()
        {
            InitializeComponent();
            string mysqlCon = "server=127.0.0.1; user=root; database=db_prms; password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

            try
            {
                mySqlConnection.Open();
                MessageBox.Show("Connection Success");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Property_Load(object sender, EventArgs e)
        {

        }

        private void btn_idsearch_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"server=127.0.0.1; user=root; database=db_prms; password=");
            SqlCommand check_User_Name = new SqlCommand("SELECT User_ID FROM tbl_user WHERE (User_ID = @User_ID)", con);
            check_User_Name.Parameters.AddWithValue("@User_ID", txt_userid.Text);
            con.Open();
            int UserExist = (int)check_User_Name.ExecuteScalar();


            if (UserExist > 0)
            {
                var connetionString = @"server=127.0.0.1; user=root; database=db_prms; password=";
                var sql = "UPDATE tbl_user SET firstname = @firstname, lastname = @lastname, age = @age, occupation = @occupation, sex = @sex WHERE (User_ID = @User_ID)";
                try
                {
                    using (var connection = new SqlConnection(connetionString))
                    {
                        using (var command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.Add("@User_ID", SqlDbType.Int).Value = txt_userid.Text;
                            command.Parameters.Add("@firstname", SqlDbType.NVarChar).Value = txt_fname.Text;
                            command.Parameters.Add("@lastname", SqlDbType.NVarChar).Value = txt_lname.Text;
                            command.Parameters.Add("@sex", SqlDbType.NVarChar).Value = txt_sex.Text;
                            command.Parameters.Add("@age", SqlDbType.NVarChar).Value = txt_age.Text;
                            command.Parameters.Add("@occupation", SqlDbType.NVarChar).Value = txt_useroccupation.Text;

                            //command.Parameters.Add("@lastname", SqlDbType.NVarChar).Value = purposeOfVisit_CMBox.SelectedItem;
                            //command.Parameters.Add("@Duration", SqlDbType.Date).Value = duration_dateTimePicker1.Value.Date;
                            //command.Parameters.Add("@Disclaimer", SqlDbType.NVarChar).Value = disclaimer_CHKBox.Checked;
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("MySQL Error: " + ex.Message);
                }
            }
        }
    }
}
