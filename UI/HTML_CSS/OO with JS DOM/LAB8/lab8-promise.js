//8. [Promise] Use promise to show a warning message if item contain one or more Non-Veg Item

//Step1: Get all the items. (Note: Class name of li items is 'list-group-item').
var items = document.getElementsByClassName('list-group-item');

//Step2: Create the function displayItemMessage(someMsg) for displaying 
//the warning message in div with id 'warning-mess'.
//Write code here
function displayItemMessage(msg) {
    document.getElementById('warning-mess').innerHTML = msg;
}

//Step3: Create a promise where declare a boolean variable 'checkVeg'. Iterate through the items and if any item doesn't have "Veg" in it then set 'checkVeg' as false.
//Write code here
let myPromise = new Promise(function(myResolved, myRejected) {
    let checkVeg = true;
    for(var i=0; i<items.length; i++){
        if(!items[i].textContent.includes("Veg")) {
            checkVeg = false;
            break;
        }
    }

    if(checkVeg) {
        myResolved("It doesnot contain any Non-Veg Item");
    } else {
        myRejected("Warning! It contains one or more Non-Veg Item");
    }
});

myPromise.then(
    function(value) {
        displayItemMessage(value);
    },
    function(error) {
        displayItemMessage(error);
    }
)

//Step4: If promise is fulfilled the pass "It doesnot contain any Non-Veg Item" to the function created in step2 otherwise pass error message "Warning! It contains one or more Non-Veg Item".
//Write code here


// 3 states: initial, resolved, rejected