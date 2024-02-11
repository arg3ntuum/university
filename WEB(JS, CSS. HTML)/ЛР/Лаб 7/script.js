let widthImg = 50;
let second = 0;
function info() {
    let information = "Зображеня: " + document.getElementById("Image").alt + ";\nШирина: " + document.getElementById("Image").width + " пікселів;\nВисота: " + document.getElementById("Image").height + " пікселів;\nВирівнювання: " + document.getElementById("Image").align + ";\nURL-адреса: " + document.getElementById("Image").src + ".";
    document.getElementById("pole_info").value = information;
}
function info_close() {
    document.getElementById("pole_info").value = "";
}
function increase_image() {
    if (widthImg == 800) {
        widthImg = 50;
        document.getElementById("Image1").style.width = widthImg + "px";
        document.getElementById("pole").value = "";
        second = 0;
    } else {
        increase();
    }
}
function increase() {
    widthImg = widthImg + 75;
    second++;
    document.getElementById("Image1").style.width = widthImg + "px";
    if (second < 10) { document.getElementById("pole").value = "0" + second; }
    else { document.getElementById("pole").value = second; }
    let time_iamge = setTimeout(increase, 1000);
    if (widthImg == 800) { clearTimeout(time_iamge); }
}
function Move() {
    second = 0;
    MoveUpRight();
    Timer();
}
function MoveUpRight() {
    document.getElementById("frog").style.right = 0 + "px";
    document.getElementById("frog").style.top = 0 + "px";
    if (second < 19) { setTimeout(MoveDownRight, 1000); }
}
function MoveDownRight() {
    document.getElementById("frog").style.right = 0 + "px";
    document.getElementById("frog").style.top = 350 + "px";
    setTimeout(MoveDownLeft, 1000);
}
function MoveDownLeft() {
    document.getElementById("frog").style.right = 850 + "px";
    document.getElementById("frog").style.top = 350 + "px";
    setTimeout(MoveUpLeft, 1000);
}
function MoveUpLeft() {
    document.getElementById("frog").style.right = 850 + "px";
    document.getElementById("frog").style.top = 0 + "px";
    setTimeout(MoveUpRight, 1000);
}
function Timer() {
    if (second < 10) { document.getElementById("pole").value = "0" + second; }
    else { document.getElementById("pole").value = second; }
    let time = setTimeout(Timer, 1000);
    second++;
    if (second == 21) {
        clearTimeout(time);
        document.getElementById("pole").value = "";
        second = 0;
    }
}