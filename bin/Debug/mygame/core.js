class confg{
    canvasHeight = window.innerHeight;
    canvasWidth =  window.innerWidth;
}
 
const config = new confg();

class cnvs{
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

class gameobject{
    constructor(id,name,sizeX,sizeY,x,y){
       this.objects = [{"id":"0","name":"Game Object 0","type":"1","gravity":"0.3","tipe":0,"transform":{"x":0.0,"y":5.0,"xSize":12.0,"ySize":50.0}},{"id":"1","name":"Game Object 1","type":"1","gravity":"0","tipe":1,"transform":{"x":0.0,"y":5.0,"xSize":100.0,"ySize":50.0}}] ;
    }
    

    getgameobject(){
        return this.objects;
    }

    getGameObjectAt(idx){
        return this.objects[idx];
    }

}



class input{
    keyUp = {};
    keyDown = {};
    space = String.fromCharCode(32);

    constructor(){
        document.addEventListener("keydown", this.keyDownHandler.bind(this), false);
        document.addEventListener("keyup", this.keyUpHandler.bind(this), false);
        this.keyUp['a'] = 0;
        this.keyUp['b'] = 0;
        this.keyUp['c'] = 0;
        this.keyUp['d'] = 0;
        this.keyUp['e'] = 0;
        this.keyUp['f'] = 0;
        this.keyUp['g'] = 0;
        this.keyUp['h'] = 0;
        this.keyUp['i'] = 0;
        this.keyUp['j'] = 0;
        this.keyUp['k'] = 0;
        this.keyUp['l'] = 0;
        this.keyUp['m'] = 0;
        this.keyUp['n'] = 0;
        this.keyUp['o'] = 0;
        this.keyUp['p'] = 0;
        this.keyUp['q'] = 0;
        this.keyUp['r'] = 0;
        this.keyUp['s'] = 0;
        this.keyUp['t'] = 0;
        this.keyUp['u'] = 0;
        this.keyUp['v'] = 0;
        this.keyUp['w'] = 0;
        this.keyUp['x'] = 0;
        this.keyUp['y'] = 0;
        this.keyUp['z'] = 0;
        this.keyUp[String.fromCharCode(32)] = 0;
        this.keyUp['Shift'] = 0;
        this.keyDown['a'] = 0;
        this.keyDown['b'] = 0;
        this.keyDown['c'] = 0;
        this.keyDown['d'] = 0;
        this.keyDown['e'] = 0;
        this.keyDown['f'] = 0;
        this.keyDown['g'] = 0;
        this.keyDown['h'] = 0;
        this.keyDown['i'] = 0;
        this.keyDown['j'] = 0;
        this.keyDown['k'] = 0;
        this.keyDown['l'] = 0;
        this.keyDown['m'] = 0;
        this.keyDown['n'] = 0;
        this.keyDown['o'] = 0;
        this.keyDown['p'] = 0;
        this.keyDown['q'] = 0;
        this.keyDown['r'] = 0;
        this.keyDown['s'] = 0;
        this.keyDown['t'] = 0;
        this.keyDown['u'] = 0;
        this.keyDown['v'] = 0;
        this.keyDown['w'] = 0;
        this.keyDown['x'] = 0;
        this.keyDown['y'] = 0;
        this.keyDown['z'] = 0;
        this.keyDown[String.fromCharCode(32)] = 0;
        this.keyDown['Shift'] = 0;

    }

    keyDown(key){
        return keyDown.keys[key];
    }

    keyUp(key){
        return keyUp.keys[key];
    }

    keyDownHandler(e) {
        console.log(e.key);
        console.log(String.fromCharCode(32) == e.key);
        this.keyDown[e.key] = 1;
        this.keyUp[e.key] = 0;

    }

    keyUpHandler(e) {
        this.keyUp[e.key] = 1;
        this.keyDown[e.key] = 0;

    }
}

const Input = new input();



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


const canvas = new cnvs();
const gameobjects = new gameobject();
//gameOjects{id} untuk mengambil data object

class script {
    onStart(){

    }

    onUpdate(){
        if(Input.keyDown["d"]) gameObjects[0].x += 1;

        if(Input.keyDown["s"]) gameObjects[0].y += 1;


        if(Input.keyDown["a"]) gameObjects[0].x -= 1;


        if(Input.keyDown["w"]) gameObjects[0].y -= 1;


    }
            
}
let scripts = new script();
let gameObjects = {};

class mainScene{
    mainCanvas = canvas.mainCanvas;
    gobj = [];

    constructor(){
        this.gobj = gameobjects.getgameobject();
        for(let idx in this.gobj){
            let obj = this.gobj[idx];
            console.log(obj);
            gameObjects[obj.id] = new object(obj.id, obj.name,obj.transform.xSize, obj.transform.ySize, obj.transform.x, parseFloat(obj.transform.y), obj.tipe, parseFloat(obj.gravity));
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



const mainScenes = new mainScene();

let interval ;
function draw() {
    mainScenes.onUpdate(interval);
}

interval = setInterval(draw, 10);