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

        private void loginButton_Click(object sender, EventArgs e)
        {
            string userName = userNameBox.Text;
            string password = passwordBox.Text;

            //debugging statement
            //MessageBox.Show("You entered " + userName + " and " + password);
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

            }
        }
    }
}
