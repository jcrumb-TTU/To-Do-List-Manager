using System;
using System.Data;
using System.Security.Cryptography;
using Isopoh.Cryptography.Argon2;
using System.Text;
using static System.DateTime;
using System.Windows.Forms;
//using BCrypt.Net;
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

            //Checks if fields are empty
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your username and password into the fields.");
            }
            //Initiates connection and validates user
            
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();

            string query = "SELECT username FROM tblUsers WHERE userName = @username";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", userName);

            MySqlDataAdapter daAll = new MySqlDataAdapter(cmd);
            DataSet dsAll = new DataSet();
            daAll.Fill(dsAll);
            int totalRecords = dsAll.Tables[0].Rows.Count;

            if (totalRecords == 1)
            {
                string query2 = "SELECT passwordHash FROM tblUsers WHERE username = @username";

                MySqlCommand cmd2 = new MySqlCommand(query2, con);
                cmd2.Parameters.AddWithValue("@username", userName);

                MySqlDataReader reader = cmd2.ExecuteReader();

                if (reader.Read())
                {
                    string storedHash = reader.GetString("passwordHash");

                    if (Argon2.Verify(storedHash, password))
                    {
                        MessageBox.Show("Login Successful");

                        reader.Close();

                        userNameBox.Text = string.Empty;
                        passwordBox.Text = string.Empty;

                        string sessionGuid = Guid.NewGuid().ToString("N");

                        string query3 = "INSERT INTO tblSession (sessionID, Timestamp, userName) VALUES (@sessionGuid, @loginTime, @userName)";

                        MySqlCommand cmd3 = new MySqlCommand(query3, con);
                        cmd3.Parameters.AddWithValue("@sessionGuid", sessionGuid);
                        cmd3.Parameters.AddWithValue("@loginTime", DateTime.Now);
                        cmd3.Parameters.AddWithValue("@userName", userName);

                        cmd3.ExecuteNonQuery();

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

            } else
            {
                MessageBox.Show("User does not exist");
            }
        }
        //This function allows the user to register a new account through the registration form
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

                string query1 = "SELECT userName FROM tblUsers WHERE userName = @username";

                MySqlConnection con = new MySqlConnection(conString);
                MySqlCommand cmd1 = new MySqlCommand(query1, con);
                cmd1.Parameters.AddWithValue("@username", userName);

                MySqlDataAdapter daAll = new MySqlDataAdapter(cmd1);
                DataSet dsAll = new DataSet();
                daAll.Fill(dsAll);
                int totalRecords = dsAll.Tables[0].Rows.Count;

                if (totalRecords == 1)
                {
                    MessageBox.Show("Username already exists. Please choose a different username.");
                    return;
                }

                //Creates a unique ID to associate with the user and converts guid
                //to 32 digits
                Guid guid = Guid.NewGuid();
                string userGuid = guid.ToString("N");

                string hashedPassword = Argon2.Hash(password);


                con.Open();

                string query2 = "INSERT INTO tblUsers VALUES(@userGuid, @firstName, @lastName, @userName, @passwordhash)";

                MySqlCommand cmd2 = new MySqlCommand(query2, con);
                cmd2.Parameters.AddWithValue("@userGuid", userGuid);
                cmd2.Parameters.AddWithValue("@firstName", firstName);
                cmd2.Parameters.AddWithValue("@lastName", lastName);
                cmd2.Parameters.AddWithValue("@userName", userName);
                cmd2.Parameters.AddWithValue("@passwordhash", hashedPassword);
                int i = cmd2.ExecuteNonQuery();
                //Validates if registration was successful
                if (i > -1)
                {
                    MessageBox.Show("Successful Registration.");
                }
                else
                {
                    MessageBox.Show("Something went wrong. Please try again.");
                }

                con.Close();
            }
        }
    }
}
