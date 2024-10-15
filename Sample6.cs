using System;
using System.Collections.Generic;
class Sample6
{
static void Main(string[] args)
{
SortedList<int,string> s1=new SortedList<int,string>();
s1.Add(65,"t1"); 
s1.Add(66,"t2"); 
s1.Add(67,"t3"); 
s1.Add(68,"t4"); 
foreach(KeyValuePair<int,string> x in s1)
{
Console.WriteLine(x);
}
}
}