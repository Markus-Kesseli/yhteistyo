  var message1 = document.getElementById("message1");
  var message2 = document.getElementById("message2");
  var message3 = document.getElementById("message3");

  var answer = Math.floor(Math.random()*10) + 1;
  var nro_of_guesses = 0;
  var guessed_nums = [];

    function arvauspeli() {
     var user_guess = document.getElementById("guess").value;
    if (user_guess < 1 || user_guess > 10) {
    alert("Ole hyvä ja laita 1-10 numeroiden väliltä");
    }
    else {
      guessed_nums.push(user_guess);
      }
    if (user_guess < answer) {
      message1.innerHTML = "Your guess is too low.";
      }
     else if (user_guess > answer) {
        message1.innerHTML= "Your guess is too high.";
      }
     else {
       message1.innerHTML = "Nice! You win!";
     }
      nro_of_guesses++;
      message2.innerHTML = "nro_of_guesses: " + nro_of_guesses;
      message2.innerHTML = "guessed nums: " + guessed_nums;
  }

