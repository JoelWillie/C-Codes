using System;

class Program
{
    static void Main()
    {
        int Hrs;
        double GrossWage, NetPay, OneOffTax, OT;

        Console.WriteLine("Please enter the number of hours worked");
        Hrs = int.Parse(Console.ReadLine());

        if (Hrs > 40)
        {
            OT = 350 * 1.5 * (Hrs - 40);
            GrossWage = 40 * 350 + OT;
        }
        else
        {
            OT = 0.0;
            GrossWage = Hrs * 350;
        }

        OneOffTax = GrossWage * 0.27;
        NetPay = GrossWage - OneOffTax;

        Console.WriteLine("Your gross wage is " + GrossWage);
        Console.WriteLine("The one-off tax to be paid is " + OneOffTax);
        Console.WriteLine("Your net wage is " + NetPay);
    }
}