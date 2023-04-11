using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace HotelManagementSystem
{
    internal class DBConnect
    {
        private MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306; username=root; password=;database=phpmyadmin");
        //Luodaan funktio yhteyttä varten
        public MySqlConnection GetConnection()
        {
            return connection;
        }

        //Luodaan funktio yhteyden avaamista varten (System.Data -kirjasto)
        public void OpenCon()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        //Luodaan funktio yhteyden sulkemista varten
        public void CloseCon()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
