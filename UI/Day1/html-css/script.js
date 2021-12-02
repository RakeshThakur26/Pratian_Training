// let form = document.getElementById("form");

// form.addEventListener("submit", myfun);

// function myfun(e){
//     e.preventDefault();
//     var id = document.getElementById("id").value;
//     var result = id.split(',').map((val) =>{
//         return val.trim();
//     });
   
//     var prodOfDigit = [];

//     result.map((val) => {

//         var product = 1;

//         while (val > 0) {

//             product *= val % 10;

//             val = Math.floor(val / 10);
//         }

//         prodOfDigit.push(product);

//     });
//     document.getElementById('result').textContent = prodOfDigit;

//     //alert(id);
// }


form = document.getElementById("empFormId");

form.addEventListener("submit", fun);

function fun(e) {
  e.preventDefault();
    var name =  document.getElementById("fullNameId").value;

    if(name){
       // alert("Valid name");
        document.getElementById("nameError").textContent = "";
    }else{
        document.getElementById("nameError").textContent = "Name is empty..";
    }



    var age =  document.getElementById("empAgeId").value;

    if(parseInt( age) > 25 && parseInt( age) < 75){
       // alert("Valid age");
        document.getElementById("ageError").textContent = "";
    }else{
        document.getElementById("ageError").textContent = "Age should be between 25 and 75";
    }


    var email =  document.getElementById("empMailId").value;

    if(email.includes("@")){
       // alert("Valid mail");
       document.getElementById("emailError").textContent = "";
    }else{
        document.getElementById("emailError").textContent = "Enter valid mail";
    }

    var pass =  document.getElementById("pass").value;
    var Cpass =  document.getElementById("Cpass").value;

    if(pass.length < 8){
        document.getElementById("passError").textContent = "Enter at least 8 characters";
    }else if(pass == Cpass){
        document.getElementById("passError").textContent = "";
        document.getElementById("CpassError").textContent = "";
       
    }
    else{
        document.getElementById("passError").textContent = "";
        document.getElementById("CpassError").textContent = "Password isn't matching";
    }


}