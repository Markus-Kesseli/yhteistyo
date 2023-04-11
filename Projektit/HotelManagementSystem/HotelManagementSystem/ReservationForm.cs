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
    public partial class ReservationForm : Form
    {

        Room room = new Room();
        Reservation reservation = new Reservation();
        public ReservationForm()
        {
            InitializeComponent();
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            huonetypeCB.DataSource = room.getRoomType();
            huonetypeCB.DisplayMember = "Label";
            huonetypeCB.ValueMember = "CategoryId";
            int type = Convert.ToInt32(huonetypeCB.SelectedValue.ToString());
            huonenroCB.DataSource = reservation.roomByType(type);
            huonenroCB.DisplayMember = "RoomId";
            huonenroCB.ValueMember = "RoomId";

            getReservTable();

        }

        public void getReservTable()
        {
            varauksetDG.DataSource = reservation.getReserv();
        }

        private void huonetypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int type = Convert.ToInt32(huonetypeCB.SelectedValue.ToString());
                huonenroCB.DataSource = reservation.roomByType(type);
                huonenroCB.DisplayMember = "RoomId";
                huonenroCB.ValueMember = "RoomId";
            }
            catch (Exception)
            {

            }
        }

        private void lisaaVR_Click(object sender, EventArgs e)
        {
            try
            {
                string guestId = asiakasID.Text;
                string roomNo = huonenroCB.SelectedValue.ToString();
                DateTime dIn = datein.Value;
                DateTime dOut = dateout.Value;

                if (dIn < DateTime.Today)
                {
                    MessageBox.Show("Varauspäivän tulee olla tänään tai sen jälkeen", "Virheellinen päivämäärä", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dOut < dIn)
                {
                    MessageBox.Show("Varauspäivämäärän tulee olla sama päivämäärä ja sen jälkeen", "Invalid date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    if (reservation.AddReserv(guestId, roomNo, dIn, dOut) && reservation.setReservRoom(roomNo, "Varattu"))
                    {
                        MessageBox.Show("Varauksen lisäys onnistui!", "Varauksen lisääminen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getReservTable();
                    }
                    else
                    {
                        MessageBox.Show("Varauksen lisäys epäonnistui!", "Varauksen lisääminen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Varauksen lisäys virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void poistaVR_Click(object sender, EventArgs e)
        {
            int reserId = Convert.ToInt32(varausID.Text);
            string rno = huonenroCB.Text;

            try
            {
                if(reservation.removeReserv(reserId)&& reservation.setReservRoom(rno,"Vapaa")) 
                {
                    getReservTable();
                    MessageBox.Show("Varaus poistettu onnistuneesti","Varauksen poisto", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            { 
                MessageBox.Show(ex.Message, "Poisto virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void varauksetDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            varausID.Text = varauksetDG.CurrentRow.Cells[0].Value.ToString();
            asiakasID.Text = varauksetDG.CurrentRow.Cells[1].Value.ToString();

            string rno = varauksetDG.CurrentRow.Cells[2].Value.ToString();
            huonetypeCB.SelectedValue = reservation.typeByRoomNo(rno);
            huonenroCB.Text = rno;
            
            datein.Text = varauksetDG.CurrentRow.Cells[3].Value.ToString();
            dateout.Text = varauksetDG.CurrentRow.Cells[4].Value.ToString();
        }

        private void tyhjennaVR_Click(object sender, EventArgs e)
        {
            varausID.Clear();
            asiakasID.Clear();
            huonetypeCB.SelectedValue = 1;
            datein.Value = DateTime.Now;
            dateout.Value = DateTime.Now;
        }

        private void paivitaVR_Click(object sender, EventArgs e)
        {
            try
            {
                int reservId = Convert.ToInt32(varausID.Text);
                string guestId = asiakasID.Text;
                string roomNo = huonenroCB.SelectedValue.ToString();
                DateTime dIn = datein.Value;
                DateTime dOut = dateout.Value;

                if (dIn < DateTime.Today)
                {
                    MessageBox.Show("Varauspäivän tulee olla tänään tai sen jälkeen", "Virheellinen päivämäärä", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dOut < dIn)
                {
                    MessageBox.Show("Varauspäivämäärän tulee olla sama päivämäärä ja sen jälkeen", "Virheellinen päivämäärä", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    if (reservation.editReserv(reservId, guestId, roomNo, dIn, dOut) && reservation.setReservRoom(roomNo, "Varattu"))
                    {
                        MessageBox.Show("Varauksen päivittäminen onnistui!", "Varauksen päivittäminen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getReservTable();
                    }
                    else
                    {
                        MessageBox.Show("Varauksen päivittäminen epäonnistui!", "Varauksen päivittäminen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Varauksen päivitys virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
