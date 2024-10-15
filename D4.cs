//multicasting with generic

using System;
using System.Collections.Generic;
delegate T M1<T>(T a, T b);
class D4
{
public static double area(double height , double width)
{
return height*width;
}
public static double perimeter(double height , double width)
{
return 2*(height+width);
}
static void Main(string[] args)
{
M1<double> d1=new M1<double>(area);
M1<double> d2=new M1<double>(perimeter);
Console.WriteLine(d1(1.2,2.3));
Console.WriteLine(d2(3.3,2.2));
}
}