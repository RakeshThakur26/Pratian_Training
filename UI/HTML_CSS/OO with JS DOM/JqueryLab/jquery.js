$('#ads').append($('<img>', { id: 'ads', src: './assets/hyundai-creta.jpeg', width: "80%", height: "50%" }))

getData();
function getData(e) {
   
    var ourReq = new XMLHttpRequest();

    ourReq.open(
        "GET",
        "./cars.json"
    );

    ourReq.onload = function () {
        if (ourReq.status >= 200 && ourReq.status < 400) {
            var ourData = JSON.parse(ourReq.responseText);
            display(ourData);
        }
    }
    ourReq.send();
}

var box = document.getElementById('box');
 function display(data) {
    let htmlstring = "";
    for (var x in data) {
        htmlstring += "<div class=\"row\">";

        htmlstring += "<div class=\"col-5 card\"> <img class=\"rounded float-left img-fluid\" src=\"" + data[x].src + "\" alt=\"\"> </div>"
        htmlstring += "<div class=\"col-7\">";
        htmlstring += "<Label><h3>" + data[x].carName + "</h3></Label><br>"
        htmlstring += " <label >" + data[x].model + "</label><br>"
        htmlstring += " <label >" + data[x].price + "</label><br>"
        htmlstring += " <label >" + data[x].desc + "</label><br>"
        htmlstring += "</div>     </div>     <br>      <hr>"

    }
    box.insertAdjacentHTML("beforeend", htmlstring);
}

function filterByPrice(e) {

//box.querySelectorAll('*').forEach(n => n.remove());
    
    var ourReq = new XMLHttpRequest();

    ourReq.open(
        "GET",
        "./cars.json"
    );
    var price = parseInt(document.getElementById('slideinput').value);
    console.log(price)

    ourReq.onload = function () {
        if (ourReq.status >= 200 && ourReq.status < 400) {
            var ourData = JSON.parse(ourReq.responseText);
            console.log(ourData)
            for (var x in ourData) {
                if (parseInt(ourData[x].price) < price){
                    console.log(ourData[x].price);
                    display(ourData);
                }
            }
        }
    }
    ourReq.send();
}

