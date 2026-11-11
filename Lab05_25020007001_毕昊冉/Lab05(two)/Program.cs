using System;
using System.Data;

namespace Lab05
{
    internal class Pragram
    {
        public interface IRecordDevice
        {
            string Serial { get; }
            public void Print();
        }

        abstract public class RecordBuffer : IRecordDevice
        {
            private string _serial;

            protected List<string> data = new List<string>();
            public int Capacity { get; }
            public int Used => data.Count;//不允许外部任意赋值,但是只读的怎么样可以让下面Add函数正常自增

            public string Serial => _serial;

            public RecordBuffer(string serial, int capacity)
            {
                if (capacity <= 0)
                    throw new ArgumentOutOfRangeException(nameof(capacity));    //如何抛出异常
                _serial = serial;
                Capacity = capacity;
            }

            public void Print()
            {
                Console.WriteLine($"Serial: {Serial}, Capacity: {Capacity}, Used: {Used}");
            }

            protected bool canAdd(string[] records)
            {
                if (records == null || records.Length > Capacity - Used)
                {
                    return false;
                }
                foreach (string record in records)
                {
                    if (string.IsNullOrWhiteSpace(record))
                        return false;
                }
                return true;
            }

            protected void Add(string[] record)
            {
                data.AddRange(record);  //使用Addrange可以直接添加到List中不用循环,因此Used可以一直只读
            }

            abstract public bool Write(string[] records);
            abstract public string[] Read(int count);
        }

        public class SensorBuffer : RecordBuffer
        {
            public double SampleRate;

            public SensorBuffer(string serial, int capacity, double sampleRate)
                :base (serial,capacity)
            {
                SampleRate = sampleRate;
            }

            public override bool Write(string[] records)
            {
                if(!(canAdd(records)))
                {
                    Console.WriteLine("采集缓存写入失败");
                    return false;
                }
                Add(records);
                Console.WriteLine("采集缓存写入成功");
                return true;
            }

            public override string[] Read(int count)
            {
                if (count== 0)
                {
                    return new string[0];
                }
                if (count < 0 || count >Used)
                {
                    throw new ArgumentOutOfRangeException("count", "Count must be between 0 and the number of used records.");
                }   //怎么样给出明确错误，参数异常表达如何写（查询）
                Console.WriteLine("采集缓存读取成功");
                string[] result = data.GetRange(0, count).ToArray();
                return result;
            }
        }

        public class  BackupBuffer : RecordBuffer
        {
            public string Location;

            public BackupBuffer(string serial, int capacity, string location)
                : base(serial, capacity)
            {
                Location = location;
            }

            public override bool Write(string[] records)
            {
                if (!(canAdd(records)))
                {
                    Console.WriteLine("备份缓存写入失败");
                    return false;
                }
                Add(records);
                Console.WriteLine("备份缓存写入成功");
                return true;
            }

            public override string[] Read(int count)
            {
                if (count == 0)
                {
                    return new string[0];
                }
                if (count < 0 || count > Used)
                {
                    throw new ArgumentOutOfRangeException("count","Count必须在0和被用过的数之间");
                }
                Console.WriteLine("备份缓存读取成功");
                string[] result = data.GetRange(0, count).ToArray();    //如何写入备份中
                return result;
            }
        }

        static void Main(string[] args)
        {
            RecordBuffer sensor = new SensorBuffer("25020007001-SENSOR", 5, 1.0);
            RecordBuffer backup = new BackupBuffer("25020007001-BACKUP", 4, "备份");

            void Show(RecordBuffer buffer, bool result) //用于测试是否成功的函数
            {
                Console.WriteLine($"{(result ? "成功" : "失败")}");
                buffer.Print();
            }

            string[] records = { "温度21.5", "湿度60", "压力101.2" };
            Show(sensor, sensor.Write(records));
            string[] copy = sensor.Read(3);
            Show(backup, backup.Write(copy));
            Console.WriteLine($"采集内容：、{sensor.Read(sensor.Used)}");
            Console.WriteLine($"备份内容：、{backup.Read(backup.Used)}");
            sensor.Print();
            backup.Print();
            Console.WriteLine($"复制内容一致：{copy.SequenceEqual(backup.Read(backup.Used))}");    //如何检验对应的内容一致

            Show(backup, backup.Write(new[] { "记录4", "记录5" }));
            Show(backup, backup.Write(new[] { "记录4" }));
            Show(backup, backup.Write(new[] { "记录5" }));
            Show(sensor, sensor.Write(new[] { "有效记录", "  " }));
            Show(sensor, sensor.Write(Array.Empty<string>()));
            Console.WriteLine($"Read(0)返回条数：{sensor.Read(0).Length}");

            foreach (int count in new[] { -1, sensor.Used + 1 })
            {
                try
                {
                    sensor.Read(count);
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine($"Read({count})超出范围，已捕获参数异常");
                }
            }
                //如何测试超范围读取
            Console.WriteLine();
            sensor.Print();
            backup.Print();
        }
    }
}

