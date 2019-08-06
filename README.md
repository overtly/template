# Template

<a name="gn3gvm"></a>
### [](#gn3gvm)1. GrpcServiceTemplate

> 源码地址：[https://github.com/mojinxun/template.git](https://github.com/mojinxun/template.git)
> 
> identity：Overt.GrpcTemplate.Service v 1.0.0


<a name="q34oyk"></a>
#### [](#q34oyk)（1）安装
> dotnet new -i Overt.GrpcTemplate.Service


<a name="4pgrpu"></a>
#### [](#4pgrpu)（2）查看
> dotnet new -l


![](https://cdn.nlark.com/yuque/0/2018/png/186782/1543211226316-9f933dbc-1d42-4137-ba6c-12521bf8c77c.png#width=827)

可以看到存在 OvertCoreGrpcService的一项存在，该项的identity为Overt.GrpcTemplate.Service

<a name="cnpnnb"></a>
#### [](#cnpnnb)（3）卸载
> dotnet new -u Overt.GrpcTemplate.Service


<a name="lxswcy"></a>
#### [](#lxswcy)（4）使用
> 
> // 注意参数，使用一下命令查看参数
> dotnet new OvertCoreGrpcService -h
> 

![](https://cdn.nlark.com/yuque/0/2018/png/186782/1543211078199-939ca248-be1e-468e-a86d-b6465dcdfb39.png#width=827)


```csharp
-na: 代表命名空间，[namespace].Service，中间的部分
-s: 代表的protobuf文件中的服务名称定义，必须为英文，无特殊字符
-se: 代表的是这个服务启动后注册到Consul的名称，即配置文件中的Name，一般为整个服务命名空间去除点，Overt.Grpc.Service => OvertGrpcService
-p: 代表的是这个服务启动占用的端口，即配置文件中的Port

// 示例
dotnet new OvertCoreGrpcService -na Overt.GrpcTest -s GrpcTestService -se OvertGrpcTestService -p 10001
```


**最终结果：**

![](https://cdn.nlark.com/yuque/0/2018/png/186782/1543215369051-523eddb4-091c-4c44-92c7-d4e51af361b1.png#width=703)

**使用PowerShell执行init.ps1文件，修改文件夹名称**




<a name="85knsx"></a>
### [](#85knsx)2. TemplateService

> 源码地址：[https://github.com/mojinxun/template.git](https://github.com/mojinxun/template.git)
> 
> identity：Overt.Template.Service v 1.0.0


<a name="06g7ih"></a>
#### [](#06g7ih)（1）安装
> dotnet new -i Overt.Template.Service


<a name="3awmsl"></a>
#### [](#3awmsl)（2）查看
> dotnet new -l


![](https://cdn.nlark.com/yuque/0/2018/png/186782/1543211222374-e9cb9d24-654f-4531-ad7f-9202e171ed33.png#width=827)

可以看到存在 OvertCoreService的一项存在，该项的identity为Overt.Template.Service

<a name="8yihpd"></a>
#### [](#8yihpd)（3）卸载
> dotnet new -u Overt.Template.Service


<a name="4lxkpw"></a>
#### [](#4lxkpw)（4）使用
> 
> // 注意参数，使用一下命令查看参数
> dotnet new OvertCoreService -h
> 

![](https://cdn.nlark.com/yuque/0/2018/png/186782/1543211288960-5ad2364b-4ab4-41fd-b494-3987df89494f.png#width=827)


```csharp
-na: 代表命名空间，[namespace].Service，中间的部分

// 示例
dotnet new OvertCoreService -na Overt.Test
```



**最终结果：**

![](https://cdn.nlark.com/yuque/0/2018/png/186782/1543215445020-b54de14a-f267-4cb0-8754-bc694302125e.png#width=721)

**使用PowerShell执行init.ps1文件，修改文件夹名称**
