let x = 0, y = 0;
let degree = 0;
let second = 0;
let protect = 0;
let prov = 0;
function down() {
    if (protect == 2) {
        alert("Помилка! Зачекайте поки м'яч доскаче до правої стіни.");
    } else {
        protect = 1;
        document.getElementById("txt").style.transform = "skewX(" + degree + "deg)";
        degree = degree + 5;
        timer = setTimeout(down, 1000);
        if (second < 10) { 
            document.getElementById("time").value = "0" + second; 
        }
        else {
            document.getElementById("time").value = second; }
            second++;
        if (degree == 60) {
            clearTimeout(timer);
            document.getElementById("time").value = "00";
            protect = 0;
            degree = 0;
            second = 0;
        }
    }
}
function jumpBall() {
    if (protect != 2 && protect != 1) {
        
        jump();
    } else {
        alert("Помилка! Зачекайте завершення дії.");
    }
}
function jump() {
    protect = 2;
    document.getElementById("ball").style.left = x + "%";
    document.getElementById("ball").style.bottom = y + "%";
    document.getElementById("ball").style.transform = "rotate(" + degree + "deg)";
    degree = degree + 90;
    x = x + 10;
    if (y == 75) {
        prov = 1;
        y = y - 25;
    }
    else if (y == 0) {
        prov = 0;
        y = y + 25;
    }
    else if (y < 75 && prov == 0) {
        y = y + 25;
    } else if (y > 0 && prov == 1) {
        y = y - 25;
    }
    if (second < 10) { document.getElementById("time").value = "0" + second; }
    else { 
        document.getElementById("time").value = second; }
    second++;
    let jump_ball = setTimeout(jump, 1000);
    if (x > 100) {
        clearTimeout(jump_ball);
        degree = 0;
        protect = 0;
        document.getElementById("ball").style.left = 94 + "%";
        document.getElementById("ball").style.right = 0 + "%";
        document.getElementById("ball").style.bottom = 0 + "%";
        document.getElementById("time").value = "00";
        document.getElementById("ball").style.transform = "rotate(" + degree + "deg)";
        second = 0;
    }
}
function restBall() {
    if (protect == 0) {
        x = 0;
        y = 0;
        second = 0;
        document.getElementById("ball").style.left = x + "%";
        document.getElementById("ball").style.bottom = y + "%";
    } else {
        alert("Помилка! Зачекайте поки м'яч доскаче до правої стіни.");
    }
}