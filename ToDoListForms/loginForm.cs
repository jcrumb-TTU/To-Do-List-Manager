using System;
using System.Windows.Forms;
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
            else
            {
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();

                string query = "SELECT * FROM tblUsers WHERE userName ='" + userName + "' AND password = '" + password + "'";

                MySqlCommand cmd = new MySqlCommand(query, con);

                int i = cmd.ExecuteNonQuery();

                
            }
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameBox.Text;
            string lastName = lastNameBox.Text;
            string userName = userNameRegBox.Text;
            string password = passwordRegBox.Text;

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please complete all fields to register.");
            }
            else
            {
                //Creates a unique ID to associate with the user and converts guid
                //to 32 digits
                Guid guid = Guid.NewGuid();
                string userGuid = guid.ToString("N");

                //Debugging statement
                //MessageBox.Show(userGuid);

                MySqlConnection con = new MySqlConnection(conString);

                con.Open();

                string query = "INSERT INTO tblUsers VALUES('" + userGuid + "','" + firstName + "','" + lastName + "','" + userName + "','" + password + "')";

                MySqlCommand cmd = new MySqlCommand(query, con);

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
        }
    }
}
