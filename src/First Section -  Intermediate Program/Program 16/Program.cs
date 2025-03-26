using System;

class Program
{
    static void Main()
    {
        double Score, Avg, TotalScore = 0;
        int Count;

        for (Count = 1; Count <= 40; Count++)
        {
            Console.WriteLine("Please enter a maths score");
            Score = double.Parse(Console.ReadLine());
            TotalScore = TotalScore + Score;
        }

        Avg = TotalScore / 40;

        Console.WriteLine("The average maths score for the class is " + Avg);
    }
}