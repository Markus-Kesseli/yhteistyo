using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_System
{
    /*
     * connection between app and MySQL database
     */
    class DBConnection
    {
        private MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hotellivarausjarjestelma");

        //return connection
        public MySqlConnection GetConnection()
        {
            return conn;
        }

        //open connection
        public void OpenConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        //close connection
        public void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}