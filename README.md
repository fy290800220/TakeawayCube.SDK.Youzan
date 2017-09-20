## 介绍
+ 有赞开放平台SDK .net Core 版本
+ 官方.net Framework 版本：https://github.com/ph0ly/open-sdk-csharp

## nuget
```
Install-Package TakeawayCube.SDK.Youzan -Version 1.0.0
```

## 如何使用？（参考README.md）
### 调用youzan.item.create接口

```
Auth auth = new Sign("${app_id}", "${app_secret}");
YZClient yzClient = new DefaultYZClient(auth);
Dictionary<string, object> dict = new System.Collections.Generic.Dictionary<string, object>();
dict.Add("title", "aaaaa");
dict.Add("price", 1.0);
dict.Add("post_fee", 1.0);

List<KeyValuePair<string, string>> files = new List<KeyValuePair<string, string>>();
// 仅作演示用，实际该API不支持传文件，具体参考API说明
files.Add(new KeyValuePair<string, string>("images[]", "/xx/xx/1.jpg"));

var result = yzClient.Invoke("youzan.item.create", "3.0.0", "post", dict, files);
Console.WriteLine(result);
```

### 调用youzan.items.onsale.get接口

```
Auth auth = new Token("xxx");
var result = yzClient.Invoke("youzan.items.onsale.get", "3.0.0", "get", dict, null);
Console.WriteLine(result);
```

