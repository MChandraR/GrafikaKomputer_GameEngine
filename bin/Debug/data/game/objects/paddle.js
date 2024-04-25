import canvas from "../canvas.js";
import transform  from "./transform.js";

class paddle extends transform {
    name = "";
    id = "paddle";

    constructor(){
        super();
        this.sizeX = 75;
        this.sizeY = 10;
        this.x = this.sizeX /2;
        this.y = this.sizeY /2;
        console.log("im paddle");
    }

    draw(canvas){
        canvas.context.beginPath();
        canvas.context.rect(this.x, canvas.mainCanvas.height - this.sizeY, this.sizeX, this.sizeY);
        canvas.context.fillStyle = "#0095DD";
        canvas.context.fill();
        canvas.context.closePath();
    }
}

export default new paddle();