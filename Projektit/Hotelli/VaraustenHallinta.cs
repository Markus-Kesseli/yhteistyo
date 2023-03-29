using System;
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
    public partial class VaraustenHallintaForm : Form
    {
        public VaraustenHallintaForm()
        {
            InitializeComponent();
        }
        VARAUS varaus = new VARAUS();
        HUONE huone = new HUONE();
        ASIAKAS asiakas = new ASIAKAS();
        private void VarausLisaaBT_Click(object sender, EventArgs e)
        {
            int asiakas = Convert.ToInt32(VarausAsiakasNroCB.SelectedValue.ToString());
            int huone = Convert.ToInt32(VarausHuoneNroCB.SelectedValue.ToString());
            DateTime sisaankirjautuminen = Convert.ToDateTime(VarausSisaanDTB.Value);
            DateTime uloskirjautuminen = Convert.ToDateTime(VarausUlosDTB.Value);

            if (varaus.lisaaVaraus(huone, asiakas, sisaankirjautuminen, uloskirjautuminen))
            {
                MessageBox.Show("Varaus lisätty onnistuneesti", "Varausten hallinta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Varausta ei pystytty lisäämään", "Varausten hallinta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            VaraustenHallintaDG.DataSource = varaus.haeVaraukset();
        }

        private void VarausNroTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void VaraustenHallinta_Load(object sender, EventArgs e)
        {
            VarausHuonetyyppiCB.DataSource = huone.huonetyyppilista();
            VarausHuonetyyppiCB.DisplayMember = "Huonetyyppi";
            VarausHuonetyyppiCB.ValueMember = "KategoriaId";

            VarausAsiakasNroCB.DataSource = asiakas.haeAsiakkaat();
            VarausAsiakasNroCB.DisplayMember = "Kokonimi";
            VarausAsiakasNroCB.ValueMember = "AsiakasId";
            VaraustenHallintaDG.DataSource = varaus.haeVaraukset();
        }

        private void VarausHuonetyyppiCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int huonetype = VarausHuonetyyppiCB.SelectedIndex + 1;

            VarausHuoneNroCB.DataSource = huone.tyypillisetHuoneet(huonetype);
            VarausHuoneNroCB.DisplayMember = "HuoneenNro";
            VarausHuoneNroCB.ValueMember = "HuoneenNro";
        }

        private void VarausMuokkaaBT_Click(object sender, EventArgs e)
        {
            int huone = Convert.ToInt32(VarausHuoneNroCB.SelectedValue.ToString());
            int asiakas = Convert.ToInt32(VarausAsiakasNroCB.SelectedValue.ToString());
            DateTime sisaan = Convert.ToDateTime(VarausSisaanDTB.Value);
            DateTime ulos = Convert.ToDateTime(VarausUlosDTB.Value);

            try
            {
                int vara = Convert.ToInt32(VarausNroTB.Text);

                if (varaus.muokkaaVarausta(huone, asiakas, sisaan, ulos, vara))
                {
                    MessageBox.Show("Huone muokattu onnistuneesti", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Huonetta ei pystytty muokkaamaan", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex.Message, "Huoneen numero virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            VaraustenHallintaDG.DataSource = varaus.haeVaraukset();
        }

        private void VaraustenHallintaDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            VarausNroTB.Text = VaraustenHallintaDG.CurrentRow.Cells[0].Value.ToString();
            VarausAsiakasNroCB.SelectedValue = VaraustenHallintaDG.CurrentRow.Cells[2].Value.ToString();
            VarausHuoneNroCB.SelectedValue = VaraustenHallintaDG.CurrentRow.Cells[1].Value.ToString();
            VarausSisaanDTB.Value = Convert.ToDateTime(VaraustenHallintaDG.CurrentRow.Cells[3].Value);
            VarausUlosDTB.Value = Convert.ToDateTime(VaraustenHallintaDG.CurrentRow.Cells[4].Value);
        }

        private void VarausPoistaBT_Click(object sender, EventArgs e)
        {
            try
            {
                String varausnro = VarausNroTB.Text;
                if (varaus.poistaVaraus(varausnro))
                {
                    VaraustenHallintaDG.DataSource = varaus.haeVaraukset();
                    MessageBox.Show("Varaus poistettu onnistuneesti", "Huoneen poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Varausta ei pystytty poistamaan", "Huoneen poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                VarausTyhjennaBT.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex.Message);
            }
        }

        private void VarausUlosDTB_ValueChanged(object sender, EventArgs e)
        {
            int huonenro = Convert.ToInt32(VarausHuoneNroCB.SelectedValue.ToString());
            DateTime sisaankirjautuminen = Convert.ToDateTime(VarausSisaanDTB.Value);
            DateTime uloskirjautuminen = Convert.ToDateTime(VarausUlosDTB.Value);
            if (varaus.tarkistaPaiva(sisaankirjautuminen, uloskirjautuminen, huonenro))
            {

            }
            else
            {
                MessageBox.Show("Tämä päivä on varattu tuossa huoneessa", "päivämäärän tarkastus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                VarausTyhjennaBT.PerformClick();
            }
        }

        private void VarausTyhjennaBT_Click(object sender, EventArgs e)
        {
            VarausNroTB.Text = ""; 
            VarausAsiakasNroCB.SelectedIndex = -1;
            VarausHuonetyyppiCB.SelectedIndex = 0; 
            VarausHuoneNroCB.SelectedIndex = 0; 
            VarausSisaanDTB.Value = DateTime.Now; 
            VarausUlosDTB.Value = DateTime.Now;
        }
    }
}
