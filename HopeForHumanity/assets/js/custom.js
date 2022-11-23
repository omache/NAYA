//Created by johnspax
function mySetDonation(amount) {
    document.getElementById("iAmount").value = "";
    document.getElementById("hfAmount").value = amount;
}
function validateForm() {
    //set error labels invisible
    document.getElementById("ddlType-error").style.display = "none";
    document.getElementById("fname-error").style.display = "none";
    document.getElementById("lname-error").style.display = "none";
    document.getElementById("email-error").style.display = "none";
    document.getElementById("phone-error").style.display = "none";
    document.getElementById("Address-error").style.display = "none";
    document.getElementById("message-error").style.display = "none";
    //decalare field variables
    var x = document.getElementById("iAmount").value;
    var y = document.getElementById("ddlType");
    var f = document.getElementById("fname").value;
    var l = document.getElementById("lname").value;
    var e = document.getElementById("email").value;
    var p = document.getElementById("phone").value;
    var a = document.getElementById("Address").value;
    var m = document.getElementById("message").value;
    if (x != "") {
        if (!isNumber(x)) {
            alert("Invalid donation amount!");
            return false;
        }
    }
    if (y.options[y.selectedIndex].value == "Type") {
        alert("Please select a donation type!");
        document.getElementById("ddlType-error").style.display = "block";
        return false;
    }
    if (f == "") {
        alert("First name cannot be empty!");
        document.getElementById("fname-error").style.display = "block";
        return false;
    }
    if (l == "") {
        alert("Last name cannot be empty!");
        document.getElementById("lname-error").style.display = "block";
        return false;
    }
    if (!isValidMail(e)) {
        alert("Invalid Email Address!");
        document.getElementById("email-error").style.display = "block";
        return false;
    }
    if (p == "") {
        alert("Phone cannot be empty!");
        document.getElementById("phone-error").style.display = "block";
        return false;
    }
    if (a == "") {
        alert("Address cannot be empty!");
        document.getElementById("Address-error").style.display = "block";
        return false;
    }
    if (m == "") {
        alert("Please type a message!");
        document.getElementById("message-error").style.display = "block";
        return false;
    }
}
function isNumber(n) {
    return !isNaN(parseFloat(n)) && isFinite(n);
}
function validateEmail() {
    if (!isValidMail(document.getElementById("subEmail").value)) {
        alert("Invalid email!");
        return false;
    } else {
        alert("Thank you for your subscription!");
        return true;
    }
}
function isValidMail(email) {
    var re = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    return re.test(email);
}

//Validate Volunteer form
function validateVolunteer() {
    //set error labels invisible    
    document.getElementById("fname-error").style.display = "none";
    document.getElementById("lname-error").style.display = "none";
    document.getElementById("email-error").style.display = "none";
    document.getElementById("phone-error").style.display = "none";
    document.getElementById("zip-error").style.display = "none";
    document.getElementById("message-error").style.display = "none";
    //decalare field variables
    var f = document.getElementById("fname").value;
    var l = document.getElementById("lname").value;
    var e = document.getElementById("email").value;
    var p = document.getElementById("phone").value;
    var z = document.getElementById("zip").value;
    var m = document.getElementById("message").value;
    //Actual vaildation
    if (f == "") {
        alert("First name cannot be empty!");
        document.getElementById("fname-error").style.display = "block";
        return false;
    }
    if (l == "") {
        alert("Last name cannot be empty!");
        document.getElementById("lname-error").style.display = "block";
        return false;
    }
    if (!isValidMail(e)) {
        alert("Invalid Email Address!");
        document.getElementById("email-error").style.display = "block";
        return false;
    }
    if (p == "") {
        alert("Phone cannot be empty!");
        document.getElementById("phone-error").style.display = "block";
        return false;
    }
    if (z == "") {
        alert("Zip Code cannot be empty!");
        document.getElementById("zip-error").style.display = "block";
        return false;
    }
    if (m == "") {
        alert("Please type a message!");
        document.getElementById("message-error").style.display = "block";
        return false;
    }
    alert("Thank you for your interest in helping us. We shall reach you via the email address you provided for more information!");
}

