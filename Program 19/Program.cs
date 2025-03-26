using System;

class Program
{
    static void Main()
    {
        int Count;
        double MonthlyBill, TotalBill = 0, AvgMonthlyBill;

        for (Count = 1; Count <= 36; Count++)
        {
            Console.WriteLine("Please enter your monthly electricity bill");
            MonthlyBill = double.Parse(Console.ReadLine());
            TotalBill = TotalBill + MonthlyBill;
        }

        AvgMonthlyBill = TotalBill / 36;

        Console.WriteLine("The average monthly bill for the 3 years is " + AvgMonthlyBill);
    }
}