using System;

class Test4
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of people: ");
        int numPeople = Convert.ToInt32(Console.ReadLine());

        int[] ages = new int[numPeople];

        Console.WriteLine("Enter the age of each person:");
        for (int i = 0; i < ages.Length; i++)
        {
            Console.Write("Age of person {0}: ", i + 1);
            ages[i] = Convert.ToInt32(Console.ReadLine());
        }

        int max = ages[0];
        int min = ages[0];

        for (int i = 1; i < ages.Length; i++)
        {
            if (ages[i] > max)
            {
                max = ages[i];
            }
            else if (ages[i] < min)
            {
                min = ages[i];
            }
        }

        Console.WriteLine("Maximum age: " + max);
        Console.WriteLine("Minimum age: " + min);
    }
}