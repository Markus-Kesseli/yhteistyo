﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotelli
{
    public partial class Paaikkuna : Form
    {
        public Paaikkuna()
        {
            InitializeComponent();
        }

        private void Paaikkuna_Load(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void asiakkaidenHallintaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsiakkaidenHallinta ahlomake = new AsiakkaidenHallinta();
            ahlomake.ShowDialog();
        }

        private void hallitseVarauksiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VaraustenHallinta vhlomake = new VaraustenHallinta();
            vhlomake.ShowDialog();
        }

        private void hAllitseHuoneitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HuoneidenHallinta hhlomake = new HuoneidenHallinta();
            hhlomake.ShowDialog();
        }
    }
}
