# BIT-Z NODE DEMO 

## 安装依赖

```
	npm install 

	node test.js help

```

## 使用方法

```
	const BITZ = require('./bitz');
	/**
	 * @param apiKey        必须
	 * @param secretKey     必须
	 * @param tradePwd      需要下单交易时必须传（addEntrustSheet）
	 */
	var apiKey 		= '';
	var secretKey 	= '';
	var tradePwd 	= '';
	BITZ.setConfig( apiKey, secretKey, tradePwd );

	// 获取资产
	BITZ.getUserAssets().then(function(data){
		console.log(data);
	}).catch(function(err){
		console.log(err);
	});

	// 获取所有牌价数据
	BITZ.tickerall().then(function(data){
		console.log(data);
	}).catch(function(err){
		console.log(err);
	});

```

