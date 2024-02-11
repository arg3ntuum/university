date=new Date();
let win, second = 0;
setTimeout(zapysk, 5000);
let Timer = setInterval(time, 1000)
function zapysk()
{
let dat=date.getDay();
let year = date.getFullYear();
let months = date.getMonth();
let day = date.getDate();
if(day<10)
{day = "0"+day}
if(months<10){months = "0"+months}
let days = ['Неділя', 'Понеділок', 'Вівторок', 'Среда', 'Четверг', 'П`ятниця', 'Субота']; 
alert("Сьогодні "+days[(dat)]+" "+day+"."+months+"."+year);
setTimeout(openwindow, 10000);
}
function openwindow()
{
    win = window.open("https://ictnews.uz/wp-content/uploads/2018/11/2018-11-01-18_51_23-8_2018.pdf-Adobe-Acrobat-Reader-DC.png","win","width=500,height=400,left=550,top=100");
}
function closewindow()
{
    win.close();
    clearInterval(Timer);
}
function time()
{
second++;
}