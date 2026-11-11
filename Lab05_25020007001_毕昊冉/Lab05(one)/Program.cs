using System;
using System.Numerics;
using System.Reflection.Metadata;

namespace Lab05
{
    internal class Program
    {
        public class ExpoMember
        {
            private int _serviceYears;
            public string Name;
            public string Zone;

            public ExpoMember(int serviceYears = 0, string name = "bhr", string zone = "technology")
            {
                _serviceYears = serviceYears;
                this.Name = name;
                this.Zone = zone;
            }

            public virtual void Print()
            {
                Console.WriteLine(_serviceYears);
                Console.WriteLine(Name);
                Console.WriteLine(Zone);
            }
        }

        public interface Ishift
        {
            void AttendShift(string zone);
        }

        public interface Irepair
        {
            void Repair(string deviceName);
        }

        public class Guide : ExpoMember, Ishift
        {
            public string Language;

            public override void Print()
            {
                base.Print();
                Console.WriteLine($"讲解语言{Language}");
            }

            public void AttendShift(string zone)
            {
                this.Zone = zone;
                Console.WriteLine($"{Name}在{zone}值班");
            }

            public Guide(int serviceYears=0, string name= "bhr", string zone = "ai" , string language = "chinese")
                : base(serviceYears,name,zone)  
            {
                this.Language = language;
            }
        }

        public class Technician : ExpoMember, Ishift, Irepair
        {
            private string _specialty;

            public string DeviceName { get; set; }

            public override void Print()
            {
                base.Print();
                Console.WriteLine($"技术专长为{_specialty}");
            }

            public void Repair(string deviceName)
            {
                this.DeviceName = deviceName;
                Console.WriteLine($"{Name}处理设备{deviceName}");
            }

            public void AttendShift(string zone)
            {
                this.Zone = zone;
                Console.WriteLine($"{Name}在{zone}值班");
            }

            public Technician(int serviceYears = 0,string name = "bhr" , string zone="ai" , string specialty = "ai",string deviceName = "computer")
                : base(serviceYears,name,zone)
            {
                _specialty = specialty;
                this.DeviceName = deviceName;
            }
        }

        static void Main( string[] args )
        {
            Guide guide = new Guide(3,"Ryan","ai","chinese");
            Technician technician = new Technician(7,"Jerry","computer","gaming","serve");
            Console.WriteLine("guide:");
            guide.Print();
            Console.WriteLine();
            Console.WriteLine("technician");
            technician.Print();
            Console.WriteLine();
            List<ExpoMember> list = new List<ExpoMember>();
            list.Add(guide);
            list.Add(technician);
            foreach(ExpoMember item in list)
            {
                item.Print();
                Console.WriteLine();
            }
            Console.WriteLine();

            Ishift ishift1 = guide;
            ishift1.AttendShift("科技展区");
            Ishift ishift2 = technician;
            ishift2.AttendShift("水下展区");

            Irepair irepair = technician ;
            irepair.Repair("笔记本");
        }   
    }
}