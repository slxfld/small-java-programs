
//Variablen
var canvas = document.getElementById("myCanvas");
var ctx = canvas.getContext("2d");
ctx.canvas.width = window.innerWidth-40;
ctx.canvas.height = window.innerHeight-40;

var Width = window.innerWidth-40;
var Height = window.innerHeight-40;
var fps = 60;

var inc_v = 0;

var mouse_x = 0;
var mouse_y = 0;

var dots = [];

var dot_num = 5;

var add_after_loop = false;
var add_loop_x = 0;
var add_loop_y = 0;

ctx.fillStyle = "#999999";
ctx.fillRect(0,0,800,640);
//Width = 800;
//Height = 640;

function getMousePos(canvas,evt) {
  var rect = canvas.getBoundingClientRect();
  return {
    x: evt.clientX - rect.left,
    y: evt.clientY - rect.top};
}
canvas.addEventListener('mousedown',function(evt){
  var mousePos = getMousePos(canvas, evt);
  var message = 'Mouse position: ' + mousePos.x + ',' + mousePos.y;
  var mouse_x = mousePos.x;
  var mouse_y = mousePos.y;

  add_loop_x = mouse_x;
  add_loop_y = mouse_y;
  add_after_loop = true;


},false);

//Dot Objekt
function Dot(x,y,width,height){
  this.x = x;
  this.y = y;
  this.width = width;
  this.height = height;
}

Dot.prototype.update_dot=function update_dot(){
  this.x += 0.8;
  if(this.x > Width){this.x = 0;}
}

Dot.prototype.draw_dot=function draw_dot(){
  var real_x=0;
  var real_y=0;
  real_x =  this.x;
  real_y =  this.y;

  ctx.fillStyle="#656565";
  ctx.fillRect(real_x,real_y,this.width,this.height);
  ctx.fillStyle="#000000";
  ctx.fillRect(real_x-2,real_y-2,this.width,this.height);
}


for(var i = 0; i < dot_num; i++){
  dots[i] = new Dot(Math.floor((Math.random() * Width) + 1),Math.floor((Math.random() * Height) + 1),15,15);
}

function update(){}
function draw_canvas(){
  ctx.clearRect(0,0,Width,Height);
  ctx.fillStyle = "#AAAAAA";
  ctx.fillRect(0,0,Width,Height);
}


function loop(timestamp){
  var progress = timestamp - lastRender;
  update(progress);
  draw_canvas();
  lastRender = timestamp
//dots
  for(var i = 0; i < dot_num; i++){
    dots[i].draw_dot();
    dots[i].update_dot();
    for(var j = 0 ; j < dot_num; j++){
    //  console.log(dots[j]);
      var x1 = dots[j].x+(dots[j].width/2);
      var x2 = dots[i].x+(dots[i].width/2);
      var y1 = dots[j].y+(dots[j].height/2);
      var y2 = dots[i].y+(dots[i].height/2);

      var a = x1 - x2;
      var b = y1 - y2;
      var c = Math.sqrt( a*a + b*b );
      if(c < 200){
        ctx.beginPath();
        ctx.moveTo(x1,y1);
        ctx.lineTo(x2,y2);
        ctx.stroke();
      }
    }
  }

  if(add_after_loop == true){
    add_after_loop = false;
    dot_num++;
    dots[dot_num-1] = new Dot(add_loop_x,add_loop_y,15,15);
  }

}
  var lastRender = 0

function run(){
  setTimeout(function(){
    loop(lastRender);
    requestAnimationFrame(run);
    inc_v += 0.03;
  }, 1000 / fps);
}

run();
