var current_rotation = 0;
i.addEventListener("mousemove", setTimeout(go(), 10));
function go() {
    document.querySelector("#rotate-button").addEventListener('click', function () {
        current_rotation += 1;
        document.querySelector("#sample").style.transform = 'rotate(' + current_rotation + 'deg)';
    }
    );
}
function stop(){
    
}