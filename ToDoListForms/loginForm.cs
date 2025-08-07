using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using static System.DateTime;
using System.Windows.Forms;
using BCrypt.Net;
using MySql.Data.MySqlClient;

namespace ToDoListForms
{
    public partial class loginForm : Form
    {

        public loginForm()
        {
            InitializeComponent();
        }

        //string connection, source of format from https://learn.microsoft.com/en-us/windows/apps/develop/data-access/mysql-database
        const string conString = "Server=localhost;Database=todomanager;Uid=root;pwd=examplepassword;";

        //This function allows the user to login to the system through the login form
        private void loginButton_Click(object sender, EventArgs e)
        {
            string userName = userNameBox.Text;
            string password = passwordBox.Text;

            passwordBox.PasswordChar = '*';


            //Checks if fields are empty
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your username and password into the fields.");
            }
            //Initiates connection and validates user
            else
            {
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();

                string query = "SELECT passwordHash FROM tblUsers WHERE userName = @username";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", userName);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string storedHash = reader.GetString("passwordHash");

                    if (BCrypt.Net.BCrypt.Verify(password, storedHash))
                    {
                        MessageBox.Show("Login Successful");

                        userNameBox.Text = string.Empty;
                        passwordBox.Text = string.Empty;

                        string sessionGuid = Guid.NewGuid().ToString("N");

                        string query2 = "INSERT INTO tblSessions (sessionGuid, loginTime, userName) VALUES (@sessionGuid, @loginTime, @userName)";

                        MySqlCommand cmd2 = new MySqlCommand(query2, con);
                        cmd2.Parameters.AddWithValue("@sessionGuid", sessionGuid);
                        cmd2.Parameters.AddWithValue("@loginTime", DateTime.Now);
                        cmd2.Parameters.AddWithValue("@userName", userName);

                        cmd2.ExecuteNonQuery();

                        mainForm newForm = new mainForm();

                        newForm.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login Failed: Username or Password Incorrect.");
                    }
                }
                else
                {
                    MessageBox.Show("Login Failed: Username or Password not found.");
                }

            }
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameBox.Text;
            string lastName = lastNameBox.Text;
            string userName = userNameRegBox.Text;
            string password = passwordRegBox.Text;

            passwordRegBox.UseSystemPasswordChar = true;

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please complete all fields to register.");
            }
            else
            {

                MySqlConnection con = new MySqlConnection(conString);

                string query1 = "SELECT * FROM tblUsers WHERE userName = @username";

                MySqlCommand cmd1 = new MySqlCommand(query1, con);
                cmd1.Parameters.AddWithValue("@username", userName);

                MySqlDataReader reader = cmd1.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Username already exists. Please choose a different username.");
                    return;
                }
                else
                {
                    reader.Close();

                    //Creates a unique ID to associate with the user and converts guid
                    //to 32 digits
                    Guid guid = Guid.NewGuid();
                    string userGuid = guid.ToString("N");

                    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);


                    con.Open();

                    string query2 = "INSERT INTO tblUsers VALUES(@userGuid, @firstName, @lastName, @userName, @passwordhash)";

                    MySqlCommand cmd = new MySqlCommand(query2, con);
                    cmd.Parameters.AddWithValue("@userGuid", userGuid);
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@userName", userName);
                    cmd.Parameters.AddWithValue("@passwordhash", hashedPassword);
                    int i = cmd.ExecuteNonQuery();
                    //Validates if registration was successful
                    if (i > -1)
                    {
                        MessageBox.Show("Successful Registration.");
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong. Please try again.");
                    }
                }
                con.Close();
            }
        }
    }
}
