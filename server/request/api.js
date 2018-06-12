var request = require('request');
var utf8 = require('utf8');

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
/**
 * 
 * @param {String} str 
 */

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
                url: 'https://openapi.naver.com/v1/search/shop.json?query=' + '%ED%8F%AC%EC%B9%B4%EC%B9%A9',
                body: null,

            };
        }
        else if(method == ''){

        }
        console.log('%ED%8F%AC%EC%B9%B4%EC%B9%A9');
        console.log(utf8.encode('포카칩').split('\\')[0]);
        request.get(options, function (err, res, result) {
            if (err) {
                console.log(err);
            }
            statusCodeErrorHandler(res.statusCode, callback, result);
        });

    }


};