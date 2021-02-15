"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();



connection.on("ReceiveMessage", function (user, message) {

});

connection.start().then(function () {
    
    setInterval(myFunction, 1000);
}).catch(function (err) {
    return console.error(err.toString());
});


function myFunction() {

    var user = "1";
    var message = "1";
    connection.invoke("PublishMessage").catch(function (err) {
        return console.error(err.toString());
    });

}

