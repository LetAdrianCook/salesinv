using SalesandInventory.forms;
using SalesandInventory.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesandInventory
{
    public partial class Dashboard : Form
    {
        NavigationControl navigationControl;
        NavigationButtons navigationButtons;

        Color btndDefaultColor = Color.FromKnownColor(KnownColor.LightSteelBlue);
        Color btndSelectedColor = Color.FromKnownColor(KnownColor.Control);
        public Dashboard()
        {
            InitializeComponent();
            InitializeNavigationControl();
            InitializeNavigationButton();
        }

        private void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>()
            { new Inventory(), new Sales(), new CreateUserWindow() };

            navigationControl = new NavigationControl(userControls, dashPanel);
            navigationControl.Display(0);

        }

        private void InitializeNavigationButton()
        {
            List<Button> buttons = new List<Button>()
            { inventoryBtn, salesBtn, createBtn};

            navigationButtons = new NavigationButtons(buttons, btndDefaultColor, btndSelectedColor);
            // navigationButtons.Highlight(inventoryBtn);
        }



        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0);
            navigationButtons.Highlight(inventoryBtn);
        }

        private void salesBtn_Click(object sender, EventArgs e)
        {
            navigationControl.Display(1);
            navigationButtons.Highlight(salesBtn);

        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            navigationControl.Display(2);
            navigationButtons.Highlight(createBtn);

        }

        private void navbarTitle_Click(object sender, EventArgs e)
        {

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged Out");
            Login login = new Login();
            login.Show();
            this.Hide();

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application Exited");
            Application.Exit();
        }
    }
}

