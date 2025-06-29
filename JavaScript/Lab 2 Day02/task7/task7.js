var s = [1,2,3,4,5,6,7];

function processArray(arr,fun) {
   


    document.writeln("<span style = 'color : red'>var numbers is </span>"+s+"<br>");
    document.writeln("<span style = 'color : red'>Function Call: processArray(numbers,square) </span><br>");
    document.writeln("<span style = 'color : red'>Expected output is </span>"+fun(arr)+"<br>");
}



function square(arr){
    var array = [];
    for (var index = 0; index < arr.length; index++) {
        
        array[index]= arr[index]*arr[index];
       
        
    }
   return array
}
console.log(processArray(s,square));