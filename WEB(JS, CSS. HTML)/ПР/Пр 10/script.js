function createmap(){
let map = document.createAttribute("usemap");
map.value = "#infographic";
document.getElementById("img1").setAttributeNode(map);
}
function view(){
    document.write("<!doctype html> <html> <meta charset='windows-1251' /> <style> body { background: url(https://s.zagranitsa.com/images/blogs/3336/original/b18d28b9341d08e2e95a22dd78a747a6.jpg?1477684813); background-repeat: no-repeat; background-size: 100%; } .base { width: 200mm; height: 160mm; background: #A66E53; border: solid 2mm #35223E; border-radius: 30px; position: absolute; top: 50%; left: 50%; margin-left: -100mm; margin-top: -90mm; text-align: center; } .txt { font: 15mm Comic Sans Ms; color: #E6E6FA; } textarea { width: 190mm; height: 30mm; font-size: 8mm; color: #35223E; background: transparent; border: transparent; } </style> <script src='script.js'></script> <body> <map> <area id='a1' /> <area id='a2' /> <area id='a3' /> </map> <div class='base'> <div class='txt'>Параметри області 1</div> <textarea id='info1' readonly></textarea> <div class='txt'>Параметри області 2</div> <textarea id='info2' readonly></textarea> <div class='txt'>Параметри області 3</div> <textarea id='info3' readonly></textarea> </div> </body> </html>");
    let area1=document.getElementById('a1');
    area1.shape='circle';
    area1.coords='500,200,200';
    area1.href='http://www.dnu.dp.ua'; 
    area1.alt='Кругова';
    let area2=document.getElementById('a2');    
    area2.shape='rect';
    area2.coords='800, 0, 1000, 200';
    area2.href='http://www.google.com';
    area2.alt='Прямокутна';
    let area3=document.getElementById('a3');     
    area3.shape='circle';
    area3.coords='0, 400, 200, 400, 0, 550';
    area3.href='http://www.i.ua';
    area3.alt='Трикутна';
    let inform1='Форма:'+area1.shape+'('+area1.alt+')\nКоординати:'+area1.coords+'\nURL:'+area1.href;
    let inform2='Форма:'+area2.shape+'('+area2.alt+')\nКоординати:'+area2.coords+'\nURL:'+area2.href;
    let inform3='Форма:'+area3.shape+'('+area3.alt+')\nКоординати:'+area3.coords+'\nURL:'+area3.href;
    document.getElementById('info1').value=inform1;
    document.getElementById('info2').value=inform2;
    document.getElementById('info3').value=inform3;
}