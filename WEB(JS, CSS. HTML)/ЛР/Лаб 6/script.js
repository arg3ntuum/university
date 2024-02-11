let parol = "1", login = "2";
alert("log = " + login + " pass = " + parol)
function writeLog() {
    let pass = document.getElementById("pass").value;
    let log = document.getElementById("log").value;
    let check = document.getElementById("check").checked;
    if (log != login || log == "") {
        alert("Не уведений або не коректний логин.");
        document.getElementById("log").focus();
    }
    else if (check == true && log == login) {
        let createAtributStyle = document.createAttribute("style");
        createAtributStyle.value = "visibility:visible;";
        document.getElementById("writer").setAttributeNode(createAtributStyle);
    }
    else if (pass != parol || pass == "") {
        alert("Не уведений або не коректний пароль. Введіть пароль.");
        document.getElementById("pass").focus();
    }
    else {
        let createAtributStyle = document.createAttribute("style");
        createAtributStyle.value = "visibility:visible;";
        document.getElementById("writer").setAttributeNode(createAtributStyle);
    }
}
function poshtovaSkrinka() {
    document.getElementById("otrumyvach").value = document.getElementById("otpravit").value;
}
function zafokusit() {
    document.getElementById("log").focus();
    let createAtributStyle = document.createAttribute("style");
    createAtributStyle.value = "visibility:hidden;";
    document.getElementById("writer").setAttributeNode(createAtributStyle);
}
