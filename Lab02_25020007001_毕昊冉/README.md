# Lab01：校园科创展的三个应用入口

本项目包含三个独立的小程序，分别用来展示控制台欢迎页、生成展位提示，以及提供一个简单的服务状态接口。

| 项目            | 类型                  | 目标框架                 | 作用                           |
| ------------- | ------------------- | -------------------- | ---------------------------- |
| `ExpoConsole` | 控制台应用               | .NET 8.0             | 输出校园科创展服务台欢迎页                |
| `ExpoDesktop` | Windows Forms 应用    | .NET Framework 4.7.2 | 根据输入的展位名称生成欢迎提示              |
| `ExpoApi`     | ASP.NET Core 最小 API | .NET 8.0             | 提供 `GET /lab1/status` 服务状态接口 |

三个项目中使用的身份信息如下：

- 学号：`25020007001`（按字符串保存，保留前导零）
- 展区名称：`智能制造`

这三个项目彼此独立，不需要数据库，也不依赖彼此的运行状态，可以分别编译和启动。

---

## 一、开发环境

| 项目             | 说明                                  |
| -------------- | ----------------------------------- |
| 操作系统           | Windows 10 / 11 x64                 |
| 开发工具           | Visual Studio 2022、.NET SDK 8.0     |
| 编程语言           | C#                                  |
| 控制台 / Web 目标框架 | .NET 8.0（`net8.0`）                  |
| 桌面目标框架         | .NET Framework 4.7.2（Windows Forms） |
| 字符编码           | 全部源文件统一为 UTF-8 with BOM             |

---

## 二、项目目录

```
Lab1
├─ ExpoConsole/                  控制台欢迎页
│  ├─ ExpoConsole.csproj
│  ├─ ExpoConsole.sln
│  └─ Program.cs
├─ ExpoDesktop/                  展位提示窗体
│  ├─ ExpoDesktop.csproj
│  ├─ ExpoDesktop.sln
│  ├─ Program.cs
│  ├─ Form1.cs / Form1.Designer.cs / Form1.resx
│  └─ Properties/
└─ ExpoApi/                      服务状态接口
   ├─ ExpoApi.csproj
   ├─ ExpoApi.sln
   ├─ Program.cs
   ├─ appsettings.json
   └─ Properties/launchSettings.json
```

---

## 三、如何运行

### 1. ExpoConsole（控制台欢迎页）

```powershell
cd ExpoConsole
dotnet run
```

启动后，控制台会显示：

```
校园科创展服务台
开发者：25020007001
负责展区：智能制造
```

不需要任何输入，程序输出后即结束。

### 2. ExpoDesktop（展位提示窗体）

在 Visual Studio 2022 中打开 `ExpoDesktop/ExpoDesktop.sln` 后按 F5 运行；也可以先编译再用命令行启动：

```powershell
msbuild ExpoDesktop\ExpoDesktop.csproj /p:Configuration=Debug
.\ExpoDesktop\bin\Debug\ExpoDesktop.exe
```

运行窗体后，在文本框里输入一个展位名称，例如 `水下机器人展示`，再点击 **生成提示**。结果区域会显示：

```
欢迎参观【智能制造】展区的【水下机器人展示】展位
```

如果把名称改成 `海洋传感器展示` 再点一次按钮，结果也会跟着更新。若输入框为空或只有空格，程序会提示 `请输入展位名称。`，同时保留上一次成功生成的结果。

窗体标题为 `25020007001 科创展提示工具`。

### 3. ExpoApi（服务状态接口）

```powershell
cd ExpoApi
dotnet run
```

项目默认使用 `Properties/launchSettings.json` 里的 `http` 配置启动服务：

| 项目   | 值                       |
| ---- | ----------------------- |
| 监听地址 | `http://localhost:5041` |
| 路由   | `GET /lab1/status`      |

**API 测试地址：<http://localhost:5041/lab1/status>**

服务启动后，可以直接用浏览器访问，也可以在另一个终端执行：

```powershell
curl http://localhost:5041/lab1/status
```

期望结果：

```
HTTP/1.1 200 OK
Content-Type: text/plain; charset=utf-8

EXPO-READY|25020007001|智能制造
```

实际端口以 `Properties/launchSettings.json` 中的配置为准。如果 5041 已被占用，可以修改其中的 `applicationUrl`，也可以运行 `dotnet run --urls http://localhost:5041` 来指定端口。

---

## 四、任务完成情况

| 任务           | 项目            | 状态  |
| ------------ | ------------- | --- |
| 基础任务一 控制台欢迎页 | `ExpoConsole` | 已完成 |
| 基础任务二 展位提示窗体 | `ExpoDesktop` | 已完成 |
| 基础任务三 服务状态接口 | `ExpoApi`     | 已完成 |

另外，窗体也处理了空输入和只输入空格的情况：程序会给出提示，不会覆盖之前生成的有效结果。
