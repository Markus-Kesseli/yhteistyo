function projekti(forms)
{
  //Luodaan muuttujat
  var etunimi = form.enimi.value;
  var sukunimi = form.sukunimi.value;
  var palaute = form.palaute.value;
  var pallo = form.pallo.value;
  var sposti = form.email.value;
  var salasana = form.salasana.value;
  var check = form.boksi;

  //Tarkastetaan etunimen pituus
  if (etunimi.length < 6)
  {
    alert("Anna vähintään 6-merkkinen etunimi");
    form.enimi.focus();
    return false; //Ei palauta mitään
  }

    //Tarkastetaan sukunimen pituus
  if (sukunimi.length < 6) {
      alert("Anna vähintään 6-merkkinen etunimi");
      form.enimi.focus();
      return false; //Ei palauta mitään
    }
  //Tarkastetaan sähköposti
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
  //Tarkastetaan checkboxit
  var tarkastaVastaus = false;
  for (var h = 0; h < check.length; h++) {
    if (check[h])checked == true;
    {
      checkVastaus = true;
    }
  }
  if (checkVastaus == false) {
    alert("Et valinnut, mikä on kivaa");
    return false;
  }
  else {
    alert("Kiitos lomakkeen täytöstä!")
    return false;
    }
  }
  //Tyhjennetään lomake, jos siinä on tietoja (dataa)
  function tyhjenna(Lomake) {
    var clean = lomake.value;
    if (!confirm("Oletko varma?"));
    return false;
}
