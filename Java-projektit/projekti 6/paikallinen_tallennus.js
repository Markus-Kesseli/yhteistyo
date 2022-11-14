// Set Item
//Tällä saamme kaiken tallennettua?
localStorage.setItem("lastname", "Smith");

// Retrieve
document.getElementById("demo").innerHTML = localStorage.getItem("lastname");

function lomake1B() {
  //Haetaan html-documentista käyttäjän syöttämät arvot
  var etunimi = document.form.enimi.value;
  var sukunimi = document.form.snimi.value;
  var lahiosoite = document.form.losoite.value;
  var postinumero = document.form.pnumero.value;
  var postitoimipaikka = document.form.posoite.value;
  var puhe = document.form.puh.value;
  var sposti = document.form.email.value;

  //Tarkistetaan nimi
  if (etunimi.length < 4)
  {
    alert("Anna vähintään 4-merkkinen etunimi");
    return false; //Ei palauta mitään
  }

  //Tarkastetaan sukunimen pituus
  if (sukunimi.length < 5)
  {
    alert("Anna vähintään 5-merkkinen sukunimi");
    return false; //Ei palauta mitään
  }

  //puhelinnumeron tarkistus
  var puh = /^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4}$/im
  if(!puh.test(puhe))
  {
   alert("Anna puhelinnumero!");
   return false;
  }

  //Tarkastetaan sähköposti
  var tarkistus = /\S+@\S+/;
  if (!tarkistus.test(sposti)) {
  alert("Anna sähköposti");
  }
}

  function tyhjenna()
  {
    if (confirm("Oletko varma?"))
    {
      document.getElementById('clear').reset();
    }
}
