  function ilmoittautuminen()  {
  //Luodaan muuttujat
  var etunimi = document.formi.enimi.value;
  var sukunimi = document.formi.snimi.value;
  //Lisää tarkastukset myös allaoleviin muuttujiin
  var osoitetitedot = document.formi.osoitetitedot.value;
  var puhe = document.formi.puh.value;
  var sposti = document.formi.email.value;
  var oppilaitos = document.formi.oppilaitos.value;
  var opiskelija = document.formi.opiskelija.value;
  var syntymaaika = document.formi.syntymaaika.value;
  var hinta = document.formi.hinta.value;
  var erityisruokavalio = document.formi.erityisruokavalio.value;
  var lisatieto = document.formi.lisatieto.value;
  var checkVastaus = document.formi.kivointa;

  //Tarkastetaan etunimen pituus
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

  if (oppilaitos.length < 5)
  {
    alert("Anna vähintään 5-merkkinen oppilaitos");
    return false; //Ei palauta mitään
  }

  if (opiskelija.length < 10)
  {
    alert("Anna vähintään 10-merkkinen opiskelija");
    return false; //Ei palauta mitään
  }
  var now = new Date();
  //Tarkastetaan syntymäaika
  // 120v mittakaavassa
  var paiva = /^(0[1-9]|1[0-2])\.(0[1-9]|1\d|2\d|3[01])\.(19|20)\d{2}$/;
  if (!(paiva.test(syntymaaika))) {
    alert("Anna syntymäaika!")
    return false;
}

   //Tarkastetaan sähköposti
   var tarkistus = /\S+@\S+/;
   if (!tarkistus.test(sposti)) {
     alert("Anna sähköposti");
   }

//Tarkastetaan tekstialue
if (lisatieto.length < 10) {
  alert("Lisätiedossa tulee olla vähintään 10-merkkiä!");
  document.formi.lisatieto.focus();
  return false;
}
  if (checkVastaus == false) {
    alert("Anna lisätieto");
    return false;
  }
  else {
    alert("Kiitos lomakkeen täytöstä!")
    return false;
    }
  }
  //Tyhjennetään lomake, jos siinä on tietoja (dataa)
  function tyhjenna()
  {
    if (confirm("Oletko varma?"))
    {
      document.getElementById('clear').reset();
    }
}
