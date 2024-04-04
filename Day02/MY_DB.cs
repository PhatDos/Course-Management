using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Day02
{
    class MY_DB
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\TANPHAT\source\repos\4-WINDOWN\Day03\Day03\QLSVDB.MDF;Integrated Security=True;Connect Timeout=30");

        // get the connection
        public SqlConnection getConnection()
        {
            {
                return con;
            }
        }

        // open the connection
        public void openConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

        }


        // close the connection
        public void closeConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

        }

    }
}

