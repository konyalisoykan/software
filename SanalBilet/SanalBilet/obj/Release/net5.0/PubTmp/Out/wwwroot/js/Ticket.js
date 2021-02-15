"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable send button until connection is established
document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (message) {
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    var encodedMsg =  " Biley No :  " + msg;
    var li = document.createElement("li");
    li.textContent = encodedMsg;
    document.getElementById("messagesList").appendChild(li);
});

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
    // setInterval(myFunction, 100);
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    var branchcode = document.getElementById("BranchCodeInput").value;
   
    connection.invoke("SendMessage", branchcode).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});
function myFunction() {

    var user = "1";
    var message = "1";
    connection.invoke("SendMessage", user, message).catch(function (err) {
        return console.error(err.toString());
    });

}

