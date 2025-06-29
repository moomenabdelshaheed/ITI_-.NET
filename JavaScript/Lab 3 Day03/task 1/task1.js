var arr = ["ahmed","islam","sandra","moomen","fatma"];
function Names(arr) {



 var firstname = Math.floor(Math.random()* 5)
 var secondname;
 do {
    secondname= Math.floor(Math.random()* 5)
 } while (firstname== secondname);
 
return [arr[firstname], arr[secondname]];
}
document.writeln(`the two names are   :${Names(arr)}`);
 
