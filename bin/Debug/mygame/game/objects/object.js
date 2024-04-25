$transform 

class object extends transform{
    name = "";
    id = "";
    sizeX = 0;
    sizeY = 0;
    gravity = 0;
    tipe = 0;

    constructor(id,name,sizeX,sizeY,x,y,tipe,gravity){
        super();
        this.id = id;
        this.name = name;
        this.sizeX = sizeX;
        this.sizeY = sizeY;
        this.x = x;
        this.y = y;
        this.gravity = gravity;
        this.tipe = tipe;
    }

    draw(canvas){
        if(this.y < canvas.height) this.y += this.gravity;
        canvas.context.beginPath();
        if(this.tipe==0)canvas.context.arc(this.x, this.y, this.sizeX, 0, Math.PI * 2);
        else if(this.tipe==1)canvas.context.rect(this.x, this.y, this.sizeX, this.sizeY);
        canvas.context.fillStyle = "#0095DD";
        canvas.context.fill();
        canvas.context.closePath();
    }

}

