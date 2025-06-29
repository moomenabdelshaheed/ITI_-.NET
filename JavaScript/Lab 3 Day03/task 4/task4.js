function FirstcharUpper(str) {
    let splitedwords = str.split(" ");
    for (let i = 0; i < splitedwords.length; i++) {
      
    splitedwords[i] =splitedwords[i][0].toUpperCase() + splitedwords[i].slice(1);
      
    }
    document.writeln(`After : ${splitedwords.join(" ")}`);
  }
  
FirstcharUpper("the quick brown fox");