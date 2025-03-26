using System;

class Program
{
    static void Main()
    {
        double Price1, Price2, Price3, Price4, Price5, Sub_Total, GCT, FinalBill;

        Console.WriteLine("Please enter the price of item 1");
        Price1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the price of item 2");
        Price2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the price of item 3");
        Price3 = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the price of item 4");
        Price4 = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the price of item 5");
        Price5 = double.Parse(Console.ReadLine());

        Sub_Total = Price1 + Price2 + Price3 + Price4 + Price5;
        GCT = Sub_Total * 0.165;
        FinalBill = Sub_Total + GCT;

        Console.WriteLine("Please pay $" + FinalBill);
    }
}