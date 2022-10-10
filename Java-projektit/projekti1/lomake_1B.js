function lomake1B() {
  //Haetaan html-documentista käyttäjän syöttämät arvot
  var form = document.getElementById("kyselylomake").value;
  var nimi = document.getElementById("nimi").value;
  var sposti = document.getElementById("email").value;
  var ika =  document.getElementById("ika").value;
  var radio = document.getElementById("ruoka1").value;
  var radio = document.getElementById("ruoka2").value;
  var radio = document.getElementById("ruoka3").value;
  var radio = document.getElementById("ruoka4").value;

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
  var vastaus = false;
//Edellistä kohtaa varten tehdään silmukka, joka sitten käy jokaisen painikkeen läpi
  for (var i = 0; i < radio.length; i++) {
  if (radio[i].checked == true) {
    vastaus = true;
  }
}
