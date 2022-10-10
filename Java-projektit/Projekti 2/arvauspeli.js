var msg1 = document.getElementById("message1");
var msg2 = document.getElementById("message2");
var msg3 = document.getElementById("message3");

var answer = Math.floor(Math.random()*10) + 1;
var nro_of_guesses = 0;
var guessed_nums = [];

function arvauspeli() {
  var user_guess = document.getElementById("arvaa").value;
  if (user_guess < 1 || user_guess > 10) {
    alert("Ole hyvä ja laita 1-10 numeroiden väliltä");
  }
  else {
    guessed_nums.push(user_guess);
    nro_of_geuesses += 1;
    if (user_guess < answer) {
      msg1.textContent = "Your guess is too low";
      msg2.textContent = "Nro. Of guesses: " + nro_of_guesses;
      msg3.textContent = "Guessed: numbers are: :" + guessed_nums;
      }
      else if (user_guess > answer) {
        msg1.textContent = "Your guess is too high";
        msg2.textContent = "Nro. Of guesses: " + nro_of_guesses;
        msg3.textContent = "Guessed: numbers are: :" + guessed_nums;
      }
        else if (user_guess == answer) {
         msg1.textContent = "Nice! You win!";
         msg2.textContent = "The number was: " + answer;
         msg3.textContent = "Guessed: numbers are: :" + nro_of_guesses + "guesses" ;
        }
      }
    }
