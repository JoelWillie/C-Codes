using System;

class Program
{
    static void Main()
    {
        double Price, Discount, GCT, TotalPrice = 0, TotalAfterDis, TotalAfterGCT;
        int Count;

        for (Count = 1; Count <= 15; Count++)
        {
            Console.WriteLine("Enter an item price");
            Price = double.Parse(Console.ReadLine());
            TotalPrice = TotalPrice + Price;
        }

        Discount = TotalPrice * 0.2;
        TotalAfterDis = TotalPrice - Discount;
        GCT = TotalAfterDis * 0.165;
        TotalAfterGCT = TotalAfterDis + GCT;

        Console.WriteLine("Please pay " + TotalAfterGCT);
    }
}