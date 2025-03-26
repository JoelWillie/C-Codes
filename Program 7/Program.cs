using System;

class Program
{
    static void Main()
    {
        double Mark;

        Console.WriteLine("Enter your test score");
        Mark = double.Parse(Console.ReadLine());

        if (Mark >= 65)
        {
            Console.WriteLine("You have passed.....");
        }
        else
        {
            Console.WriteLine("You have failed......");
        }
    }
}