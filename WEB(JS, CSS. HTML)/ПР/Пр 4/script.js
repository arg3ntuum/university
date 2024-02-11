let matrix=new Array(3);
     for(let i=0;i<3;i++){
		matrix[i]=new Array();
	 }
let k = 0;

function matrix2vim() {
	k = 1;
	for (let i = 0;i < 3;i++){
		for(let j = 0;j < 3;j++){
			matrix [i][j] = getRandom(0, 10);
		}
	}
}

function matrix1vim() {
	if (k === 1){
	k = 2;
	for (let i = 0;i < 3;i++){
		join(matrix [i]);
	}
	}
	else if (k === 0)
		alert("Натисніть на кнопку 'Створити двомірний масив (матрицю)'");
}

function getRandom(min, max) {
	return (Math.random() * (max - min) + min).toFixed(0);
}

function vvivod () {
	if (k != 2)
		alert("Натисніть на кнопку 'Створити одномірний масив'");
	else 
	{
		k=0;
		for (let i = 0; i < 3;i++) {
		alert("Рядок " + i + ": " + matrix [i]);
		}
	}
}
