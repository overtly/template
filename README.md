# Template

<a name="8mkSN"></a>
### 1. Overt.GrpcTemplate.Service

- 源码地址：[https://github.com/mojinxun/template.git](https://github.com/mojinxun/template.git)
- identity：Overt.GrpcTemplate.Service v 1.0.4

<a name="YhSs6"></a>
#### （1）安装
> dotnet new -i Overt.GrpcTemplate.Service


<a name="6yxo7"></a>
#### （2）查看
> dotnet new -l

![image.png](https://cdn.nlark.com/yuque/0/2019/png/186782/1565338570776-12e7c8d4-0abb-4e59-ab01-c2fe137d827d.png#align=left&display=inline&height=501&name=image.png&originHeight=501&originWidth=762&size=28766&status=done&width=762)

可以看到存在 OvertGrpcTemplate的一项存在，该项的identity为Overt.GrpcTemplate.Service


<a name="51116d84"></a>
#### （3）卸载
> dotnet new -u Overt.GrpcTemplate.Service


<a name="da45e78c"></a>
#### （4）使用
> // 注意参数，使用一下命令查看参数
> dotnet new OvertGrpcTemplate -h

![image.png](https://cdn.nlark.com/yuque/0/2019/png/186782/1565257440213-7f98c5b5-254d-45a4-841b-2f611eec6069.png#align=left&display=inline&height=562&name=image.png&originHeight=562&originWidth=886&size=57003&status=done&width=886)

```csharp
-na: 代表命名空间，[namespace].Service，中间的部分
-s: 代表的protobuf文件中的服务名称定义，必须为英文，无特殊字符
-se: 代表的是这个服务启动后注册到Consul的名称，即配置文件中的Name，一般为整个服务命名空间去除点，Overt.Grpc.Service => OvertGrpcService
-p: 代表的是这个服务启动占用的端口，即配置文件中的Port

// 示例
dotnet new OvertGrpcTemplate -na Overt.GrpcTest -s GrpcTestService -se OvertGrpcTestService -p 10001
```

**最终结果：**<br />![image.png](https://cdn.nlark.com/yuque/0/2019/png/186782/1565338672226-8081373a-a21d-46b7-aeb1-106014802379.png#align=left&display=inline&height=185&name=image.png&originHeight=185&originWidth=622&size=21977&status=done&width=622)

- **使用PowerShell执行init.ps1文件，修改文件夹名称**
- **如果该服务需要安装为Window服务，则再执行topshelf.ps1**


<a name="67cb4465"></a>
### 2. Overt.Template.Service

- 源码地址：[https://github.com/overtly/template.git](https://github.com/overtly/template.git)
- identity：Overt.Template.Service v 1.0.4

<a name="2f085113-1"></a>
#### （1）安装
> dotnet new -i Overt.Template.Service


<a name="1d603c30-1"></a>
#### （2）查看
> dotnet new -l

![image.png](https://cdn.nlark.com/yuque/0/2019/png/186782/1565338598907-a228dee6-808f-4fc1-95ea-16ad49e99d3f.png#align=left&display=inline&height=547&name=image.png&originHeight=547&originWidth=757&size=31750&status=done&width=757)

可以看到存在 OvertTemplate的一项存在，该项的identity为Overt.Template.Service

<a name="51116d84-1"></a>
#### （3）卸载
> dotnet new -u Overt.Template.Service


<a name="da45e78c-1"></a>
#### （4）使用
> // 注意参数，使用一下命令查看参数
> dotnet new OvertTemplate -h

![image.png](https://cdn.nlark.com/yuque/0/2019/png/186782/1565257482723-3e7d3f17-f75f-4030-b965-96f50fc3d204.png#align=left&display=inline&height=319&name=image.png&originHeight=319&originWidth=904&size=37614&status=done&width=904)

```csharp
-na: 代表命名空间，[namespace].Service，中间的部分

// 示例
dotnet new OvertTemplate -na Overt.Test
```

**最终结果：**

![image.png](https://cdn.nlark.com/yuque/0/2019/png/186782/1565338775709-c83d75ce-3de4-4f80-bab0-5691f49add5b.png#align=left&display=inline&height=168&name=image.png&originHeight=168&originWidth=654&size=21213&status=done&width=654)

- **使用PowerShell执行init.ps1文件，修改文件夹名称**
- **如果该服务需要安装为Window服务，则再执行topshelf.ps1**
