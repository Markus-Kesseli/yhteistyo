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
    public partial class HuoneidenHallinta : Form
    {
        public HuoneidenHallinta()
        {
            InitializeComponent();
        }

        HUONE huone = new HUONE();

        private void HuoneidenHallinta_Load(object sender, EventArgs e)
        {
            HuonetyyppiCB.DataSource = huone.huonetyyppilista();
            HuonetyyppiCB.DisplayMember = "Huonetyyppi";
            HuonetyyppiCB.ValueMember = "KategoriaId";

            HuoneHallintaDG.DataSource = huone.haeHuoneet();
        }

        private void HuoneLisaaBT_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(HuoneHallintaNroTB.Text);
            int tyyppi = Convert.ToInt32(HuonetyyppiCB.SelectedValue.ToString());
            String puhelin = HuoneHallintaPuhelinTB.Text;
            if(huone.lisaaHuone(numero, tyyppi, puhelin, "Kyllä"))
            {
                MessageBox.Show("Huone lisätty onnistuneesti", "Huoneen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Huonetta ei pystytty lisäämään", "Huoneen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HuoneHallintaDG.DataSource = huone.haeHuoneet();
        }

        private void HuoneTyhjennaBT_Click(object sender, EventArgs e)
        {
            HuoneHallintaNroTB.Text = "";
            HuonetyyppiCB.SelectedIndex = 0;
            HuoneHallintaPuhelinTB.Text = "";
        }

        private void HuoneHallintaDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HuoneHallintaDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HuoneHallintaNroTB.Text = HuoneHallintaDG.CurrentRow.Cells[0].Value.ToString();
            HuonetyyppiCB.SelectedValue = HuoneHallintaDG.CurrentRow.Cells[1].Value.ToString();
            HuoneHallintaPuhelinTB.Text = HuoneHallintaDG.CurrentRow.Cells[2].Value.ToString();
        }

        private void HuoneMuokkaaBT_Click(object sender, EventArgs e)
        {
            int tyyppi = Convert.ToInt32(HuoneHallintaNroTB.Text);
            String puhelin = HuoneHallintaPuhelinTB.Text;
            String vapaa = "";

            try
            {
                int numero = Convert.ToInt32(HuoneHallintaNroTB.Text);
                if (HuoneVapaaRB.Checked)
                {
                    vapaa = "Kyllä";
                }
                else
                {
                    vapaa = "Ei";
                }
                if (huone.muokkaaHuonetta(numero, tyyppi, puhelin, vapaa))
                {
                    MessageBox.Show("Huone muokattu onnistueesti", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Huonetta ei pystytty muokkaamaan", "Huoneen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Virhe; " + ex.Message, "Huoneen numero virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HuoneHallintaDG.DataSource = huone.haeHuoneet();
        }

        private void HuonePoistaBT_Click(object sender, EventArgs e)
        {
            try
            {
                String huonenro = HuoneHallintaNroTB.Text;
                if (huone.poistaHuone(huonenro))
                {
                    HuoneHallintaDG.DataSource = huone.haeHuoneet();
                    MessageBox.Show("Huone poistettu onnistuneesti", "Huoneen poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Huonetta ei pystytty poistamaan", "Huoneen poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                HuoneTyhjennaBT.PerformClick();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Virhe: " + ex.Message);
            }
        }

        private void HuoneHallintaNroTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void HuonetyyppiCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
