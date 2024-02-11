date=new Date();
function data()
{
let month=date.getMonth();
let day=date.getDate();
let year=date.getFullYear();
month++;
if(day<10)
day="0"+day;
if(month<10)
	month="0"+month;
let time="Сьогодні: "+day+"."+month+"."+year;
alert(time);
}
function time1()
{
let milsec=date.getTime();
alert("С початку машинного часу минуло "+milsec+" мілісекунд.");
}
function tim()
{
let hour=date.getHours();
let min=date.getMinutes();
let sec=date.getSeconds();
if(hour<10)
	hour="0"+hour;
if(min<10)
	min="0"+min;
if(sec<10)
	sec="0"+sec;
let time="Поточний час: "+hour+" : "+min+" : "+sec;
alert(time);
}
function day() 
{
let dat=date.getDay();
let days = ['Неділя', 'Понеділок', 'Вівторок', 'Среда', 'Четверг', 'П`ятниця', 'Субота'];//
alert(days[(dat)]);   
}
