using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotelManagementSystem
{
    public partial class Form1 : Form
    {
        DBConnect connect = new DBConnect();
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (username.Text.Trim().Equals("") || password.Text == "")
            {
                MessageBox.Show("Anna käyttäjätunnus ja salasana!", "Puuttuvat tiedot", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            { 
                DataTable table = new DataTable();
                MySqlDataAdapter adapter= new MySqlDataAdapter();
 
                String selectquery = "SELECT * FROM `user` WHERE `username` = @usn AND `password` = @pass";
                MySqlCommand command = new MySqlCommand(selectquery, connect.GetConnection());

                command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username.Text;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password.Text;
                adapter.SelectCommand= command;
                adapter.Fill(table);



                if(table.Rows.Count > 0)
                {
                this.Hide();
                MainForm mainform = new MainForm();
                mainform.Show();
                }
                else
                {
                    MessageBox.Show("Virheellinen käyttäjätunnus tai salasana!", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
                
                

                
            }
        }
    }
}
