using System;
interface I1
{
	void Show();
}
class C1
{
	public void Show1()
{
        Console.WriteLine("c");
}
class Test7:C1,I1
{
	public void Show()
	{
	  Console.WriteLine("code");
	}
public static void Main(string[] args)
{
Test7 t1=new Test7();
t1.Show();
t1.Show1();
}
}
}