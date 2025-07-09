using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ToDoListForms
{
    public partial class Form1 : Form
    {
        //string connection, source of format from https://learn.microsoft.com/en-us/windows/apps/develop/data-access/mysql-database
        const string dbConnection = "Server=localhost;Database=todomanager;Uid=root;pwd=examplepassword";

        string userName;
        string password;
        string firstName;
        string lastName;

        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            userName = userNameBox.Text;
            password = passwordBox.Text;

            //debugging statement
            //MessageBox.Show("You entered " + userName + " and " + password);
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            firstName = firstNameBox.Text;
            lastName = lastNameBox.Text;
            userName = userNameRegBox.Text;
            password = passwordRegBox.Text;
        }
    }
}
