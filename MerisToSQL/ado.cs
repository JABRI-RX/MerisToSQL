using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MerisToSQL
{

    public class ADO
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
        public DataTable dt = new DataTable();
        public DataTable dt2 = new DataTable();
        public DataTable dt3 = new DataTable();
        public SqlDataAdapter dap = new SqlDataAdapter();
        public DataSet ds = new DataSet();
        public DataSet ds2 = new DataSet();
        public DataRow ligne;
        public SqlCommandBuilder bc;

        public void connecter()
        {
            if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
            {
                con.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
                try
                {
                    con.Open();
                }
                catch
                {
                    MessageBox.Show("Start SQL Service!!!");
                }
            }
        }
        public void deconnecter()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        
    }
}