let windows;
function openwindow()
{
 windows = window.open("window.html", "windows", "width = 1000px,height = 500px");
}

function closewindow()
{
 windows.close();
}

function sinu()
{
let sinux, x = '', podtv;
 podtv = confirm("Виконати обчислення синусу ?");
 if(podtv == true)
 {
 x = prompt("Введіть значення кута в градусах в поле форми:");
  if(x == ''|| isNaN(x) !=0)
  alert("Значення кута не уведено або ви ввели букву чи символ.");
  else
  {
  sinux = Math.sin(x);
  alert("Синус ="+sinux.toFixed(4));
  } 
 }
}