using System;

class Program
{
    static void Main()
    {
        double OldSal, NewSal, Increase;

        Console.WriteLine("Please enter your present salary");
        OldSal = double.Parse(Console.ReadLine());

        Increase = OldSal * 0.15;
        NewSal = OldSal + Increase;

        Console.WriteLine("Your new salary is " + NewSal);
    }
}