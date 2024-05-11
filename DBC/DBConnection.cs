using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace OOP_project.DBC
{
    public class DBConnection
    {
        public static string connecDB = "Data Source=LAPTOP-TEK92DJC;Initial Catalog=oop_project;Integrated Security=True";

        public SqlConnection conn = new SqlConnection();
        public DBConnection()
        {
            conn = new SqlConnection(connecDB);
        }

        public void Open()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void Close()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public SqlConnection GetConnection()
        {
            Open();
            return conn;
        }

    }
}