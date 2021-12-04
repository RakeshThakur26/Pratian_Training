

// function updateTextInput(val){    
//     document.getElementById('slidevalue').value = val;
//     console.log(val)
// }

// var data2 = getData();
// function getData() {
//     //e.preventDefault();
//   return  $.getJSON("cars.json", function (data) {
//         console.log(data);
//        //data;
//     });
// }
// console.log(data2)
// for(var i=0; i<data2.length; i++){
//     console.log(data2[i].carName)
// }


function getData() {
    var ourReq = new XMLHttpRequest();

    ourReq.open(
        "GET",
        "./cars.json"
    );

    ourReq.onload = function () {
        if (ourReq.status >= 200 && ourReq.status < 400) {
          var ourData = JSON.parse(ourReq.responseText);
            console.log(ourData);
            render(ourData);
        }     
    }

    ourReq.send();

    counter++;

    if(counter > 5)
        btn.style.display = "none";
}