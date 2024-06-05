

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
        document.addEventListener("mouseup", this.mouseUpHandler.bind(this), false);
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
        if(e.button == 0) {
            this.mouseUp["mouse-left"] = 0;
            this.mouseDown["mouse-left"] = 1;
        }else if(e.button == 2) {
            this.mouseUp["mouse-right"] = 0;
            this.mouseDown["mouse-right"] = 1;
        }
        console.log(e.pageX, e.pageY);
    }

    mouseUpHandler(e){
        if(e.button == 0) {
            this.mouseUp["mouse-left"] = 1;
            this.mouseDown["mouse-left"] = 0;
        }else if(e.button == 2) {
            this.mouseUp["mouse-right"] = 1;
            this.mouseDown["mouse-right"] = 0;
        }
        console.log(e.pageX, e.pageY);
    }
}

const Input = new input();


