$transform 

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
                if(this.absolute){
                    boxB.y = boxB.tempY;
                }
            }else {
                if(this.colideObj[idx].collisionBlock &&  !(this.tempY + this.sizeY > this.colideObj[idx].y && this.tempY >= this.colideObj[idx].y + this.colideObj[idx].sizeY) ){
                    if(this.absolute){  
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

            if( this.colideObj[idx].collisionBlock && (this.tempX+this.sizeX > this.colideObj[idx].x && this.tempX < this.colideObj[idx].x + this.colideObj[idx].sizeX)){
                if(this.tempY > this.colideObj[idx].y) this.y = this.colideObj[idx].y + this.colideObj[idx].sizeY;
                else this.y = this.colideObj[idx].y - this.sizeY;
            }else {
                if(this.colideObj[idx].collisionBlock &&  !(this.tempY + this.sizeY > this.colideObj[idx].y && this.tempY >= this.colideObj[idx].y + this.colideObj[idx].sizeY) ){
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

