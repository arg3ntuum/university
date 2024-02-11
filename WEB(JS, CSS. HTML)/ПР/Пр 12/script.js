let T;
let y = -100;
let yd;
let x;
function fon() {
    if (y == -100) {
        document.getElementById("block1").style.visibility = "hidden";
        document.getElementById("block2").style.visibility = "hidden";
        document.getElementById("block3").style.visibility = "hidden";
        document.getElementById("block4").style.visibility = "hidden";
        document.getElementById("block5").style.visibility = "hidden";
    }
    let fon = document.getElementById("shtorka");
    yd = y + "%";
    fon.style.backgroundColor = "#001F31";
    fon.style.backgroundSize = "100%";
    fon.style.backgroundRepeat = "no-repeat";
    fon.style.backgroundPosition = "0px" + " " + yd;
    fon.style.backgroundImage = "url(https://i.pinimg.com/originals/f6/20/a1/f620a179ca1acfd15a0754701677fb58.jpg)";
    y = y + 0.1;
    if (y <= 0) { T = setTimeout("fon()", 10) }
    else { clearTimeout(T) }
}
function block_sin() {
    document.getElementById("block1").style.visibility = "visible";
    document.getElementById("block2").style.visibility = "hidden";
    document.getElementById("block3").style.visibility = "hidden";
    document.getElementById("block4").style.visibility = "hidden";
    document.getElementById("block5").style.visibility = "hidden";
    skid();
}
function block_cos() {
    document.getElementById("block1").style.visibility = "hidden";
    document.getElementById("block2").style.visibility = "visible";
    document.getElementById("block3").style.visibility = "hidden";
    document.getElementById("block4").style.visibility = "hidden";
    document.getElementById("block5").style.visibility = "hidden";
    skid();
}
function block_ln() {
    document.getElementById("block1").style.visibility = "hidden";
    document.getElementById("block2").style.visibility = "hidden";
    document.getElementById("block3").style.visibility = "visible";
    document.getElementById("block4").style.visibility = "hidden";
    document.getElementById("block5").style.visibility = "hidden";
    skid();
}
function block_e() {
    document.getElementById("block1").style.visibility = "hidden";
    document.getElementById("block2").style.visibility = "hidden";
    document.getElementById("block3").style.visibility = "hidden";
    document.getElementById("block4").style.visibility = "visible";
    document.getElementById("block5").style.visibility = "hidden";
    skid();
}
function block_random() {
    document.getElementById("block1").style.visibility = "hidden";
    document.getElementById("block2").style.visibility = "hidden";
    document.getElementById("block3").style.visibility = "hidden";
    document.getElementById("block4").style.visibility = "hidden";
    document.getElementById("block5").style.visibility = "visible";
}
function sin_kyta() {
    x = document.getElementById("pole1").value;
    if (x == "" || isNaN(x)) { document.getElementById("pole2").value = "Помилка"; }
    else {
        x = (x * Math.PI) / 180;
        let sin = Math.sin(x);
        document.getElementById("pole2").value = sin.toFixed(4);
    }
}
function cos_kyta() {
    x = document.getElementById("pole3").value;
    if (x == "" || isNaN(x)) { document.getElementById("pole4").value = "Помилка"; }
    else {
        x = (x * Math.PI) / 180;
        let cos = Math.cos(x);
        document.getElementById("pole4").value = cos.toFixed(4);
    }
}
function natural_logarifm() {
    x = document.getElementById("pole5").value;
    if (x <= 0 || x == "" || isNaN(x)) { document.getElementById("pole6").value = "Помилка"; }
    else { document.getElementById("pole6").value = Math.log(x).toFixed(4); }
}
function e_stepenx() {
    x = document.getElementById("pole7").value;
    if (isNaN(x)) { document.getElementById("pole8").value = "Помилка"; }
    else { document.getElementById("pole8").value = Math.exp(x).toFixed(4); }
}
function random_number() {
    document.getElementById("pole9").value = (Math.random() * 11).toFixed(0);
}
function skid() {
    x = "";
    document.getElementById("pole1").value = "";
    document.getElementById("pole2").value = "";
    document.getElementById("pole3").value = "";
    document.getElementById("pole4").value = "";
    document.getElementById("pole5").value = "";
    document.getElementById("pole6").value = "";
    document.getElementById("pole7").value = "";
    document.getElementById("pole8").value = "";
    document.getElementById("pole1").focus();
    document.getElementById("pole3").focus();
    document.getElementById("pole5").focus();
    document.getElementById("pole7").focus();
}