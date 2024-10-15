//reflection

using System;
using System.Reflection;
public class R2
{
public void M1(string a){
Console.WriteLine(a);
}
}
class R1{
static void Main(string[] args){
Type type=typeof(R2);   //inspect
MethodInfo info=type.GetMethod("M1");  //create
object ob=Activator.CreateInstance(type);  //modify
info.Invoke(ob,new object[] {"Hi hello"});  //invoke
}
}