function display() {
    var className = document.getElementById("2").value.trim();
    var tagName = document.getElementById("1").value.trim();
    var outputInput = document.getElementById("5");
    var id = document.getElementById("3").value.trim();
    var name = document.getElementById("4").value.trim();
    var resultArray = [];

    if (tagName) {
        const elements = document.getElementsByTagName(tagName);
        resultArray.push(`TagName ${tagName}:count equal ${elements.length} elements`);
        
    }

    if (className) {
        const elements = document.getElementsByClassName(className);
        resultArray.push(`ClassName ${className}:count equal ${elements.length} elements`);
    }

    if (id) {
        const elementssss = document.getElementById(id);
        resultArray.push(`ID (${id}): ${elementssss ? "True" : "False"}`);
    }

    if (name) {
        const elements = document.getElementsByName(name);
        resultArray.push(`Name ${name} : count equal ${elements.length} elements`);
    }
    outputInput.value = resultArray.join("\n");
}