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