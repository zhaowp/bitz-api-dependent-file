#coding:utf-8
from api_mode import BitZ_Mode

#获取牌价
def ticker():
    symbol='bz_usdt'  #交易对
    print BitZ_Mode().ticker(symbol)


#获取所有牌价数据
def tickerall():
    print BitZ_Mode().tickerall()


#获取深度数据
def depth():
    symbol='bz_usdt'   #交易对
    print BitZ_Mode().depth(symbol)


# 成交单
def order():
    symbol = 'uc_eth'    #交易对
    print BitZ_Mode().order(symbol)


#获取K线数据
def kline():
    symbol = 'bz_usdt'   #交易对
    resolution = '1min'  #时间   分钟：Xmin ,小时：Xhour , 天：Xday
    size = '300'
    toTime = '2018-07-27 20:53:00'  #获取toTime时间前的数据
    print BitZ_Mode().kline(symbol,resolution,size,toTime=toTime)


#获取交易对信息
def symbolList():
    print BitZ_Mode().symbolList()


#获取当前法币汇率信息
def currencyRate():
    print BitZ_Mode().currencyRate()


#获取虚拟货币法币汇率信息
def currencyCoinRate():
    print BitZ_Mode().currencyCoinRate()


#获取币种对应汇率信息
def coinRate():
    print BitZ_Mode().coinRate()


#提交委托单
def addEntrustSheet():
    _type = '2'             #买：1  卖：2
    price = '10'            #价格
    number = '100'            #数量
    symbol = 'bz_usdt'      #交易对
    print BitZ_Mode().addEntrustSheet(_type,price,number,symbol)


#撤销委托单
def cancelEntrustSheet():
    entrustSheetId='677582069'   #委托单ID
    print BitZ_Mode().cancelEntrustSheet(entrustSheetId)


#批量撤销委托单
def cancelAllEntrustSheet():
    trustAllId='677579845,662188888'   #委托单ID（多个中间逗号隔开）
    print BitZ_Mode().cancelAllEntrustSheet(trustAllId)


#获取个人历史委托单列表
def getUserHistoryEntrustSheet():
    coinFrom = 'bz'                     #代币
    coinTo = 'usdt'                       #法币
    # _type = '2'                          #买：1  卖：2  默认：返回全部
    page = '1'                           #要查看的页数
    pageSize = '4'                       #一页多少条数据
    startTime = '2017-06-12 12:00:00'    #开始时间
    endTime = '2018-06-08 12:00:00'      #结束时间
    print BitZ_Mode().getUserHistoryEntrustSheet(coinFrom,coinTo,page,pageSize,startTime,endTime)


#获取当前委托
def getUserNowEntrustSheet():
    coinFrom = 'ltc'                     #代币
    coinTo = 'btc'                       #法币
    # _type = '2'                          #买：1  卖：2   默认：返回全部
    page = '1'                           #要查看的页数
    pageSize = '2'                       #一页多少条数据
    startTime = '2017-06-12 12:00:00'    #开始时间
    endTime = '2018-06-08 12:00:00'      #结束时间
    print BitZ_Mode().getUserNowEntrustSheet(coinFrom,coinTo,page,pageSize,startTime,endTime)


#获取委托单详情
def getEntrustSheetInfo():
    entrustSheetId = '662120573'           #委托单ID
    print BitZ_Mode().getEntrustSheetInfo(entrustSheetId)


#获取用户所有资产
def getUserAssets():
    print BitZ_Mode().getUserAssets()

if __name__=="__main__":
    # ticker()
    # tickerall()
    # depth()
    # order()
    # kline()
    # symbolList()
    currencyRate()
    currencyCoinRate()
    coinRate()
    # addEntrustSheet()
    # cancelEntrustSheet()
    # cancelAllEntrustSheet()
    # getUserHistoryEntrustSheet()
    # getUserNowEntrustSheet()
    # getEntrustSheetInfo()
    # getUserAssets()
