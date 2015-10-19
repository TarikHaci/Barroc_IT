using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Project_Barroc_IT
{
    class DatabaseHandler
    {
        private SqlConnection con;

        public DatabaseHandler()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;Initial Catalog=db_Users;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");

        }

        public void TestConnection()
        {
            bool open = false;

            try
            {
                con.Open();
                MessageBox.Show("The connection Works");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    open = true;
                }
                con.Close();
            }

            if (!open)
            {
                Application.Exit();
            }
        }

        public void OpenConnectionToDB()
        {
            con.Open();
        }

        public void CloseConnectionToDB()
        {
            con.Close();
        }

        public System.Data.DataTable FillDT(string query)
        {
            TestConnection();
            OpenConnectionToDB();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, GetCon());
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);

            CloseConnectionToDB();

            return dt;
        }

        public SqlConnection GetCon()
        {
            return con;
        }
    }
}
