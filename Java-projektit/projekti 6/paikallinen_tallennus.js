
  let lomake1B = () => {

  //Haetaan html-documentista käyttäjän syöttämät arvot
  const etunimi = document.form.enimi;
  const sukunimi = document.form.snimi;
  const lahiosoite = document.form.losoite;
  const postinumero = document.form.pnumero;
  const postitoimipaikka = document.form.posoite;
  const puhe = document.form.puh;
  const sposti = document.form.email;

  //Tarkistetaan nimi
  if (etunimi.length < 4)
  {
    alert("Anna vähintään 4-merkkinen etunimi!");
    return false; //Ei palauta mitään
  }

  //Tarkastetaan sukunimen pituus
  if (sukunimi.length < 5)
  {
    alert("Anna vähintään 5-merkkinen sukunimi!");
    return false; //Ei palauta mitään
  }

  //Tarkistetaan lähiosoite
  if (lahiosoite.length < 5)
  {
    alert("Anna lähiosoite!");
    return false; //Ei palauta mitään
  }

  //Tarkistetaan postinumero
  if (postinumero.length < 5)
  {
    alert("Anna postinumero!");
    return false; //Ei palauta mitään
  }

  //Tarkistetaan postitoimipaikka
  if (postitoimipaikka.length < 4)
  {
    alert("Anna postitoimipaikka!");
    return false; //Ei palauta mitään
  }

  //puhelinnumeron tarkistus
  var puh = /^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4}$/im
  if(puh.test(puhe))
  {
   alert("Anna puhelinnumero!");
   return false;
  }

  //Tarkastetaan sähköposti
  var tarkistus = /\S+@\S+/;
  if (tarkistus.test(sposti)) {
  alert("Anna sähköposti!");
  }

  var data = "Nimi: " + etunimi.value + "\r\n" +
  "Sukunimi: " + sukunimi.value + "\r\n" +
  "Lähiosoite: " + lahiosoite.value + "\r\n" +
  "Postinumero: " + postinumero.value + "\r\n" +
  "Postitoimipaikka: " + postitoimipaikka.value + "\r\n" +
  "Puhelin: " + puhe.value + "\r\n" +
  "Sähköposti: " + sposti.value;

  console.log(data);

  const textToBLOB = new Blob([data], { type: "text/plain" });

  var filename = new Date();

            var month =new Date(); //months from 1-12
            month = month.getMonth();

            var day = new Date();
            var day = day.getUTCDate();

            var year = new Date();
            var year = year.getUTCFullYear();

            newdate = year + "/" + month + "/" + day;
            const sFileName = filename; // The file to save the data.

            let newLink = document.createElement("a");
            newLink.download = new Date();

            if (window.webkitURL != null) {
                newLink.href = window.webkitURL.createObjectURL(textToBLOB);
            } else {
                newLink.href = window.URL.createObjectURL(textToBLOB);
                newLink.style.display = "none";
                document.body.appendChild(newLink);
            }

            newLink.click();
        };


  function tyhjenna()
  {
    if (confirm("Oletko varma?"))
    {
      document.getElementById('clear').reset();
    }
}
