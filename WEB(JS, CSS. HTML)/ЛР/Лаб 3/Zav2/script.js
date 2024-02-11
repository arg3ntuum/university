let pass_koded = "", your_pass = "";
function vvod(){
	let pass=prompt("Уведіть новий пароль і натисніть кнопку 'OK'");
	if (pass === "") {
		alert("Введіть пароль!!!");
	}
	for (let i = 0; pass.length > i; i++){
		pass_koded += pass.charCodeAt(i);
	}
}
function check(){
	let pass=prompt("Уведіть дійсний пароль і натисніть кнопку 'OK'");
	if (pass === "")
		alert("Введіть пароль!!!");
	for (let i = 0; pass.length > i; i++){
		your_pass += pass.charCodeAt(i);
	}
	if (pass_koded === your_pass)
		alert("Є доступ !!!");
	else alert("Нема доступу !!!");
}