package com.bitz;

import com.bitz.restapi.BitzApiRestClient;

public class Main {

    public static void main(String[] args) {
        //
        String apiKey 		= "81083a0321572881b0728592ecc9d44e";
        String secretKey 	= "SapqtOXQrISiXV5TZFbf0U869UKYYXHcqMUIKkAZXtMk6i9rrjE4ZADIqUy2pctn";
        String tradePwd 	= ""; // 委托单 必须 传递 tradePwd 交易密码
	    // write your code here
        BitzApiRestClient restClient = new BitzApiRestClient(apiKey,secretKey,tradePwd);

        //
        String tmp = "";

        // getUserAssets
        // tmp  = restClient.getUserAssets();

        // getUserNowEntrustSheet
        // tmp = restClient.getUserNowEntrustSheet("bz","usdt","2","1","5");

        // getUserHistoryEntrustSheet
        // tmp = restClient.getUserHistoryEntrustSheet("bz","usdt","1","1","5");

        // addEntrustSheet
        // tmp = restClient.addEntrustSheet("bz_usdt","1","5.0","2");

        // getEntrustSheetInfo
        // tmp = restClient.getEntrustSheetInfo("657055834");

        // cancelEntrustSheet
        // tmp = restClient.cancelEntrustSheet("657055834");

        // cancelAllEntrustSheet
//        tmp = restClient.cancelAllEntrustSheet("1,2,3,5");

        // ticker
        // tmp = restClient.ticker("eth_btc");

        // tickerall
        //tmp = restClient.tickerall();

        // kline
         tmp = restClient.kline("eth_btc","5min");

        // symbolList
//         tmp = restClient.symbolList();

        System.out.print(tmp);


    }
}
