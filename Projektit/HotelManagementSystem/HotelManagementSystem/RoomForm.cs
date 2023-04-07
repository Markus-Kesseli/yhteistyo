using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class RoomForm : Form
    {
        Room room = new Room();
        public RoomForm()
        {
            InitializeComponent();
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            huoneCB.DataSource = room.getRoomType();
            huoneCB.DisplayMember = "Label";
            huoneCB.ValueMember = "CategoryId";

            getRoomList();


        }

        private void lisaaBT_Click(object sender, EventArgs e)
        {
            string no = huoneid.Text;
            int type = Convert.ToInt32(huoneCB.SelectedValue.ToString());
            string ph = huonePUH.Text;
            string status = huonevapaa.Checked ? "Vapaa" : "Varattu";

            try
            {
                if (room.AddRoom(no, type, ph, status))
                {
                    MessageBox.Show("Huone lisätty onnistuneesti", "Huoneen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getRoomList();
                }
                else
                {
                    MessageBox.Show("Huonetta ei voitu lisätä", "Huoneen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CleanAS_Click(object sender, EventArgs e)
        {
            huoneid.Clear();
            huoneCB.SelectedIndex = 0;
            huonePUH.Clear();
        }

        private void getRoomList()
        {
            huoneetDG.DataSource = room.getRoomList();
        }

        private void updateAS_Click(object sender, EventArgs e)
        {
            string no = huoneid.Text;
            int type = Convert.ToInt32(huoneCB.SelectedValue.ToString());
            string ph = huonePUH.Text;
            string status = huonevapaa.Checked ? "Vapaa" : "Varattu";

            try
            {
                if (room.editRoom(no, type, ph, status))
                {
                    MessageBox.Show("Huone muokattu onnistuneesti", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getRoomList();
                }
                else
                {
                    MessageBox.Show("Huonetta ei voitu muokata", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void huoneetDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            huoneid.Text = huoneetDG.CurrentRow.Cells[0].Value.ToString();
            huoneCB.SelectedValue = huoneetDG.CurrentRow.Cells[1].Value.ToString();
            huonePUH.Text = huoneetDG.CurrentRow.Cells[2].Value.ToString();

            string rbutton = huoneetDG.CurrentRow.Cells[3].Value.ToString();
            if(rbutton.Equals("Vapaa"))
            {
                huonevapaa.Checked = true;
            }
            else
            {
                huonevarattu.Checked = true;
            }
        }

        private void deleteAS_Click(object sender, EventArgs e)
        {
            if (huoneid.Text == "")
            {
                MessageBox.Show("Käyttäjätunnus!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string id = huoneid.Text;
                    Boolean deleteRoom = room.removeRoom(id);
                    if (deleteRoom)
                    {
                        MessageBox.Show("Huone poistettu onnistuneesti", "Huoneen poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getRoomList();
                    }
                    else
                    {
                        MessageBox.Show("Huonetta ei pystytty poistamaan!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
