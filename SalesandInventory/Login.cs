using MySql.Data.MySqlClient;

namespace SalesandInventory

{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string mysqlconn = "server=127.0.0.1;user=root;database=salesinv;password=12345";
            try
            {
                MySqlConnection mysqlConnection = new MySqlConnection(mysqlconn);

                string username = userInput.Text.ToString();
                string password = passInput.Text.ToString();

                if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Enter Username or Password");
                    userInput.Clear();
                    passInput.Clear();
                }
                else
                {
                    mysqlConnection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM users", mysqlConnection);
                    MySqlDataReader reader = mySqlCommand.ExecuteReader();

                    bool isValidUser = false;

                    while (reader.Read())
                    {
                        if (username.Equals(reader.GetString("userName")) && password.Equals(reader.GetString("userPass")))
                        {
                            isValidUser = true;
                            string userType = reader.GetString("userType");

                            if (userType.Equals("admin", StringComparison.OrdinalIgnoreCase))
                            {
                                Dashboard adminForm = new Dashboard();
                                adminForm.Show();
                                this.Hide();
                            }
                            else if (userType.Equals("sales", StringComparison.OrdinalIgnoreCase))
                            {
                                MessageBox.Show("You are Sales Employee.");
                            }
                            else if (userType.Equals("inventory", StringComparison.OrdinalIgnoreCase))
                            {
                                MessageBox.Show("You are Inventory employee.");
                            }

                            break;
                        }
                    }


                    if (!isValidUser)
                    {
                        MessageBox.Show("Invalid Login Credentials");
                    }

                    mysqlConnection.Close();
                }
            }
            catch (Exception) { }


        }

        private void exitApp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}