
const BITZ = require('./bitz');

/**
 * ------------------------------------------------------------------
 * @param apiKey        必须
 * @param secretKey     必须
 * @param tradePwd      需要下单交易时必须传（addEntrustSheet）
 * ------------------------------------------------------------------
 */
var apiKey 		= '';
var secretKey 	= '';
var tradePwd 	= '';
BITZ.setConfig( apiKey, secretKey, tradePwd );



// --------------------------------------------------

// BITZ.getUserAssets().then(function(data){
// 	console.log(data);
// }).catch(function(err){
// 	console.log(err);
// });

// Sale
// BITZ.addEntrustSheet('bz_usdt',1,5,'2').then(function(data){
// 	console.log(data);
// }).catch(function(err){
// 	console.log(err);
// });

//
// BITZ.tickerall().then(function(data){
// 	console.log(data);
// }).catch(function(err){
// 	console.log(err);
// });

// ------------------------------------------------

var demo_cmd = `
	// 行情接口
	# node test.js tickerall
	# node test.js ticker \\\'bz_usdt\\\'
	# node test.js orders \\\'bz_usdt\\\'
	# node test.js depth \\\'bz_usdt\\\'
	# node test.js kline \\\'bz_usdt\\\',\\\'5min\\\',20
	# node test.js symbolList
	
	// 资产
	#	node test.js getUserAssets
	// 卖单
	#	node test.js addEntrustSheet \\\'bz_usdt\\\',1,5,\'2\'
	// 买单
	#	node test.js addEntrustSheet \\\'bz_usdt\\\',1,5,\'1\'
	// 订单详细
	#	node test.js getEntrustSheetInfo \\\'orderid\\\'
	// 取消订单
	#	node test.js cancelEntrustSheet \\\'orderid\\\'
	// 批量撤销订单
	#   node test.js cancelAllEntrustSheet \\\'654997428,654928641\\\'	
	//
	# node test.js getUserHistoryEntrustSheet \\\'bz\\\',\\\'usdt\\\',\\\'2\\\',1,5
	# node test.js getUserNowEntrustSheet \\\'bz\\\',\\\'usdt\\\',\\\'2\\\',1,5
`;

function commandParser(){

	var argv = process.argv.splice(2);
	var func = argv[0];
	var params = argv.splice(1);
	var str_params = '';
	if( typeof(BITZ[func]) == 'function' ){
		if(params.length>0){
			str_params = params[0];
		}
		//	
		var script = `
			BITZ.${func}(${str_params})
			.then(
				function(d){
					log('-------------Response-----------');
					var data = JSON.parse(d);
					log(data);
					log(data.data);
				}
			)
			.catch(
				function(err){
					log('-------------Error-----------');
					log(err)
				}
			);`;
		log("----start-----"+func);
		log(script);
		eval(script);
	}else if(func == 'help'){
		log(demo_cmd);
	}
}
function log(msg){
	console.log(msg);
	console.log(" ");
}

commandParser();