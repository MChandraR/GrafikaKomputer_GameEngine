class gameobject{
    gameObjects = [];
    constructor(){
       this.objects = $object ;
       console.log(this.objects);

        for(let idx in this.objects){
            let obj = this.objects[idx];
            this.gameObjects[obj.id] = 
            new object(
                obj.id,
                obj.name,
                obj.transform.xSize, 
                obj.transform.ySize, 
                obj.transform.x, 
                parseFloat(obj.transform.y), 
                obj.tipe, 
                parseFloat(obj.gravity), 
                obj.absolute, 
                obj.collisionBlock, 
                obj.fill, 
                obj.audio.volume,
                obj.audio.loop,
                obj.audio.playAtStart,
                obj.audio.selectedTrack, 
                obj.audio.source,
                obj.texture
            );
        }
    }
    
    collisionDetect(){
        for (let i = 0; i < this.gameObjects.length; i++) {
            let boxA = this.gameObjects[i];
            boxA.col = [];
            for (let j = i + 1; j < this.gameObjects.length; j++) {
                let boxB = this.gameObjects[j];
                
                let collisionX = boxA.x < boxB.x + boxB.sizeX && boxA.x + boxA.sizeX > boxB.x;
                let collisionY = boxA.y < boxB.y + boxB.sizeY && boxA.y + boxA.sizeY > boxB.y;
        
                if (collisionX && collisionY && boxB.collisionBlock) {
                    boxA.colideObj.push(boxB);
                    boxA.col.push(boxB);
                    boxA.colid.push([collisionX, collisionY]);
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
