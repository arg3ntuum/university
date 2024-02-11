let znachenie;
function vvod(){
znachenie=prompt("Введіть значення числа А до поля форми і натисніть кнопку 'OK'");
}
function koren(){
if(znachenie<0){
alert("Error(Було введено від'ємне число)")
}
if(znachenie>=0){ 
alert("Корінь = "+Math.sqrt(znachenie));
}}
