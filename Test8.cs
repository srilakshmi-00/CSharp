using System;
interface I1
{
	void Show();
}
class C1:I1
{
	public virtual void Show()
{
	Console.WriteLine("baby");
}
}
class C2:I1
{
	public void Show()
{
	Console.WriteLine("buggy");
}
}
class Test8:C1
{
	public override void Show(){
	base.Show();
	Console.WriteLine("Bonda");
}
	
public static void Main(string[] args)
{
Test8 t2=new Test8();
t2.Show();
}
}
