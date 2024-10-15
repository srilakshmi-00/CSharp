using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
class Sample5{
static void Main(string[] args)
{
Queue<int> q1=new Queue<int>();
q1.Enqueue(12);
q1.Enqueue(20);
q1.Enqueue(29);
q1.Enqueue(39);
q1.Enqueue(56);
foreach(int y in q1)
{
Console.WriteLine(y);
}
Console.WriteLine(q1.Dequeue());
}
}

