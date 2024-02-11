let second = 0;
let size = 0;
let op = 1.0;
let x = 0, y = 0;
function backgr(){
    changeBackGround();
    timer();
}
function changeBackGround(){
    if(size <= 100){
        size = size+0.1;
        document.body.style.backgroundSize = size+"%";
    }else{clearTimeout(fon)}
    let fon = setTimeout(changeBackGround,10);
    document.body.style.backgroundImage = "url(https://assets2.rockpapershotgun.com/the-witcher-3-best-rpgs.jpg/BROK/resize/1920x1920%3E/format/jpg/quality/80/the-witcher-3-best-rpgs.jpg)";    
}
function timer(){
    let time = setTimeout(timer,1000);
    document.getElementById("shape").value = second+" c";
    second++;
    if(size >= 100){
        clearTimeout(time);
        second=0;
        document.getElementById("shape").value = second+" c";
    }
    if(second == 0){
        image();
        timer_1();
    }
}
function image(){
    document.getElementById("image").style.opacity=op;
    op = op - 0.1;
    let time1 = setTimeout(image, 1000);
    if(op <= 0){clearTimeout(time1)}
    
}
function timer_1(){
    let time = setTimeout(timer_1,1000);
    document.getElementById("shape").value = second+" c";
    second++;
    if(op <= 0){
        clearTimeout(time);
        second = 0;
        document.getElementById("shape").value = second+" c";
    }
}
function anuranjump(){
    jump();
    timer_2();
}
function jump(){
    let jaba =  document.getElementById("anuran");
    jaba.style.left = x+"%";
    jaba.style.bottom = y+"%";
    x = x + 5;
    let x1 = (2*Math.PI*x)/10;
    y = Math.abs(50*Math.sin(x1.toFixed(0)));
    let stopjump = setTimeout(jump,1000);
    if(x >= 92){clearTimeout(stopjump);
        jaba.style.left = 91+"%";
        jaba.style.bottom = 1+"%";}
}
function timer_2(){
    let time = setTimeout(timer_2,1000);
    document.getElementById("shape").value = second+" c";
    second++;
    if(x >= 95){
        clearTimeout(time);
        second = 0;
        document.getElementById("shape").value = second+" c";
    }
}
function anuran(){
    x = 0; y = 0; op = 1;
    document.getElementById("image").style.opacity = op;
    document.getElementById("anuran").style.left = x;
    document.getElementById("anuran").style.bottom = y;
}
