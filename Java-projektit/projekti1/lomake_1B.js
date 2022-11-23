function lomake1B() {
  //Haetaan html-documentista käyttäjän syöttämät arvot
  var form = document.getElementById("kyselylomake").value;
  var nimi = document.getElementById("nimisyotto").value;
  var sposti = document.getElementById("emailsyotto").value;
  var ika = document.getElementById("ikasyotot").value;
  var palaute = document.getElementById("palautet").value;
  var ruo1 = document.getElementById('ruoka1');
  var ruo2 = document.getElementById('ruoka2');
  var ruo3 = document.getElementById('ruoka3');

  //Tarkistetaan nimi
  if (nimi.length < 5)
  {
    alert("Anna nimi");
    return false; //Ei palauta mitään
  }
  //min- ja max-määrite?
  var min = (Math.min(1));
  var max = (Math.max(110));

  //Tarkastetaan ikä
  for (var i = 0; i < ika; i++) {
    alert("Syötä ikäsi");
    return false;
  }
  //Tarkastetaan sähköposti
  var tarkistus = /\S+@\S+/;
  if (!tarkistus.test(sposti)) {
    alert("Anna oikea sähköposti!");
  }



  if(ruo1.checked)
  {

  }
  else if (ruo2.checked)
  {

  }
  else if (ruo3.checked)
  {

  }
  else {
    alert("Et valinnut lempiruokaasi!")
  };

  if (palaute.length < 35)
  {
    alert("Palautteessa tulee olla vähintään 35-merkkiä!");
  };

}
