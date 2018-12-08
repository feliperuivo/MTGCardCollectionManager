using System;
using System.Windows.Forms;


namespace MTGCollection
{
    public partial class LoginForm : Form
    {
        private MainForm _main = new MainForm();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(usernameTxtBox.Text) && !string.IsNullOrEmpty(passwordTxtBox.Text))
            {
                Login(usernameTxtBox.Text, passwordTxtBox.Text);
            }
            else
            {
                MessageBox.Show("Please enter a valid username and password");
            }
        }

        public bool Login(string user, string password)
        {
            //TODO usersDB
            if (user == "admin" && password == "admin")
            {
                MessageBox.Show(string.Format("Welcome {0} !", user));

                _main.Show();
                this.Hide();

                return true;
            }
            else
            {
                MessageBox.Show("Check your username and login and try again!");

                return false;
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
