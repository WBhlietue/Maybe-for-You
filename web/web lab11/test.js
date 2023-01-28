var express = require("express");
var app = express();
var path = require("path");
app.get("/index", function (req, res) {
  res.sendFile(path.join(__dirname, "/public", "/index.html"));
});
app.get("/data", function (req, res) {
  res.send("HI");
});

app.post("/test", function (req, res) {
  console.log(req.body);
});

var server = app.listen(3000, function () {
  var host = server.address().address;
  var port = server.address().port;
});
