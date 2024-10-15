using System;
interface I1
{
	void Add();
}
interface I2:I1
{
	void Add1();
}
interface I3:I1
{
	void Add2();
}
interface I4:I1
{
	void Add3();
}
class Test9:I2,I3,I4
{
	public void Add()
	{
	Console.WriteLine("myself");
	}
	public void Add1()
	{
	Console.WriteLine("i");
	}
	public void Add2()
	{
	Console.WriteLine("love");
	}

	public void Add3()
	{
	Console.WriteLine("u");
	}
static void Main(string[] args)
	{
	Test9 t=new Test9();
	t.Add();
	t.Add1();
	t.Add2();
	t.Add3();
	}
}



