
var radius;
do{

    radius = Number(prompt("Enter the radius you want to get the area for "));

}while(isNaN(radius) || radius < 0);

document.writeln(`the area of the radius ${radius} is equal ${Math.PI*radius*radius}<br>`);

var number;
do{

    number = Number(prompt("Enter the value you want to get the square root for"));

}while(isNaN(number) || number < 0);
document.writeln(`the sqr of the  ${number} is equal ${Math.sqrt(number)}<br>`);

var angle;
do{

    angle = Number(prompt("Enter the angle you want to get the cos value for "))

}while(isNaN(angle));

document.writeln(`the Cos of the angle  ${angle} is equal ${Math.cos(Math.PI*angle/180)}`);
