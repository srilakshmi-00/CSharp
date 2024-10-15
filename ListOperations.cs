using System;
using System.Collections;
class ListOperations
{
public static void Main(string[] args)
{  
Console.WriteLine("enter no.of elements you want to add:");
int n=Convert.ToInt32(Console.ReadLine());
ArrayList arr=new ArrayList();
for(int i=0;i<n;i++)
{
Console.WriteLine("enter the elements:");
int b=Convert.ToInt32(Console.ReadLine());
arr.Add(b);
}
Console.WriteLine("Elements in the list:");
foreach (int element in arr)
        {
            Console.WriteLine(element);
}
}
}
