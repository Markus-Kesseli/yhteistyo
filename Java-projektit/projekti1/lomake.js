function katso(forms) {
  var etunimi = form.enimi.value;
  var sukunimi = form.sukunimi.value;
  var palaute = form.palaute.value;
  var pallo = form.pallo.value;
  var sposti = form.email.value;
  var salasana = form.salasana.value;
  var check = form.boksi;

  if (etunimi.length < 6) {
    alert("Anna vähintään 6-merkkinen etunimi");
    form.enimi.focus();
    return false; //Ei palauta mitään
  }
  var tarkistus = /\S+@\S+/;
  if (!tarkistus.test(sahkoposti)) {
    alert("Anna kunnon sähköposti");
  }
  //Tarkastetaan tekstialue
  if (palaute.length < 30) {
    alert("Palautteessa tulee olla vähintään 30-merkkiä!");
    form.palaute.focus();
    return false;
  }
  //Tarkastetaan radio-buttonit
  //Tehdään tosi/epätosi -muuttuja, joka asetetaan sitten epätodeksi
  var vastaus = false;
  //Edellistä kohtaa varten tehdään silmukka, joka sitten käy jokaisen painikkeen läpi
  for (var i = 0; i < pallo.length; i++) {
    if (pallo[i].checked == true) {
      vastaus = true;
    }
}
