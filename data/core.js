import canvas from './game/canvas.js';
import object from './game/objects/object.js';
import script from './game/scripts/script.js';
import mainScenes from './game/scenes/mainScenes.js';

let interval ;
function draw() {
    mainScenes.onUpdate(interval);
}

interval = setInterval(draw, 10);