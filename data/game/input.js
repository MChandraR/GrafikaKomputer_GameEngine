class input{
    keyDown = 1;
    keyUp = 2;

    getInput(type, key, action){
        document.addEventListener(type==1? "keydown":"keyup", action, false);
    }
}


export default new input();