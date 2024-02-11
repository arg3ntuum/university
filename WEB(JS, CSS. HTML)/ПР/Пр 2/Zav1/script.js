let n;
function inp()
{
n=prompt("¬вед≥ть значенн€ ц≥лого позитивного числа N до пол€ форми ≥ натисн≥ть кнопку 'OK'");
}
function factorial(){
 let result = 1;
    while(n){
        result *= n--;
    }
alert("N!="+result)
}