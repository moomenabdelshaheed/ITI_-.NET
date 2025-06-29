function mathematical_op(){
    var arr = [];
    var sum =0;
    var mul =1;
    var divide = arr[0];
    for (var i = 0; i < 3; i++) {
        do {
            arr[i] = Number(prompt("Enter the 3 Numbers here !"));
            if(arr[1] == 0 || arr[2] == 0)
            alert("You cannot divide by Zero");
        } 
        while ((isNaN(arr[i])||arr[1] == 0 || arr[2] == 0));// التحقق من صحة الإدخال
    }

for (i = 0;i < 3;i++) {
    sum+=arr[i];
    mul*=arr[i];
    divide = arr[0] / arr[1] / arr[2];
}

document.writeln("<div style = 'color : black'><h1>Adding -- Multiplying -- and dividing 3 values </h1> </div> <br><hr>");
document.writeln("<span style = 'color : red'>Sum of the 3 values </span>"+arr[0]+"+"+arr[1]+"+"+arr[2]+'='+sum+"<br>");
document.writeln("<span style = 'color : red'>Multiply of the 3 values    </span>"+arr[0]+"*"+arr[1]+"*"+arr[2]+'='+mul+"<br>");
document.writeln("<span style = 'color : red'>Divide of the 3 values   </span>"+arr[0]+"/"+arr[1]+"/"+arr[2]+'='+divide+"<br>");



}

mathematical_op();