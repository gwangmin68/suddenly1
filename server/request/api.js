var request = require('request');
var utf8 = require('utf8');
var snacks = require('./snacks');
function statusCodeErrorHandler(statusCode, callback, data) {
    switch (statusCode) {
        case 200:
            callback(null, JSON.parse(data));
            break;
        default:
            callback('error', JSON.parse(data));
            break;
    }
}
function NAVER_find_snack(snack, count){
    if (snacks[snack] == null){
        return null;
    }
    return 'https://openapi.naver.com/v1/search/shop.json?query=' + snacks[snack] + '&display=' + count;
}

module.exports = {
    api_get: function (method, query, callback) {
        var options = {};
        if (method == 'NAVER') {
            options = {
                headers: {
                    'Content-Type': 'application/x-www-form-urlencoded',
                    'X-Naver-Client-Id': '6_URPDXcfUAsiCSAJLqb',
                    'X-Naver-Client-Secret': 'kjWpzg2lk2'
                },
                url: NAVER_find_snack(query, 10),
                body: null,

            };
        }
        else if(method == ''){

        }
        if (options.url == null){
            callback(err, 'snack not exiets');
        }
        request.get(options, function (err, res, result) {
            if (err) {
                console.log(err);
            }
            statusCodeErrorHandler(res.statusCode, callback, result);
        });

    }


};