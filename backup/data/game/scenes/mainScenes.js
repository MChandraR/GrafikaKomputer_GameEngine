$canvas
$gameObject
$objects
const canvas = new cnvs();
const gameobjects = new gameobject();

class mainScene{
    mainCanvas = canvas.mainCanvas;
    gobj = [];
    gameObjects = {};

    constructor(){
        this.gobj = gameobjects.getgameobject();
        for(let idx in this.gobj){
            let obj   = this.gobj[idx];
            this.gameObjects[obj.id] = new object(obj.id, obj.name,obj.transform.xSize, obj.transform.ySize, obj.transform.x, obj.transform.y);
        }
        console.log(this.gameObjects);
    }

    onUpdate(interval){
        for(let tag in this.gameObjects){
            this.gameObjects[tag].draw(canvas);
        }
        clearInterval(interval);
    }

    getGameObject(id){
        
    }
}

