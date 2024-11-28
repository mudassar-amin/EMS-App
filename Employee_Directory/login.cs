using System;
using System.Windows.Forms;

namespace Employee_Directory
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Optional event handler for label
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            // Optional event handler for username textbox
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
            // Optional event handler for password textbox
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string enteredUsername = username.Text.Trim();
            string enteredPassword = pass.Text.Trim();

            // Define hardcoded credentials
            string validUsername = "admin";
            string validPassword = "admin";

            if (enteredUsername == validUsername && enteredPassword == validPassword)
            {
                // Navigate to the Employee page
                Employees empPage = new Employees();
                empPage.Show();
                this.Hide(); // Hide the login form
            }
            else
            {
                // Show error message for incorrect credentials
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
