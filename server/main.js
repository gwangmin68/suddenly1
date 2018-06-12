var express = require('express');
var api = require('./request/api');
var app = express();


app.get('/:name', function(req, res){
    api.api_get('NAVER', req.params.name, function(err, result){
        res.send(result);
    });
});

app.listen(3000, function(){
    console.log("Server Start On 3000 Port");
});