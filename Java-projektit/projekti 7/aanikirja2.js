function sound(animal)
{
  sound = animal.id;
  var audio = new Audio('sounds/'+sound+'.mp3');
  audio.play();
}
