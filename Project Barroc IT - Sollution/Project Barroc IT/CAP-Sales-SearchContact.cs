using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//indicates that we are using a SQL database
using System.Data.SqlClient;

namespace Project_Barroc_IT
{
    public partial class CAP_Sales_SearchContact : Form
    {
        MainScreen Main = new MainScreen();
        private CAP_Sales_AddContact AddContact;

        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt;

        public CAP_Sales_SearchContact()
        {
            InitializeComponent();
        }

        public void ConnectDB()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\keese_000\Documents\Project de  Gokkers\Project Fifa\Project Fifa\ProjectFifa.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            cmd = new SqlCommand("SELECT *From tbl_Users");
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            AddContact = new CAP_Sales_AddContact();
            AddContact.Show();
        }

        private void bttn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main.Show();
        }
    }
}
