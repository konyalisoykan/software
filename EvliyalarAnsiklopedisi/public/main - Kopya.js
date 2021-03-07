'use strict';
var firebase = require("firebase/app");

window.addEventListener('load', function () {

    try {


        var urlParams = new URLSearchParams(window.location.search);
        var myParam = urlParams.get('Sehir')
        alert(myParam);


        var button = document.createElement(myParam);
        var textNode = document.createTextNode(myParam);
        button.appendChild(textNode);
        button.className = 'mdl-button mdl-js-button mdl-js-ripple-effect';
        componentHandler.upgradeElement(button);
        document.getElementById('EviliyaConteiner').appendChild(button);
        // Bind Sign in button.
        //signInButton.addEventListener('click', function() {
        //  var provider = new firebase.auth.GoogleAuthProvider();
        //  firebase.auth().signInWithPopup(provider);

        var starCountRef = firebase.database().ref('Evliyalar');

        starCountRef.once('value', (snapshot) => {
            const data = snapshot.val();
        });
        fruits.forEach(myFunction);
        function myFunction(item, index) {
            var button = document.createElement(myParam);
            var textNode = document.createTextNode(myParam);
            button.appendChild(textNode);
            button.className = 'mdl-button mdl-js-button mdl-js-ripple-effect';
            componentHandler.upgradeElement(button);
            document.getElementById('EviliyaConteiner').appendChild(button);
        };
       
    }
    catch (err) {
        alert(err);
    }
  });


