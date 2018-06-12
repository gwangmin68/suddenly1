var express = require('express');
var api = require('./request/api');
var app = express();
var bodyparser = require('body-parser');

app.use(bodyparser.urlencoded({extended :false}));

app.get('/naver/:name', function(req, res){
    api.api_get('NAVER', req.params.name, function(err, result){
        res.send(JSON.parse(result));
    });
});   

app.get('/11/:name', function(req, res){
    api.api_get('11번가', req.params.name, function(err, result){
        res.send(result);
    });
});   
app.get('/kakao/keyboard', function(req, res){
    res.send({"type" : "text"});
});

app.get('/kakao/message', function(req, res){
    console.log(req.body);
    res.send({"text":"시발년아"});
});
app.listen(3000, function(){
    console.log("Server Start On 3000 Port");
});