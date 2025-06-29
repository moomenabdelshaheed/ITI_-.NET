const moomen = {
    name: "MOOMEN",
    age: 25,
    grades: {
      math: 90,
      science: 95,
      literature: 99
    },
    contactInfo: {
      email: "moomentheone@gmail.com",
      phone: "123-456-7890"
    }
  };

function printstudentData(student) {
    var data = "" ;
    for (var key in student) {
        if (typeof student[key] === 'object' && student[key] !== null) {
            data += `${key}:<br>`;
            for (var nestedkey in student[key]) {
                data += `${nestedkey}: ${student[key][nestedkey]}<br>`;
            }
        } else {
            data += `${key}: ${student[key]}<br>`;
        }
    }
    return data;
}
  document.writeln(printstudentData(moomen));
  



