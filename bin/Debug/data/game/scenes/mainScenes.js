$canvas
$gameObject
$inputs
$objects
const canvas = new cnvs();
const gameObjects = new gameobject();
$script
let scripts = new script();


class mainScene{
    mainCanvas = canvas.mainCanvas;
    gobj = [];

    constructor(){
        console.log(gameObjects.gameObject);
        // this.audio = new Audio('game/asset/bgm.mp3');
        // this.audio.play();
    }

    setUp(){
        scripts.onStart();
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
