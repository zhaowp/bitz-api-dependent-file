#coding:utf-8
from api_mode import BitZ_Mode

#获取牌价
def ticker():
    symbol='eth_btc'  #交易对
    print BitZ_Mode().ticker(symbol)


#获取所有牌价数据
def tickerall():
    print BitZ_Mode().tickerall()


#获取深度数据
def depth():
    symbol='ltc_btc'   #交易对
    print BitZ_Mode().depth(symbol)


# 成交单
def order():
    symbol = 'eth_btc'    #交易对
    print BitZ_Mode().order(symbol)


#获取K线数据
def kline():
    symbol = 'eos_btc'   #交易对
    resolution = '1min'  #时间   分钟：Xmin ,小时：Xhour , 天：Xday
    size = '300'
    print BitZ_Mode().kline(symbol,resolution,size)


#获取交易对信息
def symbolList():
    print BitZ_Mode().symbolList()


#提交委托单
def addEntrustSheet():
    _type = '1'             #买：1  卖：2
    price = '10'            #价格
    number = '1'            #数量
    symbol = 'eth_btc'      #交易对
    print BitZ_Mode().addEntrustSheet(_type,price,number,symbol)


#撤销委托单
def cancelEntrustSheet():
    entrustSheetId='100627'   #委托单ID
    print BitZ_Mode().cancelEntrustSheet(entrustSheetId)


#批量撤销委托单
def cancelAllEntrustSheet():
    trustAllId='100628,100629,100630'   #委托单ID（多个中间逗号隔开）
    print BitZ_Mode().cancelAllEntrustSheet(trustAllId)


#获取个人历史委托单列表
def getUserHistoryEntrustSheet():
    coinFrom = 'eth'                     #代币
    coinTo = 'btc'                       #法币
    _type = '2'                          #买：1  卖：2
    page = '1'                           #要查看的页数
    pageSize = '2'                       #一页多少条数据
    startTime = '2017-06-12 12:00:00'    #开始时间
    endTime = '2018-06-08 12:00:00'      #结束时间
    print BitZ_Mode().getUserHistoryEntrustSheet(coinFrom,coinTo,_type,page,pageSize,startTime,endTime)


#获取当前委托
def getUserNowEntrustSheet():
    coinFrom = 'eth'                     #代币
    coinTo = 'btc'                       #法币
    _type = '2'                          #买：1  卖：2
    page = '1'                           #要查看的页数
    pageSize = '2'                       #一页多少条数据
    startTime = '2017-06-12 12:00:00'    #开始时间
    endTime = '2018-06-08 12:00:00'      #结束时间
    print BitZ_Mode().getUserNowEntrustSheet(coinFrom,coinTo,_type,page,pageSize,startTime,endTime)


#获取委托单详情
def getEntrustSheetInfo():
    entrustSheetId = '100627'           #委托单ID
    _type = '2'                         #买：1  卖：2
    print BitZ_Mode().getEntrustSheetInfo(entrustSheetId,_type)


#获取用户所有资产
def getUserAssets():
    print BitZ_Mode().getUserAssets()

if __name__=="__main__":
    ticker()
    tickerall()
    depth()
    order()
    kline()
    symbolList()
    addEntrustSheet()
    cancelEntrustSheet()
    cancelAllEntrustSheet()
    getUserHistoryEntrustSheet()
    getUserNowEntrustSheet()
    getEntrustSheetInfo()
    getUserAssets()