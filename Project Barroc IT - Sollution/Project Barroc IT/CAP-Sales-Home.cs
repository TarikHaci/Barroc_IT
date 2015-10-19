using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Barroc_IT
{
    public partial class MainScreen : Form
    {
        LoginScreen Login = new LoginScreen();
        private CAP_Sales_SearchContact SearchContact;
        CAP_Sales_AddContact AddContact = new CAP_Sales_AddContact();
        public int clickL;
        public MainScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("U bent uitgelogt");
        }

        private void bttn_AddContact_Click(object sender, EventArgs e)
        {
            //Add contact
            this.Hide();
            AddContact.Show();
        }

        private void bttn_SearchContact_Click(object sender, EventArgs e)
        {
SearchContact = new CAP_Sales_SearchContact();
            this.Hide();
            SearchContact.Show();
        }
    }
}
