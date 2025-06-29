var studentTableBody = document.getElementById("studentsTableBody");
var inputStudentName = document.getElementById("studentName");
var inputStudentAge = document.getElementById("studentAge");
var studentCounter = 0;
var nameErrorMsg = document.getElementById("nameError");
var ageErrorMsg = document.getElementById("ageError");

// التحقق من الاسم
inputStudentName.addEventListener("input", function () {
    if (inputStudentName.value.trim().length <= 3) {
        nameErrorMsg.innerHTML = "Name must be longer than 3 characters";
    } else {
        nameErrorMsg.innerHTML = "";
    }
});

inputStudentName.addEventListener("blur", function () {
    if (inputStudentName.value.trim().length === 0) {
        nameErrorMsg.innerHTML = "Student Name is required";
    }
});

// التحقق من العمر
inputStudentAge.addEventListener("input", function () {
    let ageInput = Number(inputStudentAge.value);
    if (isNaN(ageInput) || ageInput <= 18) {
        ageErrorMsg.innerHTML = "Age must be a number greater than 18";
    } else {
        ageErrorMsg.innerHTML = "";
    }
});

inputStudentAge.addEventListener("blur", function () {
    if (inputStudentAge.value.trim() === "") {
        ageErrorMsg.innerHTML = "Age is required";
    }
});

// إضافة طالب
function insertStudent() {
    let studentName = inputStudentName.value.trim();
    let studentAge = Number(inputStudentAge.value);

    if (studentName.length < 4 || studentAge < 18 || isNaN(studentAge)) {
        return;
    }

    let existingRows = studentTableBody.getElementsByTagName("tr");
    for (let row of existingRows) {
        let nameCell = row.cells[1]?.innerText;
        let ageCell = row.cells[2]?.innerText;
        if (nameCell === studentName && ageCell === String(studentAge)) {
            alert("This student is already added.");
            return;
        }
    }

    var newRow = document.createElement("tr");
    var cellID = document.createElement("td");
    var cellName = document.createElement("td");
    var cellAge = document.createElement("td");
    var cellAction = document.createElement("td");
    var removeBtn = document.createElement("button");

    studentCounter++;
    cellID.innerHTML = studentCounter;
    cellName.innerHTML = studentName;
    cellAge.innerHTML = studentAge;
    removeBtn.innerHTML = "Delete";
    removeBtn.classList.add("remove-btn");

    removeBtn.addEventListener("click", function () {
        newRow.remove();
    });

    cellAction.appendChild(removeBtn);
    newRow.append(cellID, cellName, cellAge, cellAction);
    studentTableBody.appendChild(newRow);

    inputStudentName.value = "";
    inputStudentAge.value = "";
}
