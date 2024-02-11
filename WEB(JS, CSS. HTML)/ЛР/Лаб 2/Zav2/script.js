let min=1;
let max=1000;
function random() {
let result = Math.random() * (max - min) + min;
alert("Випадкове число = "+result.toFixed(0));
}
