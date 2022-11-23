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
  var valinta = document.getElementById('pudotus')

  //Tarkistetaan nimi
  if (nimi.length < 5)
  {
    alert("Anna nimi");
    return false; //Ei palauta mitään
  }

  if ( ika < 1 || ika>100 ) {
      alert("The age must be a number between 1 and 100");
       return false;
   }
  return true;

  //Tarkastetaan sähköposti
  var tarkistus = /\S+@\S+/;
  if (!tarkistus.test(sposti)) {
    alert("Anna oikea sähköposti!");
  }

  if(valinta.selectedIndex <=0)
      {
        alert("Valitse ajoneuvo!");
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

      if (palaute.length < 20)
      {
        alert("Palautteessa tulee olla vähintään 20-merkkiä!")
      }
      else {
        alert("Kiitos lomakkeen täytöstä!")
      }

   }
