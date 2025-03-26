using System;

class Program
{
    static void Main()
    {
        int Num, Sum = 0, Counter;
        double Avg;

        for (Counter = 1; Counter <= 10; Counter++)
        {
            Console.WriteLine("Please enter an integer");
            Num = int.Parse(Console.ReadLine());
            Sum = Sum + Num;
        }

        Avg = Sum / 10.0;

        Console.WriteLine("The sum of your 10 integers is " + Sum);
        Console.WriteLine("The average of your 10 integers is " + Avg);
    }
}