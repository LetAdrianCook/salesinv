using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SalesandInventory.UserControls
{
    public partial class CreateUserWindow : UserControl
    {

        private MySqlConnection mysqlConnection;
        public CreateUserWindow()
        {
            InitializeComponent();
            BindData();
            string mysqlconn = "server=127.0.0.1;user=root;database=salesinv;password=12345";
            mysqlConnection = new MySqlConnection(mysqlconn);
        }





        private void createUserbtn_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = birthDate.Value;
            string formattedDate = selectedDate.ToString("yyyy-MM-dd");




            string userType = string.Empty;

            if (salesType.Checked)
            {
                userType = "Sales";
            }
            else if (invType.Checked)
            {
                userType = "Inventory";
            }

            string gender = string.Empty;

            if (radioMale.Checked)
            {
                gender = "Male";
            }
            else if (radioFemale.Checked)
            {
                gender = "Female";
            }


            mysqlConnection.Open();
            MySqlCommand createUser = new MySqlCommand("INSERT INTO users (userName, userPass, userType, firstName, middleName, lastName, birthDate, gender, dateCreated) " +
                "VALUES (@userName, @userPass, @userType, @firstName, @middleName, @lastName, @birthDate, @gender, @dateCreated)", mysqlConnection);


            createUser.Parameters.AddWithValue("@userName", creUsername.Text);
            createUser.Parameters.AddWithValue("@userPass", crePassword.Text);
            createUser.Parameters.AddWithValue("@userType", userType);
            createUser.Parameters.AddWithValue("@firstName", creFirstname.Text);
            createUser.Parameters.AddWithValue("@middleName", creMidname.Text);
            createUser.Parameters.AddWithValue("@lastName", creLastname.Text);
            createUser.Parameters.AddWithValue("@birthDate", formattedDate);
            createUser.Parameters.AddWithValue("@gender", gender);
            createUser.Parameters.AddWithValue("@dateCreated", DateTime.Now); // Use DateTime.Now for current date and time


            createUser.ExecuteNonQuery();

            MessageBox.Show("User Successfully Created");
            creUsername.Clear();
            crePassword.Clear();
            creFirstname.Clear();
            creMidname.Clear();
            creLastname.Clear();
            radioMale.Checked = false;
            radioFemale.Checked = false;
            salesType.Checked = false;
            invType.Checked = false;
            birthDate.Value = DateTime.Now;
            BindData();
            mysqlConnection.Close();

        }

        void BindData()
        {
            try
            {
                MySqlCommand view = new MySqlCommand("select * from users", mysqlConnection);
                MySqlDataAdapter userTable = new MySqlDataAdapter(view);
                DataTable dt = new DataTable();
                userTable.Fill(dt);
                userGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
               // MessageBox.Show("Error retrieving data: " + ex.Message);
            }
        }

        private void CreateUserWindow_Load(object sender, EventArgs e)
        {
            BindData();
        }
    }

}
