// Luodaan kortit
var merkit = ['cold.png','disguised.png','ghost.png','grinning.png','medicalmask.png','monkey.png','nerd.png','neutral.png','cold.png','disguised.png','ghost.png','grinning.png','medicalmask.png','monkey.png','nerd.png','neutral.png'];
// luodaan laskurimuuttuja
var smerkki = 0;
// luodaan vanha-muuttuja vanhaa korttia varten
// eli verrataan uutta korttia ja vanhaa korttia
var vanha = -1;
// luodaan vanhan kortin alt-ominaisuutta varten muuttuja
var valtti;
// varsinaisen taulukon luonti-funktio, jota kutsutaan HTML:n onload-komennolla
var siirrot = 0;
var kaikki = 0;
function luoTaulukko() {
  // Sekoitetaan alkuperÃ¤inen taulukko
   sekoitetut = sekoita(merkit);
   // Haetaan HTML-sivulta paikka, johon peli tulee
   var paikka = document.getElementById('pelialue');
   // Luodaan peliÃ¤ varten taulukkoelementti
   var taulukko = document.createElement('table');
   // Luodaan peliä varten taulukon sisältö elementti
  var taulukonSisus = document.createElement('tbody');
  // Itse taulukon luominen, ulompi for tekee rivit ja sisempi sarakkeet
  for(var i = 0; i < 4; i++)
  {
    // Luodaan rivielementti
    var rivi = document.createElement('tr');

    for(var j = 0; j < 4; j++)
    {
      // luodaan sarake-elementti
      var solu = document.createElement('td');
      // luodaan elementti, johon kortti asetetaan
      var sisus = document.createTextNode('');
      // Määritetään kortin alt-muuttuja, 0 - 15, eli jokaisella kortilla omansa
      solu.setAttribute('alt', sekoitetut[(smerkki)]);
      // Määritetään kortin id-muuttuja: solu+numero, esim. solu12
      solu.setAttribute('id', 'solu' + smerkki);
      // Määritetään kortin name-muuttuja 0 - 15, jokaisella omansa
      solu.setAttribute('name', smerkki);
      // Määritetään kortille onclick -toiminta, kutsutaan nayta-funktiota
      solu.setAttribute('onclick', 'nayta('+smerkki+');');
      // Kasvatetaan laskuria yhhdellÃ¤
      smerkki += 1;
      // Syötetään yllÃ¤olevat muutoksen kortin-tietoihin
      solu.appendChild(sisus);
      // Syötetään yllÃ¤olavat muutokset rivin tietoihin
      rivi.appendChild(solu);
    }
    // Syötetään rivit taulukon tbody-elementtiin
    taulukonSisus.appendChild(rivi);
  }
  // Syötetään lopuksi taulukon tbody-elementti taulukkoon
  taulukko.appendChild(taulukonSisus);
  // Ja aivan viimeiseksi syÃ¶tetÃ¤Ã¤n taulukko sille varattuun paikkaan
  paikka.appendChild(taulukko);
  // Määritetään taulukolle CSS-arvo border, joka on 2px
  taulukko.setAttribute('border', '2');
}
// Valmiiksi annettu funktio, joka sekoittaa pakan.
function sekoita(taulukko)
{
    taulukko.sort(function(a, b){return 0.5 - Math.random()});
    return taulukko;
}
// Funktio, joka laitetaan jokaisen kortin onclick-toiminnoksi
  function nayta(numero)
  {
  siirrot++;
  document.getElementById('siirrot').innerHTML = Math.floor(siirrot/2);
  // haetaan napautettu kortti
  var tunnus = document.getElementById('solu'+numero);
  // haetaan napautetun kortin alt-muuttuja
  var altti = tunnus.getAttribute('alt');
  // tarkistetaan, onko kortteja napautettu aiemmin
  if(vanha != -1)
  {
    // jos on, haetaan vanhan kortin alt-muuttuja
    valtti = vanha.getAttribute('alt');
  }
  else{
    // muussa tapauksessa syÃ¶tetÃ¤Ã¤n siihen -1
    valtti = vanha;
  }

  // Syötetään napautetun taustan tilalle valitun kortin kuva
  tunnus.innerHTML = '<img src="image/'+altti+'">';
  // tarkastetaan, onko edellinen kortti ja nykyinen kortti samoja (altit)
  if(altti == valtti){
    // Mikäli ovat, haetaan nykyisen kortin alt-muuttuja
    var altti = tunnus.getAttribute('alt');
    // Näytetään vanhakortti
    vanha.innerHTML = '<img src="image/'+altti+'">';
    // Näytetään uusi kokrtti
    tunnus.innerHTML = '<img src="image/'+altti+'">';
  }
  else{
    // Muussa tapauksessa tehdään nykyisestä kortista vanha
    vanha = tunnus;
    // Pysäytetään ohjelman suoritus hetkeksi
    odota(tunnus);
    kaikki++;
    console.log(kaikki);
    if (kaikki >= 8) {
      clearInterval(interval);
      }
    }
}

  function odota(joku) {
  // varsinainen pysÃ¤ytys funktio
    setTimeout(function(){
      // pysÃ¤ytyksen jÃ¤lkeen tyhjennetÃ¤Ã¤n nykyisen kortin tiedot
     joku.innerHTML = '';
     // Pysäytetään pituus 500 ms = 0,5 sekunti
   }, 500);
}

  if (merkit == vanha) {
  //Jos molemmat kortit ovat parit, lisätään add matched class -ominaisuudet, jotta nämä kortit jätetään huomioitta seraavalla kerralla
  merkit.classList.add("matched");
  vanha.classList.add("matched");
}

var minute = 0;
var second = 0;
var hour = 0;
var timer = document.querySelector(".ajastin");
var interval;

  function startTimer() {
    interval = setInterval(function() {
      timer.innerHTML = hour + " hr " + minute + " mins " + second + " secs";
    if (second >= 59) {
      minute += 1;
      second = 0;

    if (minute >= 60) {
      hour += 1;
        minute = 0;
      }
    }

    second++;
  }, 1000);
}

//Ajan nollaus
second = 0;
minute = 0;
hour = 0;
var ajastin = document.querySelector(".ajastin");
timer.innerHTML = "0 hr 0 mins 0 secs";
clearInterval(interval);
startTimer()
