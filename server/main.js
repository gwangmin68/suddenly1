var express = require('express');
var api = require('./request/api');
var app = express();


app.get('/', function(req, res){
    api.api_get(null, "포카칩", function(err, result){
        res.send(result);
    });
});

app.listen(3000, function(){
    console.log("Server Start On 3000 Port");
});