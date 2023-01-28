const https = new XMLHttpRequest();

ShowData();

function GetFormData() {
  var data = {
    fName: document.getElementById("fName").value,
    lName: document.getElementById("lName").value,
    code: document.getElementById("code").value,
    age: document.getElementById("age").value,
    birth: document.getElementById("birth").value,
    gpa: document.getElementById("gpa").value,
    isTakeLeave: document.querySelector("input[name = 'isTakeLeave']:checked")
      .value,
  };
  return data;
}

function Post() {
  https.open("POST", "http://127.0.0.1:3000/post", true);
  https.setRequestHeader("Content-type", "application/json;charset=UTF-8");
  https.send(JSON.stringify(GetFormData()));
  https.onload = () => {
    ShowData();
  }
}

function ShowData() {

  https.open("GET", "http://127.0.0.1:3000/data", false);
  https.send();
  var data = JSON.parse(https.responseText);
  var keys = Object.keys(data[0]);

  var table = document.getElementById("table");
  table.innerHTML ="";
  var rowTitle = table.insertRow(0);
  for (var i = 0; i < keys.length; i++) {
    rowTitle.insertCell(i).innerHTML = keys[i];
  }

  for (var i = 0; i < data.length; i++) {
    var row = table.insertRow(i + 1);
    var k = Object.keys(data[i]);
    for (var j = 0; j < k.length; j++) {
      row.insertCell(j).innerHTML = data[i][k[j]];
    }
  }
}
