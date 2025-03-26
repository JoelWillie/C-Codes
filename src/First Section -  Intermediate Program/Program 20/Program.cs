using System;

class Program
{
    static void Main()
    {
        string Name, Resp, MostExpensiveName = "";
        double Price, HighestPrice = 0;

        do
        {
            Console.WriteLine("Please enter the name and price of an item");
            Name = Console.ReadLine();
            Price = double.Parse(Console.ReadLine());

            if (Price > HighestPrice)
            {
                HighestPrice = Price;
                MostExpensiveName = Name;
            }

            Console.WriteLine("Do you have more items to be processed? Yes/No");
            Resp = Console.ReadLine();
        } while (Resp == "Yes");

        Console.WriteLine("The most expensive item is " + MostExpensiveName);
        Console.WriteLine("The highest price seen is " + HighestPrice);
    }
}