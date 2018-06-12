var request = require('request');
var utf8 = require('utf8');
function statusCodeErrorHandler(statusCode, callback , data) {
    switch (statusCode) {
        case 200:
            callback(null, JSON.parse(data));
            break;
        default:
            callback('error', JSON.parse(data));
            break;
    }
} 
module.exports = {
    api_get : 
    function (method, query, callback){
        var options={
            headers:{'Content-Type': 'application/json',
                    'X-Naver-Client-Id':'6_URPDXcfUAsiCSAJLqb',
                    'X-Naver-Client-Secret':'kjWpzg2lk2'},
            url:'https://openapi.naver.com/v1/search/shop.json?query=' +utf8.encode(query) + '&sort=asc',
            body:null,
        };
        
        console.log(options.url);
        request.get(options, function(err, res, result){
            statusCodeErrorHandler(res.statusCode, callback, result);
        });

    }

    
};