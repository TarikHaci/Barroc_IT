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
    public partial class LoginScreen : Form
    {
        private MainScreen Main;
        public int click;

        //SQL properties for use of the database
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt;
        private SqlCommandBuilder cb;
        private DatabaseHandler dbh;

        public LoginScreen()
        {           
            click = 0;
            InitializeComponent();
            dbh = new DatabaseHandler();
           
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bttnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;Initial Catalog=db_Users;User Id =" + tbUsername.Text +"Password="+ tbPassword.Text);
                //MessageBox.Show(username);

                //dbh.OpenConnectionToDB();
              
                //cmd = new SqlCommand("SELECT *From dbo.tbl_Users");
                //cmd.Connection = dbh.GetCon();
                //da = new SqlDataAdapter(cmd);
                //dt = new DataTable();
                //da.Fill(dt);

                

                //for (int i = 0; i >= 0; i++)
                //{
                //    MessageBox.Show("" + dt.Rows[i]["Username"].ToString());

                //    if (tbUsername.Text == dt.Rows[i]["Username"].ToString())
                //    {
                //        //Checking Username   
                //        MessageBox.Show("" + dt.Rows[i]["Username"].ToString());
                //    }
                //    else
                //    {
                //        MessageBox.Show("Wrong Username");
                //    }

                //    if (tbPassword.Text == dt.Rows[i]["Password"].ToString())
                //    {
                //        //checkin Password
                //        MessageBox.Show("You Logged In");
                //        break;
                //    }
                //    else
                //    {
                //        MessageBox.Show("Wrong Password");
                //    }
                //}
                //this.Hide();
                //Main.Show();

                
                string query = "SELECT * FROM TBL_USERS WHERE USERNAME = @USERNAME AND PASSWORD = @PASSWORD";
                string user = "";
                string pass = "";

                cmd = new SqlCommand(query, dbh.GetCon());

                cmd.Parameters.Add(new SqlParameter("@USERNAME", tbUsername.Text));
                cmd.Parameters.Add(new SqlParameter("@PASSWORD", tbPassword.Text));

                dbh.OpenConnectionToDB();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    

                    user = reader.GetString(1);
                    pass = reader.GetString(2);

                }

                if(user == tbUsername.Text && pass == tbPassword.Text)
                {
                    MessageBox.Show("Yes");
                }
                else
                {
                    MessageBox.Show("neuj");
                }

                
            }
            catch(Exception exp)
            {
                MessageBox.Show("Wrong", exp.Message.ToString());
            }

            finally
            {
                dbh.CloseConnectionToDB();
            }
        }

        private void BttnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"If you cannot login, please contact your administrator.
als u niet kunt inloggen, contacteer dan uw Administrator");
        }
    }
}
