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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void asiakkaat_Click(object sender, EventArgs e)
        {
            GuestForm guest = new GuestForm();
            guest.ShowDialog();
        }

        private void huoneet_Click(object sender, EventArgs e)
        {
            RoomForm room = new RoomForm();
            room.ShowDialog();
        }

        private void varaukset_Click(object sender, EventArgs e)
        {
            ReservationForm reservation = new ReservationForm();
            reservation.ShowDialog();
        }
    }
}
