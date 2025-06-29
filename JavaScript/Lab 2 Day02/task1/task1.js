function StringSumlower (){
    var numof = 0;
    var lyrics = prompt("Enter the words here !");
    for (var i =0;i<lyrics.length;i++){
        if(lyrics[i]==="e")
            numof +=1;
    }
    alert("the count of e in the topic is "+numof);
}
StringSumlower();

function StringSum_upperand_lower (){
    var numof = 0;
    var lyrics = prompt("Enter the words here !");
    for (var i =0;i<lyrics.length;i++){
        if(lyrics[i].toLowerCase() ==="e")
            numof +=1;
    }
    alert("the count of e in the topic is "+numof);
}
StringSum_upperand_lower();
