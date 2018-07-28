<h4>使用前请先下载requests包
```
pip install requests
```

或者

```
git clone git://github.com/kennethreitz/requests.git
python setup.py install
```

<h4>API使用说明


<h5>修改参数
<p> infor.conf文件

```
[key]

Secret = aQmE8U7bxj16KdJcSd3yX8F8Sakd8aO6LopnHXh27d4kWyb28PxcaTvGrajLDvAw
ApiKey = 03fa7eacabb1269afd010306e6fafaaf
TradePw = 123456
URL = https://apiv2.bibidev.com/Market/
tradeURL = https://apiv2.bibidev.com/Trade/
assetsURL = https://apiv2.bibidev.com/Assets/

```
把参数替换成自己
</p>



<p>
testAPI.py文件

```
if __name__=="__main__":
    ticker()
```

调用函数直接添加在主函数下面就可以了
</p>



<h6>终端执行
```
python testAPI.py
```
