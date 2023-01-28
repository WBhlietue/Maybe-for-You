var express = require("express");
var path = require("path");
var app = express();
var bodyParser = require("body-parser");
var jsonParser = bodyParser.urlencoded({ extended: false });

var fs = require("fs");

var data = JSON.parse(fs.readFileSync(__dirname + "/public/json/st.json"));

app.get("/data", function (req, res) {
  res.send(data.st);
});
app.use(express.static(__dirname + "/public"));
app.get("/index", function (req, res) {
  data = JSON.parse(fs.readFileSync(__dirname + "/public/json/st.json"));
  res.sendFile(path.join(__dirname, "/public", "/index.html"));
});

app.use(express.json());
app.post("/post", function (req, res) {
  data.st.push(req.body);
  fs.writeFileSync(__dirname + "/public/json/st.json", JSON.stringify( data))
  res.sendFile(path.join(__dirname, "/public", "/index.html"));
});

app.post("/test", function (req, res) {
  console.log(req.body);
});

var server = app.listen(3000, function () {
  var host = server.address().address;
  var port = server.address().port;
});
