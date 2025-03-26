using System;

class Program
{
    static void Main()
    {
        int Num, CountOdd = 0, CountEven = 0;
        char Resp;

        do
        {
            Console.WriteLine("Please enter a positive integer from your list");
            Num = int.Parse(Console.ReadLine());

            if (Num % 2 == 0)
            {
                CountEven = CountEven + 1;
            }
            else
            {
                CountOdd = CountOdd + 1;
            }

            Console.WriteLine("Do you have more positive integers? Y/N");
            Resp = Console.ReadLine()[0];
        } while (Resp == 'Y');

        Console.WriteLine(CountOdd + " odd integers were counted");
        Console.WriteLine(CountEven + " even integers were counted");
    }
}