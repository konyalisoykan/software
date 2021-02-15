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
    //var i;
    //for (i = 0; i < 1000; i++) {
    //    setInterval(myFunction, 1);
    //}
    
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    var branchcode = document.getElementById("BranchCodeInput").value;
   var i;
    for (i = 0; i < 100;i++) {
        setInterval(myFunction, 100   );
    }
    connection.invoke("SendMessage", branchcode).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});
var  _counter=0;
function myFunction() {
    _counter++;
    var user = document.getElementById("BranchCodeInput").value;
    var message = "1";
    connection.invoke("SendMessage", user).catch(function (err) {
        return console.error(err.toString());
        document.getElementById("RequestCount").innerText = _counter.toString();
    });

}

