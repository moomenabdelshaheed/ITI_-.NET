var input = [1,2,3,4,5,1,5,7,9,15];
function _2ndMinMax(arr) {
    var uniquearr = [];

    var arraftersort = arr.sort((a, b) => a - b);

    for (let i = 0; i < arraftersort.length; i++) {
        if (!uniquearr.includes(arraftersort[i])) {
            uniquearr.push(arraftersort[i]);
        } 
    }
  
   document.writeln(`the 2nd loweset number is ${uniquearr[1]} and the 2nd greatest number is ${uniquearr[uniquearr.length-2]}`)
  }


  

  _2ndMinMax(input);