import config from './config.js'

class canvas{
    height = config.canvasHeight;
    width = config.canvasWidth;
    mainCanvas = document.getElementById("mainCanvas");
    context = mainCanvas.getContext("2d");

    constructor(){
        console.log("hallo");
        this.mainCanvas.setAttribute("height",config.canvasHeight.toString());
        this.mainCanvas.setAttribute("width",config.canvasWidth.toString());
    }
}

export default new canvas();