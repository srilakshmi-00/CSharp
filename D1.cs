//multicasting

using System;
class D1
{
public delegate double rect(double height , double width);
public double area(double height , double width)
{
return (height*width);
}
public double perimeter(double height , double width)
{
return (2*(height+width));
}
static void Main(string[] args)
{
D1 d=new D1();
rect r=new rect(d.area);
rect r1=new rect(d.perimeter);
Console.WriteLine(r.Invoke(4.5,7.8));
Console.WriteLine(r1.Invoke(4.8,7.6));
}
}