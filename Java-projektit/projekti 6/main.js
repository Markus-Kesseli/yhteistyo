function store(){ //stores items in the localStorage
    var etunimi = document.getElementById('enimi').value;
    var sukunimi = document.getElementById('snimi').value;
    var lahiosoite = document.getElementById('losoite').value;
    var postinumero = document.getElementById('pnumero').value;
    var postitoimipaikka = document.getElementById('posoite').value;
    var puhelin = document.getElementById('puhe').value;
    var sahkoposti = document.getElementById('sposti').value;
    var key = document.getElementById('key').value;

    const lomake = {
        lahiosoite: lahiosoite,
        etunimi: etunimi,
        sukunimi: sukunimi,
        postinumero: postinumero,
        postitoimipaikka: postitoimipaikka,
        puhelin: puhelin,
        sahkoposti: sahkoposti,
    }

    window.localStorage.setItem(key,JSON.stringify(lomake));
    //converting object to string
}

function retrieveRecords(){ //retrieves items in the localStorage
    var key = document.getElementById('retrieveKey').value; //gets key from user
    console.log("retrive records");
    var records = window.localStorage.getItem(key); //searches for the key in localStorage
    var paragraph = document.createElement("p");
    var infor = document.createTextNode(records);
    paragraph.appendChild(infor);
    var element = document.getElementById("retrieve");
    element.appendChild(paragraph);
}

function removeItem(){ //deletes item from localStorage
    var key = document.getElementById('removeKey').value; //gets key from user
    localStorage.removeItem(key) //passes key to the removeItem method
    console.log("remove items");
}

function clearStorage(){ //clears the entire localStorage
    localStorage.clear()
    console.log("clear records");
}

window.onload =function(){ //ensures the page is loaded before functions are executed.
    document.getElementById("lomake").onsubmit = store
    document.getElementById("clearButton").onclick = clearStorage
    document.getElementById("removeButton").onclick = removeItem
    document.getElementById("retrieveButton").onclick = retrieveRecords
}
