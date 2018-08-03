<?php
/**
 * Created by Bitz
 */

class bitz
{
    protected $secretKey = 'You secretKey';
    protected $base_url = 'https://apiv2.bitz.com';
    protected $url = '';
    public function __construct($options = null)
    {
        $this->url = $this->base_url;
        try {
            if (is_array($options))
            {
                foreach ($options as $option => $value)
                {
                    $this->$option = $value;
                }
            }
            else
            {
                return false;
            }
        }
        catch (PDOException $e) {
            throw new Exception($e->getMessage());
        }
    }

    //array('symbol' => 'eos_btc');
    public function ticker($parms){
        $send_data  = $this->getData($parms);
        $url = $this->url.'/Market/ticker?'.http_build_query($send_data);
        return $this->http_request($url);
    }

    //array('symbol' => 'eos_btc', 'resolution' => '5min', 'size' => '100');
    public function kline($parms){
        $send_data  = $this->getData($parms);
        $url = $this->url.'/Market/kline?'.http_build_query($send_data);
        return $this->http_request($url);
    }

    //array('symbol' => 'eos_btc');
    public function depth($parms){
        $send_data  = $this->getData($parms);
        $url = $this->url.'/Market/depth?'.http_build_query($send_data);
        return $this->http_request($url);
    }

    // array('symbol' => 'eos_btc');
    public function order($parms){
        $send_data  = $this->getData($parms);
        $url = $this->url.'/Market/order?'.http_build_query($send_data);
        return $this->http_request($url);
    }

    public function tickerall(){
        $url = $this->url.'/Market/tickerall';
        return $this->http_request($url);
    }

    public function symbolList(){
        $url = $this->url.'/Market/symbolList';
        return $this->http_request($url);
    }


    //array('apiKey' => '');
    public function getUserAssets($parms){
        $send_data  = $this->getData($parms);
        $url = $this->url.'/Assets/getUserAssets';
        return $this->http_request($url,$send_data);
    }

    //array('apiKey' => '', 'symbol' => '', 'number' => '', 'price' => '', 'tradePwd' => '', 'type' => '');
    public function addEntrustSheet($parms)
    {
        $send_data  = $this->getData($parms);
        $url = $this->url.'/Trade/addEntrustSheet';
        return $this->http_request($url,$send_data);
    }

    //array('apiKey' => '', 'entrustSheetId' => '');
    public function cancelEntrustSheet($parms){
        $send_data  = $this->getData($parms);
        $url = $this->url.'/Trade/cancelEntrustSheet';
        return $this->http_request($url,$send_data);
    }

    //array('apiKey' => '', 'ids' => '1,2,3,4');;
    public function cancelAllEntrustSheet($parms){
        $send_data  = $this->getData($parms);
        $url = $this->url.'/Trade/cancelAllEntrustSheet';
        // var_dump($send_data);
        // die;
        return $this->http_request($url,$send_data);
    }

    //array('apiKey' => '', 'entrustSheetId' => '');
    public function getEntrustSheetInfo($parms){
        $send_data  = $this->getData($parms);
        $url = $this->url.'/Trade/getEntrustSheetInfo';
        return $this->http_request($url,$send_data);
    }

    //array('apiKey' => '', 'pageSize' => '5', 'page' => '1', 'coinFrom' => 'eos', 'coinTo' => 'btc', 'startTime' => '1516535381', 'endTime' => '1532173781')
    public function getUserNowEntrustSheet($parms){
        $send_data  = $this->getData($parms);
        $url = $this->url.'/Trade/getUserNowEntrustSheet';
        return $this->http_request($url,$send_data);
    }

    //array('apiKey' => '', 'pageSize' => '5', 'page' => '1', 'coinFrom' => 'eos', 'coinTo' => 'btc', 'startTime' => '1516535381', 'endTime' => '1532173781')
    public function getUserHistoryEntrustSheet($parms){
        $send_data  = $this->getData($parms);
        $url = $this->url.'/Trade/getUserHistoryEntrustSheet';
        return $this->http_request($url,$send_data);
    }

    protected function getData($data=null){
        $base_arr = array(
            'timeStamp'   =>  time(),
            'nonce'		  =>  $this->getRandomString(6),
        );
        if(isset($data)){
            $send_data = array_merge($base_arr,$data);
        }else{
            $send_data = $base_arr;
        }
        $send_data['sign'] = $this->getSign($send_data);
        return $send_data;
    }

    protected function getSign($data)
    {
        ksort($data);
        $dataStr = '';
        foreach ($data as $k => $v)
        {
            $dataStr .= $k.'='.$v."&";
        }
        return md5(trim($dataStr,"&").$this->secretKey);
    }

    protected function getRandomString($len, $chars=null)
    {
        if (is_null($chars)){
            $chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        }
        mt_srand(10000000*(double)microtime());
        for ($i = 0, $str = '', $lc = strlen($chars)-1; $i < $len; $i++){
            $str .= $chars[mt_rand(0, $lc)];
        }
        return $str;
    }

    protected function http_request($url,$data = null){
        // var_dump($data);
        $curl = curl_init();
        curl_setopt($curl, CURLOPT_URL, $url);
        curl_setopt($curl, CURLOPT_SSL_VERIFYPEER, FALSE);
        curl_setopt($curl, CURLOPT_SSL_VERIFYHOST, FALSE);
        if(!empty($data)){
            curl_setopt($curl,CURLOPT_POST,1);
            curl_setopt($curl,CURLOPT_POSTFIELDS,$data);
        }
        curl_setopt($curl, CURLOPT_RETURNTRANSFER, 1);
        $output = curl_exec($curl);
        curl_close($curl);
        return $output;
    }
}

//example

$bitz = new bitz();

$parms = array('symbol' => 'eos_btc');

print_r($bitz->ticker($parms));



