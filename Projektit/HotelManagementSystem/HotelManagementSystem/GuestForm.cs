using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HotelManagementSystem
{
    public partial class GuestForm : Form
    {
        Guest guest = new Guest();
        public GuestForm()
        {
            InitializeComponent();
        }

        private void CleanAS_Click(object sender, EventArgs e)
        {
            idAS.Clear();
            enimiAS.Clear();
            snimiAS.Clear();
            paikkakuntaAS.Clear();
            puhAS.Clear();
        }

        private void saveAS_Click(object sender, EventArgs e)
        {
            if (idAS.Text == "" || enimiAS.Text == "" || puhAS.Text == "")
            {
                MessageBox.Show("Täytä pakollisen kentät!", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string id = idAS.Text;
                    string fname = enimiAS.Text;
                    string lname = snimiAS.Text;
                    string phone = puhAS.Text;
                    string city = paikkakuntaAS.Text;

                    Boolean insertGuest = guest.insertGuest(id, fname, lname, phone, city);
                    if (insertGuest)
                    {
                        MessageBox.Show("Asiakas lisätty onnistuneesti", "Asiakas tallennettu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getTable();
                    }
                    else
                    {
                        MessageBox.Show("Asiakasta ei pystytty lisäämään!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void GuestForm_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void getTable()
        {
            asiakkaatDG.DataSource = guest.getGuest();
        }

        private void updateAS_Click(object sender, EventArgs e)
        {
            if (idAS.Text == "" || enimiAS.Text == "" || puhAS.Text == "")
            {
                MessageBox.Show("Täytä pakollisen kentät!", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string id = idAS.Text;
                    string fname = enimiAS.Text;
                    string lname = snimiAS.Text;
                    string phone = puhAS.Text;
                    string city = paikkakuntaAS.Text;

                    Boolean editGuest = guest.editGuest(id, fname, lname, phone, city);
                    if (editGuest)
                    {
                        MessageBox.Show("Asiakas päivitetty onnistuneesti", "Asiakas päivitetty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getTable();
                    }
                    else
                    {
                        MessageBox.Show("Asiakasta ei pystytty päivittämään!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void asiakkaatDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idAS.Text = asiakkaatDG.CurrentRow.Cells[0].Value.ToString();
            enimiAS.Text = asiakkaatDG.CurrentRow.Cells[1].Value.ToString();
            snimiAS.Text = asiakkaatDG.CurrentRow.Cells[2].Value.ToString();
            puhAS.Text = asiakkaatDG.CurrentRow.Cells[3].Value.ToString();
            paikkakuntaAS.Text = asiakkaatDG.CurrentRow.Cells[4].Value.ToString();    
        }

        private void deleteAS_Click(object sender, EventArgs e)
        {
            if (idAS.Text == "")
            {
                MessageBox.Show("Käyttäjätunnus!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string id = idAS.Text;
                    Boolean deleteGuest = guest.removeGuest(id);
                    if (deleteGuest)
                    {
                        MessageBox.Show("Asiakas poistettu onnistuneesti", "Asiakkaan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getTable();
                    }
                    else
                    {
                        MessageBox.Show("Asiakasta ei pystytty poistamaan!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }
    }
}
