class gameobject{
    gameObjects = [];
    constructor(){
       this.objects = $object ;

       for(let idx in this.objects){
            let obj = this.objects[idx];
            console.log(obj);
            this.gameObjects[obj.id] = new object(obj.id, obj.name,obj.transform.xSize, obj.transform.ySize, obj.transform.x, parseFloat(obj.transform.y), obj.tipe, parseFloat(obj.gravity));
        }
    }
    
    collisionDetect(){
        for (let i = 0; i < this.gameObjects.length; i++) {
            for (let j = i + 1; j < this.gameObjects.length; j++) {
                let boxA = this.gameObjects[i];
                let boxB = this.gameObjects[j];
                
                let collisionX = boxA.x < boxB.x + boxB.sizeX && boxA.x + boxA.sizeX > boxB.x;
                let collisionY = boxA.y < boxB.y + boxB.sizeY && boxA.y + boxA.sizeY > boxB.y;
        
                if (collisionX && collisionY) {
                    console.log("nabrak");
                    let powerX = [
                        Math.abs(boxA.tempX - boxA.x),
                        Math.abs(boxB.tempX - boxB.x)
                    ];
                    let powerY = [
                        Math.abs(boxA.tempY - boxA.y),
                        Math.abs(boxB.tempY - boxB.y)
                    ];
                    boxA.colide = [true, true];
                    boxB.colide = [true, true];
        
                    let limitAX = boxA.x > boxB.x ? boxB.x + boxB.sizeX : boxB.x - boxA.sizeX;
                    let limitAY = boxA.y > boxB.y ? boxB.y + boxB.sizeY : boxB.y - boxA.sizeY;
        
                    boxA.colideLimit = [
                        (boxA.tempY + boxA.sizeY > boxB.tempY && boxB.tempY + boxB.sizeY > boxA.tempY) ? limitAX : boxA.tempX,
                        (boxA.tempX + boxA.sizeX > boxB.tempX && boxB.tempX + boxB.sizeX > boxA.tempX) ? limitAY : boxA.tempY
                    ];
        
                    let limitBX = boxB.x > boxA.x ? boxA.x + boxA.sizeX : boxA.x - boxB.sizeX;
                    let limitBY = boxB.y > boxA.y ? boxA.y + boxA.sizeY : boxA.y - boxB.sizeY;
        
                    boxB.colideLimit = [
                        (boxA.tempY + boxA.sizeY > boxB.tempY && boxB.tempY + boxB.sizeY > boxA.tempY) ? limitBX : boxB.tempX,
                        (boxA.tempX + boxA.sizeX > boxB.tempX && boxB.tempX + boxB.sizeX > boxA.tempX) ? limitBY : boxB.tempY
                    ];
                }
            }
        }
        
    }

    renderObjects(canvas){
        for(let tag in this.gameObjects){
            this.gameObjects[tag].draw(canvas);
        }
    }

    getgameobject(){
        return this.objects;
    }

    getGameObjectAt(idx){
        return this.gameObjects[idx];
    }

}
