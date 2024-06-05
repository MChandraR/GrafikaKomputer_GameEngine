$config 
const config = new confg();

class cnvs{
    height = config.canvasHeight;
    width = config.canvasWidth;
    mainCanvas = document.getElementById("mainCanvas");
    context = mainCanvas.getContext("2d");
    img = new Image();

    constructor(){
        console.log("hallo");
        this.mainCanvas.setAttribute("height",config.canvasHeight.toString());
        this.mainCanvas.setAttribute("width",config.canvasWidth.toString());
        //this.img.src = "game/asset/bg.jpg";
    }

    draw(){
        //this.context.drawImage(this.img, 0,0, this.width, this.height);
    }
}
