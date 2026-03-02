using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp19
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Get username and password from textboxes, remove extra spaces
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            //Check is username or password is empty
            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter username or password");
                return; //stop the login process/program
            }
            //Call db connetion string
            DBConnect db = new DBConnect();

            try
            {
                db.Open(); //Open database connection
                //SQL query to count matching username and password
                string query = "SELECT COUNT(*) FROM users WHERE username=@username AND password=@password";

                //Create MYSQL command
                MySql.Data.MySqlClient.MySqlCommand cmd = 
                    new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
                //Add parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                //Execute query and get results
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 1)
                {
                    //if I record found, Login Succesful
                    MessageBox.Show("Login Succesful!");
                    //Open Dashboard
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password!");
                }
            }
            catch (Exception ex)
            {
                //Show error message if something goes wrong
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                db.Close(); //Close database connection
            }
        }
    }
}
