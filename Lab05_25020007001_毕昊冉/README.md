# Lab05 科创展人员与采集缓存建模

姓名：毕昊冉　学号：25020007001

使用 C# 和 .NET 8 实现两个独立控制台项目：人员职责与多态、采集记录缓存与复制

## 文件结构

```text
Lab05_25020007001_毕昊冉/
├─ Lab05(one)/
│  ├─ Lab05.sln / Lab05.csproj
│  └─ Program.cs
├─ Lab05(two)/
│  ├─ Lab05(second).sln / Lab05(second).csproj
│  └─ Program.cs
├─ Lab05_实验报告_25020007001.docx
└─ README.md
```

## 编译运行

需要 .NET 8 SDK 或更高版本，也可使用支持 .NET 8 的 Visual Studio 分别打开两个解决方案。在本目录下运行：

```powershell
dotnet run --project 'Lab05(one)/Lab05.csproj'
dotnet run --project 'Lab05(two)/Lab05(second).csproj'
```

## 人员职责与多态

`ExpoMember` 是基类，`Guide` 和 `Technician` 重写 `Print`。主程序先直接调用，再通过 `List<ExpoMember>` 遍历调用；两种对象分别输出各自的语言或技术专长。程序还使用接口引用调用值班和维修方法

## 缓存复制与测试

任务二使用容量为 5 的采集缓存和容量为 4 的备份缓存，向采集缓存写入三条记录后复制到备份。实际运行显示两边内容一致、`Used` 均为 3。备份缓存一次写入两条失败并保留 3 条，随后写入一条成功至 4 条，满后再写入失败

主程序还演示含空白记录的批次失败、空数组成功且不改变数据、`Read(0)` 返回空数组，以及负数和超过已用条数的读取被捕获。写入先检查整批再追加；读取返回新数组，不删除源记录

## 提交与资料说明

资料：`Lab5_科创展人员与采集缓存建模.pdf`、`微软官方.NET开发文档`，AI 辅助用于审查代码、整理报告排版和 README排版
