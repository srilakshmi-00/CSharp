using System;
abstract class Student{
int marks;
string name;
int roll;
string location="gudivada";
static string course="science";
static int backlogs;

protected abstract void Marks(int tel,int hin,int eng,int mat);
protected abstract void Percentage(int p);
protected void Details(string n ,int r )
{
Console.WriteLine("details of the student name:"+n);
Console.WriteLine("details of the student rollno:"+r);
}
protected void Location()
{
Console.WriteLine("location of the student: "+location);
}
protected static void Courses()
{
Console.WriteLine("courses of the student: "+course);
}
protected static void Backlogs(int b)
{
Console.WriteLine("backlogs of the student: "+b);
}
}




class Test6:Student{
protected override void Marks(int tel,int hin,int eng,int mat)
{
Console.WriteLine("Telugu marks "+tel);
Console.WriteLine("Hindi marks "+hin);
Console.WriteLine("English marks "+eng);
Console.WriteLine("Maths marks "+mat);
}
protected override void Percentage(int p)
{
Console.WriteLine("percentage is "+ p);
}

static void Main(String[] args)
{
Test6 s=new Test6();
s.Marks(95,90,85,80);
s.Percentage(80);
s.Details("sri",29);
s.Location();
Test6.Courses();
Test6.Backlogs(2);

}
}



