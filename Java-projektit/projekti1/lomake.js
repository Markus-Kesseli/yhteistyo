function projekti()
{
  //Luodaan muuttujat
  var etunimi = document.formi.enimi.value;
  var sukunimi = document.formi.snimi.value;
  var sposti = document.formi.email.value;
  var salasana = document.formi.salasana.value;
  var check = document.formi.mp;
  var palaute = document.formi.palautet.value;
  var checkVastaus = document.formi.kivointa;
  var pallo = document.formi.tietokone;

  //Tarkastetaan etunimen pituus
  if (etunimi.length < 6)
  {
    alert("Anna vähintään 6-merkkinen etunimi");
    return false; //Ei palauta mitään
  }

    //Tarkastetaan sukunimen pituus
  if (sukunimi.length < 6)
  {
      alert("Anna vähintään 6-merkkinen sukunimi");
      return false; //Ei palauta mitään
  }
  //Tarkastetaan sähköposti
  var tarkistus = /\S+@\S+/;
  if (!tarkistus.test(sposti)) {
    alert("Anna kunnon sähköposti");
  }

  if (salasana.length < 6)
  {
      alert("Anna vähintään 6-merkkinen salasana");
      return false;

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
}
//Tarkastetaan tekstialue
if (palaute.length < 30) {
  alert("Palautteessa tulee olla vähintään 30-merkkiä!");
  document.formi.palaute.focus();
  return false;
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
  function tyhjenna() {
    var clean = document.formi.reset();
    if (!confirm("Oletko varma?"));
    return false;
}
