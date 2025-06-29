var image = document.getElementsByClassName("displayed-image"); 
var currentIndex = 0; 

function showImage(index) {
    for (let i = 0; i < image.length; i++) {
        image[i].style.display = i === index ? "block" : "none"; 
            //هى هى دى زى اللى فوق
        // if (i === index) {
        //     image[i].style.display = "block";
        // } else {
        //     image[i].style.display = "none";
        // }
        
    }
}

function prev() {
    currentIndex = (currentIndex - 1 + image.length) % image.length;   
    showImage(currentIndex);
}

function next() {
    currentIndex = (currentIndex + 1) % image.length; //% image.length: ده بيضمن إننا نرجع لأول صورة لما نوصل للنهاية.
    showImage(currentIndex);
}

showImage(currentIndex);
