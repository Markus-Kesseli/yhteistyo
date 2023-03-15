using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eramake;
using MySql.Data.MySqlClient;
using Eramake;
using System.Windows.Forms;

namespace Hotelli
{
    /*
        *Luodaan asiakasluokka seuraaville:
         *  - Uuden asiakkaan lisääminen 
         *  - Olemassa oelvan asiakkaan muokkaamiseen
         *   - Olemassa oelvan asiakkaan poistamiseen
         *   -Kaikkien asiakkaiden hakuun
         */
    internal class ASIAKAS
    {
        Yhdista yhteys = new Yhdista();
        //Lisätään funktio, jonka avulla lisätään uusi asiakas

        public bool lisaaAsiakas(String enimi, String snimi, String osoite, String ppnro, String ppaikka, String kayttaja, String ssana)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisaakysely = "INSERT INTO asiakkaat " +
                "(Ktunnus, Etunimi, Sukunimi, Lahiosoite, Postinumero, Postitoimipaikka, Salasana) " +
                "VALUES(@ktu, @enm, @snm, @pno, @ptp, @ssa); ";
            komento.CommandText = lisaakysely;
            komento.Connection = yhteys.otaYhteys();
            //@ktu, @enm, @snm, @pno, @ptp, @ssa
            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@oso", MySqlDbType.VarChar).Value = osoite;
            komento.Parameters.Add("@pno", MySqlDbType.VarChar).Value = ppnro;
            komento.Parameters.Add("@ptp", MySqlDbType.VarChar).Value = ppaikka;
            komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = kayttaja;


            if (kayttaja != "")
            {
                komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = kayttaja.ToLower();
            }
            else
            {
                komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = enimi.Substring(0, 3).ToLower() + snimi.Substring(0, 5).ToLower();
            }
            if (ssana != "")
            {
                komento.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = eCryptography.Encrypt(ssana);
            }
            else
            {
                komento.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = eCryptography.Encrypt(luoSalasana());
                MessageBox.Show(luoSalasana());
            }

            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }


        //Luodaan salasana
        public String luoSalasana()
        {
            char[] alpha = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!#€?0123456789".ToCharArray();
            Random satunnaisluku = new Random();
            String salasana = "";
            for (int i = 0; i < 12; i++)
            {
                int indeksi = satunnaisluku.Next(alpha.Length);
                salasana += alpha[indeksi];
            }
            return salasana;
        }


        //Luodaan funktio kaikkien asiakastietojen hakemiseksi
        public DataTable haeAsiakkaat()
        {
            MySqlCommand komento = new MySqlCommand("SELECT Etunimi, Sukunimi, Lahiosoite, Postinumero, Postitoimipaikka, Ktunnus FROM asiakkaat", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);
            return taulu;
        }

        public bool muokkaaAsiakasta(String enimi, String snimi, String osoite, String ppnro, String ppaikka, String ktunnus)
        {
            MySqlCommand komento = new MySqlCommand();
            String paivitakysely = "UPDATE `asiakkaat` SET `Etunimi` = @enm," +
                "`Sukunimi`= @snm, `Lahiosoite` = @oso, `Postinumero` = @pno, `Postitoimipaikka` = @ptp" +
                "WHERE Ktunnus = @ktu";

            komento.CommandText = paivitakysely;
            komento.Connection = yhteys.otaYhteys();
            //@ktu, @enm, @snm, @oso, @pno, @ptp, @ssa
            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@oso", MySqlDbType.VarChar).Value = osoite;
            komento.Parameters.Add("@pno", MySqlDbType.VarChar).Value = ppnro;
            komento.Parameters.Add("@ptp", MySqlDbType.VarChar).Value = ppaikka;
            komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = ktunnus;

            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }
        public bool poistaAsiakas(String ktunnus)
        {
            MySqlCommand komento = new MySqlCommand();
            String poistakysely = "DELETE FROM asiakkaat WHERE Ktunnus = @ktu";
            komento.CommandText = poistakysely;
            komento.Connection = yhteys.otaYhteys();
            //@ktu
            komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = ktunnus;

            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }

        internal bool muokkaaAsiakasta(String enimi, String snimi, String pnro, String ppaikka, String ktunnus)
        {
          {
             throw new NotImplementedException();

          }
        }
        internal bool lisaaAsiakas(String enimi, String snimi, String pnro, String ppaikka, String kayttaja, String salasana)
        {
          {
             throw new NotImplementedException();
          }
        }
    }
}
