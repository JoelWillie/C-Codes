using System;

class Program
{
    static void Main()
    {
        int Num, Largest, Smallest, Counter;

        Console.WriteLine("Please enter an integer");
        Num = int.Parse(Console.ReadLine());
        Largest = Num;
        Smallest = Num;

        for (Counter = 1; Counter <= 4; Counter++)
        {
            Console.WriteLine("Please enter an integer");
            Num = int.Parse(Console.ReadLine());

            if (Num > Largest)
            {
                Largest = Num;
            }
            if (Num < Smallest)
            {
                Smallest = Num;
            }
        }

        Console.WriteLine("The smallest integer is " + Smallest);
        Console.WriteLine("The largest integer is " + Largest);
    }
}