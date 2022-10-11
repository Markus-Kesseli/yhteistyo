var message1 = document.getElementById("message1");
var message2 = document.getElementById("message2");
var message3 = document.getElementById("message3");

var answer = Math.floor(Math.random()*10) + 1;
var nro_of_guesses = 0;
let guessed_nums = [];

function arvauspeli() {
  var user_guess = document.getElementById("guess").value;
  if (user_guess < 1 || user_guess > 10) {
    alert("Ole hyvä ja laita 1-10 numeroiden väliltä");
  }
  else {
    guessed_nums.push(user_guess);
    nro_of_guesses += 1;
    if (user_guess < answer) {
      message1.textContent = "Your guess is too low.";
      message2.textContent = "Nro. Of guesses: " + nro_of_guesses;
      message3.textContent = "Guessed: numbers are: :" + guessed_nums;
      }
     else if (user_guess > answer) {
      message1.textContent = "Your guess is too high.";
      message2.textContent = "Nro. Of guesses: " + nro_of_guesses;
      message3.textContent = "Guessed numbers are:" + guessed_nums;
      }
      else if (user_guess == answer) {
       message1.textContent = "Nice! You win!";
       message2.textContent = "The number was: " + answer;
       message3.textContent = "You guessed it in:" + nro_of_guesses + "guesses";
        document.getElementById("btn");
        }
      }
    }
