$mainScene

const mainScenes = new mainScene();

let interval ;
mainScenes.setUp();
function draw() {
    mainScenes.onUpdate();
    requestAnimationFrame(draw);
}

draw();
// interval = setInterval(draw, 10);