const imagesArray = ["images/image1.jpg", "images/image2.jpg", "images/image3.jpg", "images/image4.jpg"];
let autoSlide;

function changeImage(direction) {
    const imageElement = document.getElementById("slider-image");
    const currentSrc = imageElement.getAttribute("src");
    const currentIndex = imagesArray.indexOf(currentSrc);
    const nextIndex = (currentIndex + direction + imagesArray.length) % imagesArray.length;
    imageElement.setAttribute("src", imagesArray[nextIndex]);
}

function startSlider() {
    stopSlider();
    autoSlide = setInterval(() => changeImage(1), 1000); // ← قللت السرعة إلى 1000ms بدلاً من 200ms
}

function stopSlider() {
    clearInterval(autoSlide);
}
