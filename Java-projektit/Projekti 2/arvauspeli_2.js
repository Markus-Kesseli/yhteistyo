  //Määritetään muuttujat ja haetaan html-documentista käyttöjän syöttämä luku
  var luku1 = document.getElementById("message1");
  var luku2 = document.getElementById("message2");
  var luku3 = document.getElementById("message3");
  var luku4 = document.getElementById("message4");

  var answer = Math.floor(Math.random()*10) + 1;
  var nro_of_guesses = 1;
  var guessed_nums = [];
  var wins = 0;
  var loose = 0;


  function arvauspeli()
{
  var user_guess = document.getElementById("guess").value;
  if (user_guess >= 10) {
    guessed_nums.push(user_guess);

    message2.innerHTML = "nro of guesses: " + nro_of_guesses;
    message3.innerHTML = "guessed nums: " + guessed_nums;
  }
    else {
     if
      (user_guess < 1 || user_guess > 10) {
      alert("Ole hyvä ja anna numero 1 ja 10 välillä")
      }
    else {
     guessed_nums.push(user_guess);
      }
      if (user_guess < answer) {
       message1.innerHTML = "Your guess is too low.";
      }
      else if (user_guess > answer) {
        message1.innerHTML = "Your guess is too high.";
      }
      else if (user_guess == answer){
        message1.innerHTML = "Nice! You win!";
        wins++;
      }
      else {
        alert("Anna numeroina, ei kirjaimina")
      }
      for (let i = 3 ; i > 0; i--) {
        message2.innerHTML = "Nro Of guesses: " + nro_of_guesses;
        message3.innerHTML = "Guessed nums: " + guessed_nums;
        message4.innerHTML = "Wins " + wins;
        message5.innerHTML = "Loose " + loose;
        }
        nro_of_guesses++;
      }

}

function uusipeli()
  {
    answer = Math.floor(Math.random()*10) + 1;
    arvauspeli();
  }
