
function colorBlue()
{
    document.body.style.background = "blue";
}
function colorRed()
{
    document.body.style.background = "red";
}
function colorYellow()
{
    document.body.style.background = "yellow";
}
function colorGreen()
{
    document.body.style.background = "green";
}
function picture()
{
    let fon=document.createAttribute("style");
    fon.value = 'background:url(https://focus.ua/static/storage/thumbs/920x465/4/06/39f2bade-723c57083305190737254934fe2a4064.jpeg?v=3358_1);background-size:cover';
    document.getElementById("bod").setAttributeNode(fon);
}
function named()
{
let name = window.document.title;
alert(name);
}
function url()
{
let url = window.document.URL;
alert(url);
} 
function color_txt()
{
let color1 = document.createAttribute("style");
color1.value="color:white;";
let zagolovok=document.getElementsByTagName("h1")[0];
zagolovok.setAttributeNode(color1);
}