
  function lomake1B() {

  //Haetaan html-documentista käyttäjän syöttämät arvot
  const etunimi = document.form.enimi;
  const sukunimi = document.form.snimi;
  const lahiosoite = document.form.losoite;
  const postinumero = document.form.pnumero;
  const postitoimipaikka = document.form.posoite;
  const puhe = document.form.puh;
  const sposti = document.form.email;

  //Tallennetaan käyttäjän syöttämät tiedot
  localStorage.setItem("Etunimi", etunimi.value);
  localStorage.setItem("Sukunimi", sukunimi.value);
  localStorage.setItem("Lähiosoite", lahiosoite.value);
  localStorage.setItem("Postinumero", postinumero.value);
  localStorage.setItem("Postitoimipaikka", postitoimipaikka.value);
  localStorage.setItem("Puhelin", puhe.value);
  localStorage.setItem("Sähköposti", sposti.value);
};

  //tyhjennetään lomake
  function tyhjenna()
  {
    if (confirm("Oletko varma?"))
    {
      document.getElementById('clear').reset();
    }
}

  //Tyhjennetään paikallinen muisti
  function poista()
    {
      localStorage.clear();
    }
