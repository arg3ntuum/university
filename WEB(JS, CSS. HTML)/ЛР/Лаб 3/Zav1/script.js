let znachenie = "", cifri_znach = "", vikon_koduv = 0;
function vvod(){
	znachenie=prompt("Уведіть текст і натисніть кнопку 'OK'");
}
function koduvannya(){
	vikon_koduv = 1;
	for (let i = 0; znachenie.length > i; i++){
		cifri_znach += znachenie.charCodeAt(i);
                cifri_znach += ' ';
	}
}
function vvivod(){
	if (vikon_koduv === 1)
		alert("Код: "+ cifri_znach);
	else if (znachenie === "")
		alert("Введіть рядок символів");
	else if (vikon_koduv === 0)
	alert("Кодування не було виконано");
}