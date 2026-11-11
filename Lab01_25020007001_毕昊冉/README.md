# Lab01 校园科创展的三个应用入口

本目录是《Lab01 校园科创展的三个应用入口》的提交内容，包含三个相互独立、可单独运行的项目：

| 项目            | 类型                  | 目标框架                 | 作用                           |
| ------------- | ------------------- | -------------------- | ---------------------------- |
| `ExpoConsole` | 控制台应用               | .NET 8.0             | 输出校园科创展服务台欢迎页                |
| `ExpoDesktop` | Windows Forms 应用    | .NET Framework 4.7.2 | 根据输入的展位名称生成欢迎提示              |
| `ExpoApi`     | ASP.NET Core 最小 API | .NET 8.0             | 提供 `GET /lab1/status` 服务状态接口 |

三个项目使用同一份身份信息：

- 学号：`25020007001`（按字符串保存，保留前导零）
- 展区名称：`智能制造`

> 三个项目之间没有代码引用，也不需要数据库或网络互通，各自独立编译、独立运行。

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

## 二、目录结构

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

## 三、各项目启动方式

### 1. ExpoConsole（控制台欢迎页）

```powershell
cd ExpoConsole
dotnet run
```

运行后依次输出三行：

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

操作步骤：在文本框中输入展位名称（例如 `水下机器人展示`），点击 **生成提示**，结果标签显示：

```
欢迎参观【智能制造】展区的【水下机器人展示】展位
```

再次修改文本框内容（例如改为 `海洋传感器展示`）并点击按钮，标签会更新为本次输入的内容；输入为空或只含空格时会弹出 `请输入展位名称。` 提示，并保留上一次的有效结果。

窗体标题为 `25020007001 科创展提示工具`。

### 3. ExpoApi（服务状态接口）

```powershell
cd ExpoApi
dotnet run
```

程序按 `Properties/launchSettings.json` 中的 `http` 配置监听：

| 项目   | 值                       |
| ---- | ----------------------- |
| 监听地址 | `http://localhost:5041` |
| 路由   | `GET /lab1/status`      |

**API 测试地址：<http://localhost:5041/lab1/status>**

用浏览器访问，或在另一个终端中执行：

```powershell
curl http://localhost:5041/lab1/status
```

期望结果：

```
HTTP/1.1 200 OK
Content-Type: text/plain; charset=utf-8

EXPO-READY|25020007001|智能制造
```

> 端口以 `Properties/launchSettings.json` 的实际配置为准；如果 5041 被占用，可以在该文件中修改 `applicationUrl`，或运行时用 `dotnet run --urls http://localhost:5041` 指定。

---

## 四、基础任务完成情况

| 任务           | 项目            | 状态  |
| ------------ | ------------- | --- |
| 基础任务一 控制台欢迎页 | `ExpoConsole` | 已完成 |
| 基础任务二 展位提示窗体 | `ExpoDesktop` | 已完成 |
| 基础任务三 服务状态接口 | `ExpoApi`     | 已完成 |

拓展任务一（窗体处理空串与仅含空格的输入，提示后不覆盖上一次有效结果）也已实现。
