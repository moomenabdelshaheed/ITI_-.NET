function findindexof() {
    var phrase = []; 
    var count = [];
    var chara;
    var check;
    phrase = prompt("Type your sentence here !").toLowerCase();
    
    chara = prompt("Type the character you want to search about !").toLowerCase();
    while(chara.length >1){
        alert("ENTER ONE LETTER ONLY !!!")
        chara = prompt("Please enter only one letter !").toLowerCase();
    }
    for (var index = 0; index < phrase.length; index++) {
        if (phrase[index] == chara)
        {
            count.push(index);
            
        }
       
    }
    if (count.length == 0) {
        document.write("<span style='color: red; font-size:30px;'>The character "+chara+" is not found in the sentence.</span><br>");
        return;
    }
   document.write("<span style='color: red; font-size:30px;'>The char "+chara+" is found in index: </span><span style='color: black; font-size:30px;'>"+count+"</span><br>")
}
findindexof();  