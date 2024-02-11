let x = 50;
let prov = 0;
function openAlbum() {
    if (prov == 0) {
        x = x - 4;
        let start = document.getElementById("start");
        start.style.left = x + "%";
        let open = setTimeout(openAlbum, 500)
        if (x == 18) {
            clearTimeout(open);
            prov = 1;
            x = 50;
            start.style.zIndex = "-6";
        }
    }
}
function firstPhoto() {
    if (prov == 1) {
        x = x - 4;
        let firstphoto = document.getElementById("image1");
        firstphoto.style.left = x + "%";
        let first = setTimeout(firstPhoto, 500)
        if (x == 18) {
            clearTimeout(first);
            prov = 2;
            x = 50;
            firstphoto.style.zIndex = "-5";
        }
    }
}
function secondPhoto() {
    if (prov == 2) {
        x = x - 4;
        let secondphoto = document.getElementById("image2");
        secondphoto.style.left = x + "%";
        let second = setTimeout(secondPhoto, 500)
        if (x == 18) {
            clearTimeout(second);
            prov = 3;
            x = 50;
            secondphoto.style.zIndex = "-4";
        }
    }
}
function threePhoto() {
    if (prov == 3) {
        x = x - 4;
        let threephoto = document.getElementById("image3");
        threephoto.style.left = x + "%";
        let three = setTimeout(threePhoto, 500)
        if (x == 18) {
            clearTimeout(three);
            prov = 4;
            x = 50;
            threephoto.style.zIndex = "-3";
        }
    }
}
function fourPhoto() {
    if (prov == 4) {
        x = x - 4;
        let fourphoto = document.getElementById("image4");
        fourphoto.style.zIndex = "-2";
        fourphoto.style.left = x + "%";
        let four = setTimeout(fourPhoto, 500)
        if (x == 18) {
            clearTimeout(four);
            prov = 5;
            x = 50;
        }
    }
}
function closeAlbum() {
    if (prov == 5) {
        x = x - 4;
        let konec = document.getElementById("konec");
        konec.style.zIndex = "-1";
        konec.style.left = x + "%";
        let close = setTimeout(closeAlbum, 500)
        if (x == 18) {
            clearTimeout(close);
            prov = 6;
            x = 50;
        }
    }
}
function restAlbum() {
    if (prov == 6) {
        document.getElementById("start").style.zIndex = "-1";
        document.getElementById("start").style.left = x + "%";
        document.getElementById("image1").style.zIndex = "-2";
        document.getElementById("image1").style.left = x + "%";
        document.getElementById("image2").style.zIndex = "-3";
        document.getElementById("image2").style.left = x + "%";
        document.getElementById("image3").style.zIndex = "-4";
        document.getElementById("image3").style.left = x + "%";
        document.getElementById("image4").style.zIndex = "-5";
        document.getElementById("image4").style.left = x + "%";
        document.getElementById("konec").style.zIndex = "-6";
        document.getElementById("konec").style.left = x + "%";
        prov = 0;
    } else { alert("Закінчіть перегляд альбому!") }
}