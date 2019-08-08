# Template

<a name="Template"></a>
# 1. GrpcServiceTemplate<br />

- 源码地址：[https://github.com/overtly/template.git](https://github.com/overtly/template.git)
- identity：Overt.GrpcTemplate.Service v 1.0.1

<a name="2f085113"></a>
#### （1）安装
> dotnet new -i Overt.GrpcTemplate.Service


<a name="1d603c30"></a>
#### （2）查看
> dotnet new -l

![image.png](https://cdn.nlark.com/yuque/0/2019/png/186782/1565257402246-18c4c915-062b-4bcd-9618-7351bc4b4e33.png#align=left&display=inline&height=562&name=image.png&originHeight=562&originWidth=886&size=46957&status=done&width=886)

可以看到存在 OvertCoreGrpcService的一项存在，该项的identity为Overt.GrpcTemplate.Service


<a name="51116d84"></a>
#### （3）卸载
> dotnet new -u Overt.GrpcTemplate.Service


<a name="da45e78c"></a>
#### （4）使用
> // 注意参数，使用一下命令查看参数
> dotnet new OvertCoreGrpcService -h

![image.png](https://cdn.nlark.com/yuque/0/2019/png/186782/1565257440213-7f98c5b5-254d-45a4-841b-2f611eec6069.png#align=left&display=inline&height=562&name=image.png&originHeight=562&originWidth=886&size=57003&status=done&width=886)

```csharp
-na: 代表命名空间，[namespace].Service，中间的部分
-s: 代表的protobuf文件中的服务名称定义，必须为英文，无特殊字符
-se: 代表的是这个服务启动后注册到Consul的名称，即配置文件中的Name，一般为整个服务命名空间去除点，Overt.Grpc.Service => OvertGrpcService
-p: 代表的是这个服务启动占用的端口，即配置文件中的Port

// 示例
dotnet new OvertCoreGrpcService -na Overt.GrpcTest -s GrpcTestService -se OvertGrpcTestService -p 10001
```

**最终结果：**

![](https://cdn.nlark.com/yuque/0/2018/png/186782/1543215369051-523eddb4-091c-4c44-92c7-d4e51af361b1.png#width=703#align=left&display=inline&height=181&originHeight=181&originWidth=703&status=done&width=703)

**使用PowerShell执行init.ps1文件，修改文件夹名称**


<a name="67cb4465"></a>
### 2. TemplateService

- 源码地址：[https://github.com/overtly/template.git](https://github.com/overtly/template.git)
- identity：Overt.Template.Service v 1.0.0

<a name="2f085113-1"></a>
#### （1）安装
> dotnet new -i Overt.Template.Service


<a name="1d603c30-1"></a>
#### （2）查看
> dotnet new -l

![image.png](https://cdn.nlark.com/yuque/0/2019/png/186782/1565257468588-e7a037d3-0f1b-4f27-8856-47a64b94081a.png#align=left&display=inline&height=562&name=image.png&originHeight=562&originWidth=886&size=47292&status=done&width=886)

可以看到存在 OvertCoreService的一项存在，该项的identity为Overt.Template.Service

<a name="51116d84-1"></a>
#### （3）卸载
> dotnet new -u Overt.Template.Service


<a name="da45e78c-1"></a>
#### （4）使用
> // 注意参数，使用一下命令查看参数
> dotnet new OvertCoreService -h

![image.png](https://cdn.nlark.com/yuque/0/2019/png/186782/1565257482723-3e7d3f17-f75f-4030-b965-96f50fc3d204.png#align=left&display=inline&height=319&name=image.png&originHeight=319&originWidth=904&size=37614&status=done&width=904)

```csharp
-na: 代表命名空间，[namespace].Service，中间的部分

// 示例
dotnet new OvertCoreService -na Overt.Test
```

**最终结果：**

![](https://cdn.nlark.com/yuque/0/2018/png/186782/1543215445020-b54de14a-f267-4cb0-8754-bc694302125e.png#width=721#align=left&display=inline&height=157&originHeight=157&originWidth=721&status=done&width=721)

**使用PowerShell执行init.ps1文件，修改文件夹名称**
