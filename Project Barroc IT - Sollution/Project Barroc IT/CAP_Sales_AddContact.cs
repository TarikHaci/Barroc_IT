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
    public partial class CAP_Sales_AddContact : Form
    {
        private CAP_Sales_SearchContact SearchContact;
        public CAP_Sales_AddContact()
        {
            InitializeComponent();
        }

        private void bttn_Back_Click(object sender, EventArgs e)
        {
            SearchContact = new CAP_Sales_SearchContact();
            this.Close();
            
        }
    }
}
