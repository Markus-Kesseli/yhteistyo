using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eramake;

namespace Hotelli
{
    public partial class Salasana : Form
    {
        public Salasana()
        {
            InitializeComponent();
        }

        private void EncryptBT_Click(object sender, EventArgs e)
        {
            EncryptTB.Text = eCryptography.Encrypt(SalasanaTB.Text);
        }

        private void DecryptBT_Click(object sender, EventArgs e)
        {
            DecryptTB.Text = eCryptography.Decrypt(EncryptTB.Text);
        }
    }
}
