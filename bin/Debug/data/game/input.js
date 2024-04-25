

class input{
    keyUp = {};
    keyDown = {};

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

    }

    keyDown(key){
        return keyDown.keys[key];
    }

    keyUp(key){
        return keyUp.keys[key];
    }



    keyDownHandler(e) {
        this.keyDown[e.key] = 1;
        this.keyUp[e.key] = 0;

    }

    keyUpHandler(e) {
        this.keyUp[e.key] = 1;
        this.keyDown[e.key] = 0;

    }
}

const Input = new input();


