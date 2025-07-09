using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ToDoListForms
{
    public partial class Form1 : Form
    {
        string dbConnection = "Server=localhost;Database=todomanager;Uid=root;pwd=examplepassword"

        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string userName = userNameBox.Text;
            string password = passwordBox.Text;
            
            //debugging statement
            //MessageBox.Show("You entered " + userName + " and " + password);
        }
    }
}
