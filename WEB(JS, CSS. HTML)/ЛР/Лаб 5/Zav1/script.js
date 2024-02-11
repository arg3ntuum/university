let str = "";
let Np, Nr, Na, Nb, Nv, Ng;
function input(){
do{
str = prompt("Введіть фрагмент тексту до поля форми");
if(str === "")
{
alert("Введіть фрагмент текст до поля форми.");
}
}while(str === "");
}
function analis(){
let L = str.length;
Np = 0;
Nr = 0; 
Na = 0; 
Nb = 0; 
Nv = 0; 
Ng = 0;
for(let i = 0;i <= L;i++){
let str2 = str.charAt(i);
if(str2 === ' ')
Np++;
if(str2 === '.')
Nr++;
if(str2 === 'А' || str2 === 'а')
Na++;
if(str2 === 'Б' || str2 === 'б')
Nb++;
if(str2 === 'В' || str2 === 'в')
Nv++;
if(str2 === 'Г' || str2 === 'г')
Ng++;
}
alert("Кількість символів у введеному фрагменті тексту: "+L);
alert("Кількість слів в тексті: "+Np);
alert("Кількість речень в тексті: "+Nr);
alert("Кількість літер а в тексті: "+Na);
alert("Кількість літер б в тексті: "+Nb);
alert("Кількість літер в в тексті: "+Nv);
alert("Кількість літер г в тексті: "+Ng);
}
function create_table(){
let Len = str.length;
let va = (Na/Len).toFixed(3), vb = (Nb/Len).toFixed(3), vv = (Nv/Len).toFixed(3), vg = (Ng/Len).toFixed(3);
document.write("<html><head><style>table{width:400px;border:solid 5px #292442; background:#ffeedd;position:absolute;top:35%;left:40%;border-radius:30px;}th{width:200px;font:bold 30px Arial;color:#000060;border-radius:11px; }</style></head><body style='background:#9887EF;background-size:cover'>");
document.write("<h1 style='font:15mm Arial;color:white; position:absolute;top:10%;left:10%'>Таблиця ймовірності появи літер в тексті</h1>");
document.write("<table border cellspacing=0 style='left:35%;'> ");
document.write("<tr><th>Літера</th><th>Ймовірність</th></tr>");
document.write("<tr><th>а</th><th>"+va+"</th></tr>");
document.write("<tr><th>б</th><th>"+vb+"</th></tr>");
document.write("<tr><th>в</th><th>"+vv+"</th></tr>");
document.write("<tr><th>г</th><th>"+vg+"</th></tr>");
document.write("</table></body></html>");
}