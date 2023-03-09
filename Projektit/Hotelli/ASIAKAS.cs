using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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
                "(kayttajanimi, Etunimi, Sukunimi, Lahiosoite, Postinumero, Postitoimipaikka, Salasana) " +
                "VALUES(@ktu, @enm, @snm, @pno, @ptp, @ssa); ";
            komento.CommandText = lisaakysely;
            komento.Connection = yhteys.otaYhteys();
            //@ktu, @enm, @snm, @pno, @ptp, @ssa
            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@oso", MySqlDbType.VarChar).Value = osoite;
            komento.Parameters.Add("@pno", MySqlDbType.VarChar).Value = ppnro;
            komento.Parameters.Add("@ptp", MySqlDbType.VarChar).Value = ppaikka;


            if(kayttaja != "")
            {
                komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = kayttaja.ToLower();
            }
            else
            {
                komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = enimi.Substring(0, 3).ToLower() + snimi.Substring(0, 5).ToLower();
            }
            if (ssana != "")
            {
                komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = ssana.ToLower();
            }
            else
            {
                komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = "xcxcT6!2@";
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
        //Luodaan funktio kaikkien asiakastietojen hakemiseksi
        public DataTable haeAsiakkaat()
        {
            MySqlCommand komento = new MySqlCommand("SELECT Etunimi, Sukunimi, Lahiosoite, Postinumero, Postitoimipaikka, kayttajanimi FROM asiakkaat" ,yhteys.otaYhteys());
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
                "WHERE kayttajanimi = @ktu";

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
            String poistakysely = "DELETE FROM asiakkaat WHERE kayttajanimi = @ktu";
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
    }
}
