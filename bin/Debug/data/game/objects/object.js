$transform 

class object extends transform{
    name = "";
    id = "";
    sizeX = 0;
    sizeY = 0;
    gravity = 0;

    constructor(id,name,sizeX,sizeY,x,y,gravity){
        super();
        this.id = id;
        this.name = name;
        this.sizeX = sizeX;
        this.sizeY = sizeY;
        this.x = x;
        this.y = y;
        this.gravity = gravity;
    }

    draw(canvas){
        if(this.y < canvas.height) this.y += this.gravity;
        canvas.context.beginPath();
        canvas.context.arc(this.x, this.y, this.sizeX, 0, Math.PI * 2);
        canvas.context.fillStyle = "#0095DD";
        canvas.context.fill();
        canvas.context.closePath();
    }

}
