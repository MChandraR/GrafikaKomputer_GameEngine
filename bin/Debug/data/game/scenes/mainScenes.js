$canvas
$gameObject
$inputs
$objects
const canvas = new cnvs();
const gameobjects = new gameobject();
$script
let scripts = new script();
let gameObjects = {};

class mainScene{
    mainCanvas = canvas.mainCanvas;
    gobj = [];

    constructor(){
        this.gobj = gameobjects.getgameobject();
        for(let idx in this.gobj){
            let obj = this.gobj[idx];
            gameObjects[obj.id] = new object(obj.id, obj.name,obj.transform.xSize, obj.transform.ySize, obj.transform.x, obj.transform.y, obj.gravity);
        }
        console.log(gameObjects);
    }

    onUpdate(interval){
        canvas.context.clearRect(0, 0, canvas.width, canvas.height);
        for(let tag in gameObjects){
            gameObjects[tag].draw(canvas);
        }
        scripts.onUpdate();
        //clearInterval(interval);
    }

    getGameObject(id){
        
    }
}

