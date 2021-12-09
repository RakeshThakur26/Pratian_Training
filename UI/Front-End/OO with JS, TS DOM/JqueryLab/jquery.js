
getData();
$('#ads').append($('<img>', { id: 'ads', src: './assets/hyundai-creta.jpeg', width: "80%", height: "50%" }))



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
   // box.ht("beforeend", htmlstring);
}

var box2 = document.getElementById('box2');

 function display2(data, pric) {
    let newhtml = "";

    // if(data.price < pric){
    //     for (var x in data) {
    //         newhtml += "<div class=\"row\">";
    
    //         newhtml += "<div class=\"col-5 card\"> <img class=\"rounded float-left img-fluid\" src=\"" + data[x].src + "\" alt=\"\"> </div>"
    //         newhtml += "<div class=\"col-7\">";
    //         newhtml += "<Label><h3>" + data[x].carName + "</h3></Label><br>"
    //         newhtml += " <label >" + data[x].model + "</label><br>"
    //         newhtml += " <label >" + data[x].price + "</label><br>"
    //         newhtml += " <label >" + data[x].desc + "</label><br>"
    //         newhtml += "</div>     </div>     <br>      <hr>"
    //         console.log(data.price);
    //     }       
    // }
    
    // box2.insertAdjacentHTML("beforeend", newhtml);

    console.log(data)
}

function filterByPrice(e) {

//box.querySelectorAll('*').forEach(n => n.remove());
    e.preventDefault();

    var ourReq = new XMLHttpRequest();

    ourReq.open(
        "GET",
        "./cars.json"
    );
    var price = parseInt(document.getElementById('slideinput').value);
   // console.log(price)
let cars = new Array();
    ourReq.onprogress = function () {
        if (ourReq.status >= 200 && ourReq.status < 400) {
            var ourData = JSON.parse(ourReq.responseText);
           //console.log(ourData)
            for (var x in ourData) {
                
                    //console.log(ourData[x].price);
                   console.log(ourData[x])
                    //display2(ourData[x], price);
                    cars.push(ourData[x])
                
            }
        }
    }
    ourReq.send();

    display(cars, price);
}

