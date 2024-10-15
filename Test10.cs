using System;
interface I1
{
	void Sub();
}
class C1:I1
{
	public void Sub()
{
	Console.WriteLine("I");
}
}
interface I2:I1
{
 	void Sub2();
}
class C2:C1,I2
{
	public void Sub2()
{
	Console.WriteLine("am");
}
	public void Sub3()
{
	Console.WriteLine("sri");
}
}
class Test10:C2
{
	public void  Sub()
{
	Console.WriteLine("lakshmi");
}
static void Main(string[] args)
{
Test10 t=new Test10();
t.Sub();
t.Sub2();
t.Sub3();

}
}	

	