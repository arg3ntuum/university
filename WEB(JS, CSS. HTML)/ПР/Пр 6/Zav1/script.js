let sec = 0, min = 0, hour = 0;
let Timer;
function starttimer()
{
Timer = setInterval(timeron,1000);
}
function timeron()
{
sec++;
if(sec == 60)
{
min++;
sec = 0;
}
if(min == 60)
{
hour++;
min = 0;
}
if(hour == 24)
{
hour = 0;
}
}

function stoptimer()
{
clearInterval(Timer);
if(sec < 10){sec="0"+sec}
if(min < 10){min="0"+min}
if(hour < 10){hour="0"+hour}
alert("×àñ: "+hour+" : "+min+" : "+sec+".");
sec = 0; 
min = 0;
hour = 0;
}