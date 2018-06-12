var express = require('express');
var api = require('./request/api');
var bodyParser = require('body-parser');
var app = express();

app.use(bodyParser.urlencoded({
    extended: true
}));
app.use(bodyParser.json());
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

app.post('/kakao/message', function(req, res){
    console.log(req.body);
    api.api_get('NAVER', req.body.content, function(err, result){
        if (err ){
            return res.send({
                "message":{"text":"물품 오류입니다."}
            });
        } 
        result = JSON.parse(result);
            
        if (result.items[0] == null){
            return res.send({
                "message" : {
                    "text":"물품이 존재하지 않습니다."
                }
            });
        }
        return res.send({
            "message":{
                "text":result.items[0].title + "\n최저가 : " + result.items[0].lprice,
                "photo": {
                    "url": result.items[0].image,
                    "width":640,
                    "height":480
                },
                "message_button":{
                    "label":"최저가 사러가기",
                    "url":result.items[0].link
                }
            }
        });
    });
});
app.listen(80, function(){
    console.log("Server Start On 80 Port");
});