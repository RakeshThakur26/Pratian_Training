//1. 

var title = document.getElementById('headerTitle');

title.style.backgroundColor = "yellow";
title.style.borderBottom = "solid 5px #000";


//2. 

var items = document.getElementsByClassName('list-group-item');

for(var i=0; i<items.length; i++){
    if(items[i].textContent.includes("Veg")){      
        items[i].style.color = 'green';
    }
    else{
        items[i].style.color = 'red';
    }
}


//3. 

var form = document.getElementById('addForm');
var itemList = document.getElementById('items'); 

form.addEventListener('submit', addItem);

itemList.addEventListener('click', removeItem);


function addItem(ev){
    ev.preventDefault();
    var newItem = document.getElementById('newitem').value;

    var li = document.createElement('li');
    li.className = "list-group-item";
    li.appendChild(document.createTextNode(newItem));
    
    var deleteBtn = document.createElement('button');
    deleteBtn.className = 'btn btn-danger float-right btn-sm delete';

    deleteBtn.appendChild(document.createTextNode('X'));
    
    li.appendChild(deleteBtn);

    var price = document.createElement('span');
    price.className = 'float-right';
    price.id = 'price-item';
    price.style = 'margin-right: 100px;'
    price.appendChild(document.createTextNode('180'));
    
    li.appendChild(price);
    
    itemList.appendChild(li);
    totalItem.textContent = parseInt(totalItem.textContent) + 1;
   
    var newprice = parseInt(document.getElementById('totalAmount').innerHTML) + 180;
    document.getElementById('totalAmount').innerHTML = newprice;
}

function removeItem(e){
    if(e.target.classList.contains('delete')){
        if(confirm('Are You Sure?')){
            newprice = parseInt(document.getElementById('totalAmount').innerHTML)- 100;
            var li = e.target.parentElement;
            itemList.removeChild(li);
            totalItem.textContent -= 1;
            document.getElementById('totalAmount').innerHTML = newprice;
        }
    }
}


//4. 

var oddItems = document.querySelectorAll('.list-group-item:nth-child(odd)');

for(var i=0; i<oddItems.length; i++){
   oddItems[i].style.backgroundColor = 'lightgray';
}


//5. 

var itemPrices = document.querySelectorAll('#price-item');
var totalItem = document.querySelector('.total-item');

for(var count=0; count<itemPrices.length; count++){
    if(parseInt(itemPrices[count].textContent)>=200){
        let finalPrice = parseInt(itemPrices[count].textContent) - (parseInt(itemPrices[count].textContent)*0.1);
        itemPrices[count].textContent = finalPrice;
    }
}

totalItem.textContent = count; 



//6.

var tipAmount = document.getElementById('tipAmount');

var add = (function () {
    return function () {
        return parseInt(parseInt(tipAmount.textContent))+1;
    }
})();
  
function addTip(){
    tipAmount.innerHTML = add();
    newprice = parseInt(document.getElementById('totalAmount').innerHTML) + 180;
    document.getElementById('totalAmount').innerHTML = newprice;
    priceCalculation(priceItems, priceDisplay);
}

var subtract = (function () {
    return function () {
        return parseInt(parseInt(tipAmount.textContent))-1;
    }
})();
  
function subtractTip(){
    tipAmount.innerHTML = subtract();
    priceCalculation(priceItems, priceDisplay);
}



//7. 

var priceItems = document.querySelectorAll('#price-item');
function priceDisplay(amount){
    document.getElementById('totalAmount').innerHTML = amount;
}

function priceCalculation(priceItems, myCallback){
    var totalprice = 0;
    for(var i=0; i<priceItems.length; i++){
        totalprice += parseInt(priceItems[i].textContent);
    }

    totalprice += parseInt(document.getElementById('tipAmount').textContent);
    myCallback(totalprice);
}

priceCalculation(priceItems, priceDisplay);



//8.

var items = document.getElementsByClassName('list-group-item');
function displayItemMessage(msg) {
    document.getElementById('warning-mess').innerHTML = msg;
}

let myPromise = new Promise(function(myResolved, myRejected) {
    let checkVeg = true;
    for(var i=0; i<items.length; i++){
        if(!items[i].textContent.includes("Veg")) {
            checkVeg = false;
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



//9. 

var form = document.getElementById('ratingForm');
form.addEventListener('submit', rateFunction);

async function rateFunction(e) {
    e.preventDefault();

    var select = document.getElementById('ratingId');

    let myPromise = new Promise(function(myResolve, myReject) {
        if(parseInt(select.value)>3) {
            myResolve('Thank You');
        } else {
            myReject('Sorry for Inconvenience');
        }
    });

    document.getElementById('rateMessage').innerHTML = await myPromise;
}

