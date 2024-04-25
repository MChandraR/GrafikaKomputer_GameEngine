class transform{
    sizeX = 0;
    sizeY = 0;
    x = 0;
    y = 0;

    constructor(){
        this.x = 0;
        this.y = 0;
    }

    move(x,y){
        this.x -= x;
        this.y -= y;
    }

}

export default transform;