using System;

class Program
{
    static void Main()
    {
        double Sale, TotalSales = 0;
        char Resp;

        do
        {
            Console.WriteLine("How much gas are you buying?");
            Sale = double.Parse(Console.ReadLine());
            TotalSales = TotalSales + Sale;

            Console.WriteLine("Do you have more customers? Y/N");
            Resp = Console.ReadLine()[0];
        } while (Resp == 'Y');

        Console.WriteLine("My total sales for the day is " + TotalSales);
    }
}