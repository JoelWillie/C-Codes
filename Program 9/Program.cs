using System;

class Program
{
    static void Main()
    {
        int Age;

        Console.WriteLine("Please enter your age");
        Age = int.Parse(Console.ReadLine());

        if (Age < 10)
        {
            Console.WriteLine("Join line 1");
        }
        else if (Age <= 25)
        {
            Console.WriteLine("Join line 2");
        }
        else
        {
            Console.WriteLine("Join line 3");
        }
    }
}