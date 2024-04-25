$mainScene

const mainScenes = new mainScene();

let interval ;
function draw() {
    mainScenes.onUpdate(interval);
}

interval = setInterval(draw, 10);