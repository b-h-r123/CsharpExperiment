using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Lab06
{
    internal class Program
    {
        public delegate void NoticeWriter(string message);
        public delegate void Noticehandler(string message);

        //static string path = @"D:\Logs\notice_25020007001.txt";   固定路径不够灵活，日志路径修改
        static string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs","notices_25020007001.txt");

        public static void ShowNotice(string message)
        {
            Console.WriteLine($"Notice: {message}");
        }

        public static void AppendNotice(string message)
        {
            //文件写入失败说明错误原因
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(path));
                File.AppendAllText(path, $"{message}\n", Encoding.UTF8);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"写入失败：{ex.Message}");
            }

        }

        public static void runNotice()
        {
            NoticeWriter writer = ShowNotice;
            writer += AppendNotice;

            Console.WriteLine("广播1：");
            writer("message one");

            Console.WriteLine("广播2：");
            writer("message two");

            Console.WriteLine($"日志文件路径：{Path.GetFullPath(path)}");

            writer -= AppendNotice;

            Console.WriteLine("广播3：");
            writer("message three(不写入文件)");
        }

        public class LabNoticeHub
        {   
            public event Noticehandler NoticePublished;
            public void Publish(string message)
            {
                NoticePublished?.Invoke(message);
            }
        }

        public class DisplayTerminal
        {
            private string id;
            private LabNoticeHub hub;
            public DisplayTerminal(string id)
            {
                this.id = id;
            }

            public void notice(string message = "hello!")
            {
                Console.WriteLine($"终端 {id} 收到通知：{message}");
            }

            public void StartListen(LabNoticeHub hub)
            {
                //重复开始监听时，先取消之前的订阅
                if (this.hub != null)
                    return;
                this.hub = hub;
                hub.NoticePublished += notice;
            }

            public void StopListen()
            {
                if(hub == null)
                    return;
                hub.NoticePublished -= notice;
                hub = null;
            }


        }
        static void Main(string[] args)
        {
            Console.WriteLine("任务一：");
            runNotice();

            Console.WriteLine("\n任务二：");
            LabNoticeHub hub = new LabNoticeHub();
            DisplayTerminal A = new DisplayTerminal("A_0001");
            DisplayTerminal B = new DisplayTerminal("B");

            Console.WriteLine("发布N0");
            hub.Publish("N0");
            A.StartListen(hub);
            Console.WriteLine("发布N1");
            hub.Publish("N1");
            B.StartListen(hub);
            Console.WriteLine("发布N2");
            hub.Publish("N2");
            A.StartListen(hub);
            Console.WriteLine("发布N3");
            hub.Publish("N3");
            A.StopListen();
            Console.WriteLine("发布N4");
            hub.Publish("N4");
            A.StopListen();
            B.StopListen();
            Console.WriteLine("发布N5");
            hub.Publish("N5");
        }
    }
}