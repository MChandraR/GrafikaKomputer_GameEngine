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