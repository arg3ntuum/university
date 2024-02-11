let a=""; let b="";//Змінні операндів арифметичних операцій
let k=0;//Допоміжна змінна для контролю натискання клавіші "="
let rez;//Змінна результату виконання арифметичної операції
let p;//Оголошує змінну формального параметра функції
let op;//Змінна типу арифметичної операції

//Функція уведення операндів a і b
function vv(p){
//Оголошує посилальне ім'я на поле форми для виводу значень операндів і результату операції
let disp=document.getElementById("dd");
//Вводить операнд а
if(k==0){a=a+p;disp.value=a};
//Вводить операнд b
if(k==1){b=b+p;disp.value=b}
};
//Функції арифметичних операцій над операндами a і b
//Складання
function sum(){
if(a==""){alert("Уведіть перший операнд а і потім натисніть кнопку із знаком арифметичної операції")}
else{
document.getElementById("dd").value=""; 
op="summa";
k=1}
};
//Множення
function mul(){
if(a==""){alert("Уведіть перший операнд а і потім натисніть кнопку із знаком арифметичної операції ")}
else{
document.getElementById("dd").value=""; 
op="multip";
k=1}
};
function dif(){
if(a==""){alert("Уведіть перший операнд а і потім натисніть кнопку із знаком арифметичної операції ")}
else{
document.getElementById("dd").value=""; 
op="diferent";
k=1}  
}
function dil(){
if(a==""){alert("Уведіть перший операнд а і потім натисніть кнопку із знаком арифметичної операції ")}
else{
document.getElementById("dd").value=""; 
op="dilen";
k=1}  
}
//Видаляє цифру молодшого розряду операнду
function kor(){
let l=a.length; l=l-1;
a=a.substring(0,l);
document.getElementById("dd").value=a};
//Функція розрахунку арифметичної операції
function det(){
if(op=="summa"){rez=1*a+1*b;document.getElementById("dd").value=rez};
if(op=="diferent"){rez=1*a-1*b;document.getElementById("dd").value=rez};
if(op=="multip"){rez=a*b;document.getElementById("dd").value=rez};
if(op=="dilen"){rez=a/b;document.getElementById("dd").value=rez}
};
function cle(){
a=""; b="";
document.getElementById("dd").value="";
k=0
};
function clockTimer()
{
  let date = new Date();
  
  let time = [date.getHours(),date.getMinutes(),date.getSeconds()]; // |[0] = Hours| |[1] = Minutes| |[2] = Seconds|
  
  if(time[0] < 10){time[0] = "0"+ time[0];}
  if(time[1] < 10){time[1] = "0"+ time[1];}
  if(time[2] < 10){time[2] = "0"+ time[2];}
  
  let time_1 = [time[0],time[1],time[2]].join(':');
  let clock = document.getElementById("clock");

  clock.innerHTML = time_1;

  setTimeout("clockTimer()", 1000);
}    