using System;
class D2
{
public delegate int show(int a, int b, int c);
public static int display(int a, int b, int c)
{
return a+b*c;
}
static void Main(string[] args)
{
D2 d=new D2();
show s=display;
Console.WriteLine(s.Invoke(23,3,8));
}
}