let x;
function vvod()
{
x=prompt("¬вед≥ть значенн€ X до форми");
if(x == ''){
alert("”вед≥ть ц≥ле або д≥йсне число в поле форми в≥кна.");}
else if(isNaN(x) != 0){
alert("”вед≥ть ц≥ле або д≥йсне число в поле форми в≥кна.");}
else if(Math.sign(x) == 0 || Math.sign(x) == -1 || Math.sign(x) == -0){
alert("”вед≥ть не нульове ≥ не в≥д'Їмне число.")}
}
function log()
{
if(x == undefined){
alert("”вед≥ть число X.");}
else if(isNaN(x) == 0){
alert("logX = "+Math.log(x).toFixed(3));}
else if(isNaN(x) != 0){
alert("”вед≥ть ц≥ле або д≥йсне число в поле форми в≥кна.");}
}