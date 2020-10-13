//Variablen
var canvas = document.getElementById("myCanvas");
var ctx = canvas.getContext("2d");
var Width = 800;
var Height = 640;
var fps = 60;

var inc_v = 0;
var mouse_x = 0;
var mouse_y = 0;
var static_dots = {};
var s_dot_inc = 0;

ctx.fillStyle = "#999999";
ctx.fillRect(0, 0, 800, 640);

function getMousePos(canvas, evt) {
    var rect = canvas.getBoundingClientRect();
    return {
        x: evt.clientX - rect.left,
        y: evt.clientY - rect.top
    };
}
canvas.addEventListener('mousemove', function(evt) {
    var mousePos = getMousePos(canvas, evt);
    var message = 'Mouse position: ' + mousePos.x + ',' + mousePos.y;
    mouse_x = mousePos.x;
    mouse_y = mousePos.y;

}, false);

//Keine Funktion
function Dot(x, y, width, height) {
    this.x = x;
    this.y = y;
    this.width = width;
    this.height = height;
}

Dot.prototype.update_dot = function update_dot() {
    this.x += 1;
    if (this.x > Width) {
        this.x = 0;
    }
}

Dot.prototype.draw_dot = function draw_dot() {
    var real_x = 0;
    var real_y = 0;
    real_x = this.x;
    real_y = (Math.sin(inc_v) * 235) + this.y;

    /*  ctx.fillStyle="#656565";
      ctx.fillRect(real_x,real_y,this.width,this.height);
      ctx.fillStyle="#000000";
      ctx.fillRect(real_x-2,real_y-2,this.width,this.height);
    */
    //  ctx.fillStyle="#656565";
    //  ctx.fillRect(real_x,real_y,this.width,this.height);
    var red_val = ((Math.sin(inc_v) * 245).toString() / 2.2);
    if (red_val < 0) {
        red_val = -red_val;
    }
    ctx.fillStyle = "#0000" + Math.round(red_val);
    ctx.fillRect(real_x - 2, real_y - 2, this.width, this.height);

    if (this.x % 2 == 1) {
        //  static_dots[s_dot_inc] = new S_Dot(real_x,real_y,11,11);
        //  s_dot_inc++;
    }
}


//Keine Funktion
function S_Dot(x, y, width, height) {
    this.x = x;
    this.y = y;
    this.width = width;
    this.height = height;
}

S_Dot.prototype.supdate_dot = function supdate_dot() {
    this.x += 4;
    if (this.x > Width) {
        this.x = 0;
    }
}

S_Dot.prototype.sdraw_dot = function sdraw_dot() {

    var real_x = 0;
    var real_y = 0;

    real_x = this.x;
    real_y = this.y;

    ctx.fillStyle = "#656565";
    ctx.fillRect(real_x, real_y, this.width, this.height);
    var red_val = (real_y.toString() / 4);
    ctx.fillStyle = "#" + Math.round(red_val) + "0000";
    ctx.fillRect(real_x - 2, real_y - 2, this.width, this.height);
}




var dots = {};
var dot_num = 1;
for (var i = 0; i < dot_num; i++) {
    dots[i] = new Dot(Math.floor((Math.random() * Width) + 1), Math.floor((Math.random() * Height) + 1), 32, 32);
}

function update() {}

function draw_canvas() {
    //  ctx.clearRect(0,0,Width,Height);
    //  ctx.fillStyle = "#999999";
    //  ctx.fillRect(0,0,800,640);
}


function loop(timestamp) {
    var progress = timestamp - lastRender;
    update(progress);
    draw_canvas();
    lastRender = timestamp
    //dots
    for (var i = 0; i < dot_num; i++) {
        dots[i].draw_dot();
        dots[i].update_dot();
    }
    for (var i = 0; i < s_dot_inc; i++) {
        static_dots[i].sdraw_dot();
        static_dots[i].supdate_dot();
    }


}
var lastRender = 0

function run() {
    setTimeout(function() {
        loop(lastRender);
        requestAnimationFrame(run);
        inc_v += 0.03;
    }, 1000 / fps);
}

run();
