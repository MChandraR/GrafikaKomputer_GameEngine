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

class gameobject{
    gameObjects = [];
    constructor(){
       this.objects = [{"id":"0","name":"Game Object 0","type":"1","gravity":"5","fill":"Blue","absolute":1,"collisionBlock":1,"tipe":1,"transform":{"x":0.0,"y":5.0,"xSize":50.0,"ySize":50.0},"audio":{"source":[{"name":"bit jump.mp3","path":"game/asset/bit jump.mp3"},{"name":"sfx.mp3","path":"game/asset/sfx.mp3"},{"name":"sfx.mp3","path":"/game/asset/sfx.mp3"}],"loop":0,"playAtStart":0,"volume":19,"selectedTrack":-1},"texture":{"sources":[{"name":"mario.png","path":"game/asset/mario.png"},{"name":"mario2.png","path":"game/asset/mario2.png"},{"name":"mario.png","path":"/game/asset/mario.png"}],"selectedTexture":-1}},{"id":"1","name":"Game Object 1","type":"1","gravity":"0","fill":"Blue","absolute":1,"collisionBlock":1,"tipe":1,"transform":{"x":0.0,"y":400.0,"xSize":300.0,"ySize":50.0},"audio":{"source":[],"loop":0,"playAtStart":0,"volume":1,"selectedTrack":-1},"texture":{"sources":[{"name":"logo.png","path":"/game/logo.png"},{"name":"120-1209204_ground-pixel-art-ground-png.png","path":"D:/Project/Desktop/GrafikaKomputer_GameEngine/bin/Debug/mygame/game/asset/120-1209204_ground-pixel-art-ground-png.png"},{"name":"120-1209204_ground-pixel-art-ground-png.png","path":"D:/Project/Desktop/GrafikaKomputer_GameEngine/bin/Debug/mygame/game/asset/120-1209204_ground-pixel-art-ground-png.png"}],"selectedTexture":1}},{"id":"2","name":"Game Object 2","type":"1","gravity":"0","fill":"Blue","absolute":1,"collisionBlock":1,"tipe":1,"transform":{"x":100.0,"y":380.0,"xSize":100.0,"ySize":50.0},"audio":{"source":[],"loop":0,"playAtStart":0,"volume":1,"selectedTrack":-1},"texture":{"sources":[{"name":"120-1209204_ground-pixel-art-ground-png.png","path":"D:/Project/Desktop/GrafikaKomputer_GameEngine/bin/Debug/mygame/game/asset/120-1209204_ground-pixel-art-ground-png.png"}],"selectedTexture":0}}] ;
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
        
                if (collisionX && collisionY) {
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



class input{
    keyUp = {};
    keyDown = {};
    space = String.fromCharCode(32);
    mouseDown = {};
    mouseUp = {};

    constructor(){
        document.addEventListener("keydown", this.keyDownHandler.bind(this), false);
        document.addEventListener("keyup", this.keyUpHandler.bind(this), false);
        document.addEventListener("mousedown", this.mouseDownHandler.bind(this), false);
        this.mouseUp['mouse-right'] = 0;
        this.mouseUp['mouse-left'] = 0;
        this.mouseDown['mouse-right'] = 0;
        this.mouseDown['mouser-left'] = 0;

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
        this.keyUp['shift'] = 0;
        this.keyUp['arrowleft'] = 0;
        this.keyUp['arrowright'] = 0;
        this.keyUp['arrowup'] = 0;
        this.keyUp['arrowdown'] = 0;
        this.keyUp['space'] = 0;
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
        this.keyDown['shift'] = 0;
        this.keyDown['arrowleft'] = 0;
        this.keyDown['arrowright'] = 0;
        this.keyDown['arrowup'] = 0;
        this.keyDown['arrowdown'] = 0;
        this.keyDown['space'] = 0;
    }

    keyDown(key){
        return this.keyDown[key];
    }

    keyUp(key){
        return this.keyUp[key];
    }

    mouseDown(button){
        return this.mouseDown[button];
    }

    mouseUp(button){
        return this.mouseUp[button];
    }

    keyDownHandler(e) {
        // console.log(e.key);
        if(String.fromCharCode(32) == e.key){
            this.keyDown["space"] = 1;
        }
        this.keyDown[e.key.toLowerCase()] = 1;
        this.keyUp[e.key.toLowerCase()] = 0;

    }

    keyUpHandler(e) {
        if(String.fromCharCode(32) == e.key){
            this.keyDown["space"] = 0;
        }
        this.keyUp[e.key.toLowerCase()] = 1;
        this.keyDown[e.key.toLowerCase()] = 0;

    }

    mouseDownHandler(e){
        console.log("Mouse clicked");
        console.log(e.pageX, e.pageY);
    }
}

const Input = new input();



class transform{
    sizeX = 0;
    sizeY = 0;
    x = 0;
    y = 0;
    tempX = 0;
    tempY = 0;

    constructor(){
        this.x = 0;
        this.y = 0;
    }

    move(x,y){
        this.x -= x;
        this.y -= y;
    }

}
 

class AudioPlayer{
    constructor(track, vol){
        this.track = [];
        this.trackInfo = [];
        this.selectedTrack = 0;
        this.isPlaying = false;
        for (let audio in track){
            this.track.push(new Audio(track[audio].path));
            this.track[audio].volume = parseFloat(vol)/100.0;
            console.log(this.track);
            this.trackInfo.push(track[audio]);
        }
    }

    setLoop(loop){
        if(this.track[this.selectedTrack] == null)return;
        this.track[this.selectedTrack].loop = loop;
    }

    setVolume(volume){
        // this.track[this.selectedTrack].volume = .1;
    }

    addTrack(source){
        this.track.push(new Audio(source));
    }

    changeTrack(idx){
        this.selectedTrack = idx;
        //this.audio = new Audio(source[idx]);
    }

    play(){
        try{
            console.log(this.selectedTrack);
            console.log(this.track[this.selectedTrack]);
            if(this.track.length < 1) return;
            if(this.track[this.selectedTrack] == null) return;
            console.log(this.track[this.selectedTrack].volume);
            this.track[this.selectedTrack].play().catch(error => {
                this.isPlaying = true;
                console.log('Playback failed: ' + error);
                setTimeout(() => {
                    this.play();
                }, 1000);
            });
        }catch(e){
        }
        
    }

    playAt(track){
        if(this.track.length < 1) return;
        if(this.track[track] == null) return;
        this.track[track].play().catch(error => {
            this.isPlaying = true;
            console.log('Playback failed: ' + error);
        });
    }

    pause(){
        this.isPlaying = false;
        this.track[this.selectedTrack].pause();
    }

    isPlaying(){
        return this.isPlaying;
    }
}

class Texture{
    constructor(textures){
        this.textures = [];
        this.selectedTexture = 0;
        for(let texture in textures){
            this.textures.push(new Image());
            this.textures[texture].src = textures[texture].path;
        }
    }

    getTexture(){
        return  this.textures[this.selectedTexture] == null ? null : this.textures[this.selectedTexture] ;
    }

    changeTexture(idx){
        this.selectedTexture = this.textures[idx] == null ? this.selectedTexture : idx;
    }
}


class object extends transform{
    name = "";
    id = "";
    sizeX = 0;
    sizeY = 0;
    gravity = 0;
    tipe = 0;
    collision = "box";
    colideLimit = [0,0];
    colideObj = [];
    col = [];
    colid = [];
    absolute = true;
    fill = "";

    constructor(id,name,sizeX,sizeY,x,y,tipe,gravity, absolute, collisionBlock, fill, volume,loop,playAtStart,  selectedTrack, track, textures){
        super();
        this.id = id;
        this.name = name;
        this.sizeX = sizeX;
        this.sizeY = sizeY;
        this.x = x;
        this.tempX = x;
        this.tempY = y;
        this.y = y;
        this.gravity = gravity;
        this.tipe = tipe;
        this.move = true;
        this.absolute = absolute;
        this.collisionBlock = collisionBlock;
        this.fill = fill;
        this.audio = new AudioPlayer(track, volume);
        this.audio.setVolume(parseFloat(volume)/100.0);
        this.audio.selectedTrack = selectedTrack;
        this.texture = new Texture(textures.sources);
        this.audio.setLoop(loop);
        if(playAtStart){
            this.audio.play();
        }
        this.texture.changeTexture(textures.selectedTexture);
    }

    colides(){
        for(let idx in this.colideObj){
            let boxB = this.colideObj[idx];
            if(!this.colideObj[idx].absolute && this.colideObj[idx].collisionBlock){
                this.colideObj[idx].x += this.x - this.tempX;
                this.colideObj[idx].y += this.y - this.tempY;
            }
    
            if( this.colideObj[idx].collisionBlock && (this.tempX+this.sizeX > this.colideObj[idx].x && this.tempX < this.colideObj[idx].x + this.colideObj[idx].sizeX)){
                if(this.absolute && boxB.absolute){
                    boxB.y = boxB.tempY;
                }
            }else {
                if(this.colideObj[idx].collisionBlock &&  !(this.tempY + this.sizeY > this.colideObj[idx].y && this.tempY >= this.colideObj[idx].y + this.colideObj[idx].sizeY) ){
                    if(this.absolute && boxB.absolute){  
                        boxB.x = boxB.tempX;
                    }
                }
            }
            
            this.colideObj[idx].colides();

            // if( this.collisionBlock && (boxB.tempX+boxB.sizeX > this.x && boxB.tempX < this.x + this.sizeX)){
            //     if(boxB.y > this.y) boxB.y = this.y + this.sizeY;
            //     else boxB.y = this.y - boxB.sizeY;
            // }else {
            //     if(this.collisionBlock &&  !(boxB.tempY + boxB.sizeY > this.y && boxB.tempY >= this.y + this.sizeY) ){
            //         if(boxB.x > this.x) boxB.x = this.x + this.sizeX;
            //         else boxB.x = this.x - boxB.sizeX;
            //     }
            // }

            if( this.colideObj[idx].collisionBlock && boxB.collisionBlock && (this.tempX+this.sizeX > this.colideObj[idx].x && this.tempX < this.colideObj[idx].x + this.colideObj[idx].sizeX)){
                if(this.tempY > this.colideObj[idx].y) this.y = this.colideObj[idx].y + this.colideObj[idx].sizeY;
                else this.y = this.colideObj[idx].y - this.sizeY;
            }else {
                if(this.colideObj[idx].collisionBlock&& boxB.collisionBlock &&  !(this.tempY + this.sizeY > this.colideObj[idx].y && this.tempY >= this.colideObj[idx].y + this.colideObj[idx].sizeY) ){
                    if(this.tempX > this.colideObj[idx].x) this.x = this.colideObj[idx].x + this.colideObj[idx].sizeX;
                    else this.x = this.colideObj[idx].x - this.sizeX;
                }
            }

            
        }
        this.colideObj = [];
    }

    draw(canvas){
        // if(this.absolute){
        //     this.y = this.tempY;
        //     this.x = this.tempX;
        // }
        this.colides();
       
        this.tempX = this.x;
        this.tempY = this.y;
        
        if(this.y < canvas.height) this.y += this.gravity;
        canvas.context.beginPath();
        if(!this.texture.textures.length || this.texture.getTexture() == null){
            if(this.tipe==0)canvas.context.arc(this.x, this.y, this.sizeX, 0, Math.PI * 2);
            else if(this.tipe==1)canvas.context.rect(this.x, this.y, this.sizeX, this.sizeY);
        }else{
            canvas.context.drawImage(this.texture.getTexture(),this.x, this.y, this.sizeX, this.sizeY );
        }
        canvas.context.fillStyle = this.fill;
        canvas.context.fill();
        canvas.context.closePath();
        this.colide = [false,false];
        this.colideObj = [];
        
    }

}


const canvas = new cnvs();
const gameObjects = new gameobject();
//gameOjects{id} untuk mengambil data object

class script {
	speed = 1;
	cd = false;
    	onStart(){

    	}

    	onUpdate(){
		if(Input.keyDown["d"]) {
			gameObjects.getGameObjectAt(0).x += (1*this.speed);
			gameObjects.getGameObjectAt(0).texture.changeTexture(0);
		}
		if(Input.keyDown["a"]) {
			gameObjects.getGameObjectAt(0).x -= (1*this.speed);
			gameObjects.getGameObjectAt(0).texture.changeTexture(1);
			
		}

		if(Input.keyDown["s"]) gameObjects.getGameObjectAt(0).y += (1*this.speed);              
		if(Input.keyDown[String.fromCharCode(32)] && !this.cd && gameObjects.getGameObjectAt(0).col.length > 0 ) {
			gameObjects.getGameObjectAt(0).audio.play();
			gameObjects.getGameObjectAt(0).y -= 100;
			this.cd = true;
			setTimeout(()=>{this.cd = false;}, 1000);
		}
		
		
		if(Input.keyDown["arrowleft"]) gameObjects.getGameObjectAt(1).x -= (1*this.speed);
		if(Input.keyDown["arrowright"]) gameObjects.getGameObjectAt(1).x += (1*this.speed);
		if(Input.keyDown["arrowup"]) gameObjects.getGameObjectAt(1).y -= (1*this.speed);
		if(Input.keyDown["arrowdown"]) gameObjects.getGameObjectAt(1).y += (1*this.speed);

if(Input.keyDown["shift"]) this.speed = 2;

		else this.speed = 1;
	}
            
}
let scripts = new script();


class mainScene{
    mainCanvas = canvas.mainCanvas;
    gobj = [];

    constructor(){
        console.log(gameObjects.gameObject);
        // this.audio = new Audio('game/asset/bgm.mp3');
        // this.audio.play();
    }

    onUpdate(){
        canvas.context.clearRect(0, 0, canvas.width, canvas.height);
        canvas.draw();
        scripts.onUpdate();
        gameObjects.collisionDetect();
        gameObjects.renderObjects(canvas);
        //clearInterval(interval);
    }

    getGameObject(id){
        
    }
}
// var audio = new Audio('game/asset/bgm.mp3');
// audio.volume = .25;
// audio.loop = true;
// var audio2 = new Audio('game/asset/bgms.mp3');
// function playA(){
//     audio2.play();
// }

//         // Fungsi untuk memutar audio setelah interaksi pengguna
//         function initializeAndPlayAudio() {
//             audio.play().catch(error => {
//                 console.log('Playback failed: ' + error);
//             });

           

//             // Menghapus event listener setelah pertama kali dijalankan
//             document.removeEventListener('click', initializeAndPlayAudio);
//         }

//         // Menambahkan event listener ke dokumen
//         document.addEventListener('click', initializeAndPlayAudio);


const mainScenes = new mainScene();

let interval ;
function draw() {
    mainScenes.onUpdate();
    requestAnimationFrame(draw);
}

draw();
// interval = setInterval(draw, 10);