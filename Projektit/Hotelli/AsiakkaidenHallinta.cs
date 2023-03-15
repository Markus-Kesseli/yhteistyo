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
    public partial class AsiakkaidenHallinta : Form
    {
        ASIAKAS asiakas = new ASIAKAS();
        public AsiakkaidenHallinta()
        {
            InitializeComponent();
        }

        private void TyhjennaKentatBT_Click(object sender, EventArgs e)
        {
            EtunimiTB.Text = "";
            SukunimiTB.Text = "";
            LahiosoiteTB.Text = "";
            PostinumeroTB.Text = "";
            PostitoimipaikkaTB.Text = "";
            KayttajatunnusTB.Text = "";
            SalasanaTB.Text = "";
        }

        private void LisaaUusiAsiakasBT_Click(object sender, EventArgs e)
        {
            String enimi = EtunimiTB.Text;
            String snimi = SukunimiTB.Text;
            String osoite = LahiosoiteTB.Text;
            String pnro = PostinumeroTB.Text;
            String ppaikka = PostitoimipaikkaTB.Text;
            String kayttaja = KayttajatunnusTB.Text;
            String salasana = SalasanaTB.Text;

            if (enimi.Trim().Equals("") || osoite.Trim().Equals("") || pnro.Trim().Equals("") || ppaikka.Trim().Equals(""))
            {
                MessageBox.Show("VIRHE - vaaditut kentät - Etu- ja Sukunimi, Osoite, Postinumero ja Postitoimipaikka", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaAsiakas = asiakas.lisaaAsiakas(enimi, snimi, pnro, ppaikka, kayttaja, salasana);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Uusi asiakas lisätty onnistueesti", "Asiakkaan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uutta asiakasta ei pystytty lisäämään", "Asiakkaan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

            private void AsiakkaidenHallinta_Load(object sender, EventArgs e)
        {
            AsiakkaatDG.DataSource = asiakas.haeAsiakkaat();
        }

        private void AsiakasMuokkaaBT_Click(object sender, EventArgs e)
        {
            String enimi = EtunimiTB.Text;
            String snimi = SukunimiTB.Text;
            String osoite = LahiosoiteTB.Text;
            String pnro = PostinumeroTB.Text;
            String ppaikka = PostitoimipaikkaTB.Text;
            String ktunnus = KayttajatunnusTB.Text;

            if (enimi.Trim().Equals("") || osoite.Trim().Equals("") || pnro.Trim().Equals("") || ppaikka.Trim().Equals(""))
            {
                MessageBox.Show("VIRHE - vaaditut kentät - Etu- ja Sukunimi, Osoite, Postinumero ja Postitoimipaikka", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean muokkaaAsiakas = asiakas.muokkaaAsiakasta(enimi, snimi, pnro, ppaikka, ktunnus);
                if (muokkaaAsiakas)
                {
                    MessageBox.Show("Uusi asiakas päivitetty onnistueesti", "Asiakkaan muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uutta asiakasta ei pystytty päivittämään", "Asiakkaan muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Näytetään listalta valitun asiakkaan tiedot tekstibokseissa
        private void AsiakkaatDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EtunimiTB.Text = AsiakkaatDG.CurrentRow.Cells[0].Value.ToString();
            SukunimiTB.Text = AsiakkaatDG.CurrentRow.Cells[1].Value.ToString();
            LahiosoiteTB.Text = AsiakkaatDG.CurrentRow.Cells[2].Value.ToString();
            PostinumeroTB.Text = AsiakkaatDG.CurrentRow.Cells[3].Value.ToString();
            PostitoimipaikkaTB.Text = AsiakkaatDG.CurrentRow.Cells[4].Value.ToString();
            KayttajatunnusTB.Text = AsiakkaatDG.CurrentRow.Cells[5].Value.ToString();
        }

        private void PoistaBT_Click(object sender, EventArgs e)
        {
            String ktunnus = KayttajatunnusTB.Text;
            if (asiakas.poistaAsiakas(ktunnus))
            {
                AsiakkaatDG.DataSource = asiakas.haeAsiakkaat();
                MessageBox.Show("Asiakas poistettu onnistuneesti", "Asiakkaan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Asiakasta ei pystytty poistamaan", "Asiakkaan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TyhjennaKentatBT.PerformClick();
        }
    }
}
