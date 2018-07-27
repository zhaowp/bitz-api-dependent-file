# 使用说明
VS 打开 BitzRestApi.csproj 工程文件

BitzApiRestClient.cs 为 c# api实现类

调用交易类接口前，请把以下参数配置好

```
        String apiKey 		= ""; // Bit.com 用户中心 获得
        String secretKey 	= ""; // Bit.com 用户中心 获得
        String tradePwd 	= ""; // 需要下单交易时必须传
```

运行查看演示






# Demo需要添加JSON解析包
```
// VS 点击工具 - NuGet包管理器 - 程序包管理控制台，输入下面命令: 
Install-Package Newtonsoft.Json 
```