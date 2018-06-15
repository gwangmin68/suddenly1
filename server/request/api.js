var request = require('request');
var utf8 = require('utf8');
var qs = require('querystring');
function statusCodeErrorHandler(statusCode, callback, data) {
    switch (statusCode) {
        case 200:
            callback(null, data.replace(/<(\/)?([a-zA-Z]*)(\s[a-zA-Z]*=[^>]*)?(\s)*(\/)?>/ig, ""));
            break;
        default:
            callback('error', data.replace(/<(\/)?([a-zA-Z]*)(\s[a-zA-Z]*=[^>]*)?(\s)*(\/)?>/ig, ""));
            break;
    }
}
function NAVER_find_snack(snack, count){
    return 'https://openapi.naver.com/v1/search/shop.json?query=' + qs.escape(snack) + '&display=' + count;
}
function _11_find_snack(snack, count){
    return `http://openapi.11st.co.kr/openapi/OpenApiService.tmall?key=&apiCode=ProductSearch&keyword=${qs.escape(snack)}&pageSize=${count}`;
}

module.exports = {
    api_get: function (method, query, callback) {
        var options = {};
        if (method == 'NAVER') {
            options = {
                headers: {
                    'Content-Type': 'application/x-www-form-urlencoded',
                    'X-Naver-Client-Id': '',
                    'X-Naver-Client-Secret': ''
                },
                url: NAVER_find_snack(query, 10),
                body: null,

            };
        }
        else if(method == '11번가'){
            options = {
                headers: {
                    'Content-Type': 'application/x-www-form-urlencoded',
                },
                url: _11_find_snack(query, 50)
            }
        }
        if (options.url == null){
            return callback(null, 'snack not exists');
        }
        request.get(options, function (err, res, result) {
            if (err) {
                console.log(err);
            }
            statusCodeErrorHandler(res.statusCode, callback, result);
        });

    }


};
