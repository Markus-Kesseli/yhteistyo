function lomake1B() {
  //Haetaan html-documentista käyttäjän syöttämät arvot
  var form = document.getElementById("kyselylomake").value;
  var nimi = document.getElementById("nimi").value;
  var sposti = document.getElementById("email").value;
  var ika = document.getElementById("ika").value;

  for (var i = 0; i < nimi.length; i++) {
    alert("Et syöttänyt koko nimeä");
    return false;
  }
  //min- ja max-määrite?
  var min = (Math.min(1));
  var max = (Math.max(110));
  //Tarkastetaan ikä
  
  for (var i = 0; i < ika; i++) {
    alert("Syötä ikäsi");
    return false;
  }
  //Tarkastetaan s-posti
  var tarkistus = /\S+@\S+/;
  if (!tarkistus.test(sposti)) {
  alert("Anna kunnon sähköposti");
  return false;
  }
}
