Console.WriteLine("请输入你的学号：");
string? studentid = Console.ReadLine();

char lastnum = '0';

for(int i = studentid.Length -1; i >= 0; i--)
{
    if (studentid[i] >= '0' && studentid[i] <= '9')
    {
        lastnum = studentid[i]; 
        break;
    }
}

int d = lastnum - '0';

Console.WriteLine();
Console.WriteLine($"学号末尾的数字d = {d}");
Console.WriteLine();

int x = 4 + d;
int y = 10 + d;
Console.WriteLine("(x++<y)&&(--y==x)");

bool result1 = (x++ < y) && (--y == x);
Console.WriteLine($"结果为：{result1}");
Console.WriteLine($"执行后x = {x}");
Console.WriteLine($"执行后y = {y}");

Console.WriteLine();

Console.WriteLine("(++x<y)|| (y-- == x)");

x = 4 + d;
y = 10 + d;

bool result2 = (++x < y) || (y-- == x);
Console.WriteLine($"结果为：{result2}");
Console.WriteLine($"执行后x = {x}");
Console.WriteLine($"执行后y = {y}");

