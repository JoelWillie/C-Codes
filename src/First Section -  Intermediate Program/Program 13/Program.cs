using System;

class Program
{
    static void Main()
    {
        double Price, TotalP = 0, FinalBill, Tax;
        string Resp;

        Console.WriteLine("Do you have items to be processed Yes/No?");
        Resp = Console.ReadLine();

        while (Resp == "Yes")
        {
            Console.WriteLine("Enter an item price");
            Price = double.Parse(Console.ReadLine());
            TotalP = TotalP + Price;

            Console.WriteLine("Do you have more items to be processed Yes/No?");
            Resp = Console.ReadLine();
        }

        Tax = TotalP * 0.02;
        FinalBill = TotalP + Tax;

        Console.WriteLine("The results are: " + TotalP + ", " + Tax + ", " + FinalBill);
    }
}