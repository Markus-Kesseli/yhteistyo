  //Nyt toimii peli
  var luku1 = document.getElementById("message1");
  var luku2= document.getElementById("message2");
  var luku3 = document.getElementById("message3");

  var answer = Math.floor(Math.random()*10) + 1;
  var nro_of_guesses = 1;
  var guessed_nums = [];

  function arvauspeli()
{
  var user_guess = document.getElementById("guess").value;
   if (user_guess >= 3) {
    guessed_nums.push(user_guess);
    document.getElementById("btn").hidden = true;
    message2.innerHTML = "nro_of_guesses: " + nro_of_guesses;
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
    else {
      message1.innerHTML = "Nice! You win!";
      }
      message2.innerHTML = "nro_of_guesses: " + nro_of_guesses;
      message3.innerHTML = "guessed nums: " + guessed_nums;
    }
      nro_of_guesses++;
}
