$(document).ready(function () {
    $('#ads').append($('<img>', { id: 'img1', src: './assets/hyundai-creta.jpeg', width: "80%", height: "50%" }))

    

    var carsdata = $.getJSON("cars.json", function (data) {

        //let range = parseInt(document.getElementById('slideinput').value);

       for(var x=0; x<data.length; x++){
        //    console.log(data[i].carName)
            if(data[x].price < 1000000)
                display(data[x]);
                
       }
      return data;
        
    }).fail(function () {
        console.log("An error has occurred.");
    });

function display2(){
   // $('#ads').append($('<img>', { class: 'img1', src: 'https://th.bing.com/th/id/OIP.7EZwFz0WbJx9GLYg_cSrOgHaEK?pid=ImgDet&rs=1', width: "80%", height: "50%" }))
   

}

    function display(data){
        var htmlstring = "";
        htmlstring += "<div class=\"row\">";

        htmlstring += "<div class=\"col-5 card\"> <img class=\"rounded float-left img-fluid\" src=\"" + data.src + "\" alt=\"\"> </div>"
        htmlstring += "<div class=\"col-7\">";
        htmlstring += "<Label><h3>" + data.carName + "</h3></Label><br>"
        htmlstring += " <label >" + data.model + "</label><br>"
        htmlstring += " <label >" + data.price + "</label><br>"
        htmlstring += " <label >" + data.desc + "</label><br>"
        htmlstring += "</div>     </div>     <br>      <hr>"
        document.getElementById('box').insertAdjacentHTML("beforeend", htmlstring);
    }

    $("#slideinput").change(() => {
        let range = parseInt(document.getElementById('slideinput').value);

        var newData = carsdata.responseJSON;
        for(var j=0; j<newData.length; j++){
            console.log(newData[j].price)

        }

    });

    

});