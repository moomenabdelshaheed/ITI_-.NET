function palindromeOr_Not() {
    var word = prompt("Please Enter the word you want to check");
    var respectOrNot = confirm("consider case sensitivity ?") ? word: word.toLowerCase();
    
    var j = respectOrNot.length -1;
    
        
       
            for (var i =0 ;i <= respectOrNot.length/2; i++) {
                 
                //  لو عملتها من غير على 2 هتبقى صح وبتطلع نفس الناتج
                // ولكن هيكون بيتشك نفس الحروف تانى ولكن بالعكس 
                if (respectOrNot[i] !== respectOrNot[j]) {
                
                alert("not palindrome");
             return;   
            }
            j--;
        }
        alert("palindrome")

    }
    
    

palindromeOr_Not();
