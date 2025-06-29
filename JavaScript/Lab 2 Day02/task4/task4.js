// var arr = [];
// for (var i = 0; i < 5; i++) {
    
//     arr[i]= Number(prompt("Enter The Numbers you want to sort"));
// }
// function funasc(arr){
//    // var arr = [];
//     var temp;
//     for (var i = 0; i < arr.length; i++) {
        
//         for (var j =i+ 1; j < arr.length; j++) {
//             if(arr[i]-arr[j]<0){
//             temp = arr[i];
//             arr[i] = arr[j]
//             arr[j]= temp;
//             }
//         }
        
//     }
//     for (var x = 0; x < 5; x++) {
    
//         console.log(arr[x]);
//     }
// }
// function fundesc(arr){
//     // var arr = [];
//      var temp;
//      for (var i = 0; i < arr.length; i++) {
         
//          for (var j =i+ 1; j < arr.length; j++) {
//              if(arr[i]-arr[j]>0){
//              temp = arr[i];
//              arr[i] = arr[j]
//              arr[j]= temp;
//              }
//          }
         
//      }
//      for (var x = 0; x < 5; x++) {
     
//          console.log(arr[x]);
//      }
//  }



// function sort(funasc,fundesc,num){

    
  
// funasc(num);
// fundesc(num);

// }
// sort(funasc,fundesc,arr); 

var arr = [];
for (var i = 0; i < 5; i++) {
    
    arr[i]= Number(prompt("Enter The Numbers you want to sort"));
}

function   compare_to_asc(a,b){
    return a - b;
}
function   compare_to_desc(a,b){
    return b - a;
}
document.writeln("<div style = 'color : black'><h1> Sorting</h1> </div> <br><hr>");
document.writeln("<span style = 'color : red'>you have Entered the value of  </span>"+arr+"<br>");
arr.sort(compare_to_asc);
document.writeln("<span style = 'color : red'>your values fter being sorted ascending   </span>"+arr+"<br>");


arr.sort(compare_to_desc);
document.writeln("<span style = 'color : red'>your values fter being sorted dsecending  </span>"+arr+"<br>");



