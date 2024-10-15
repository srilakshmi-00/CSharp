using System;
delegate void change(int n);
class D3{
static int num=12;
public static void add(int p)
{
num+=p;
Console.WriteLine(num);
}
public static void sub(int x)
{
num-=x;
Console.WriteLine(num);
}

static void Main(string[] args)
{
change n=delegate(int a){

};
n=new change(add);
n(3);
n=new change(sub);
n(2);
Console.ReadKey();
}
}