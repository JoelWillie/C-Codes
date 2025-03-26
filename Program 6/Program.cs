using System;

class Program
{
    static void Main()
    {
        double Price, Discount = 0.0;

        Console.WriteLine("Please enter your item price");
        Price = double.Parse(Console.ReadLine());

        if (Price >= 10000)
        {
            Discount = Price * 0.12;
        }

        Console.WriteLine("Your discount for the selected item is $" + Discount);
    }
}