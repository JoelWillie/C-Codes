using System;

class Program
{
    static void Main()
    {
        double Radius, Diameter, Circumference, Area;
        const double pi = 3.14159;

        Console.WriteLine("Please enter the radius of a circle");
        Radius = double.Parse(Console.ReadLine());

        Diameter = 2 * Radius;
        Circumference = 2 * pi * Radius;
        Area = pi * Radius * Radius;

        Console.WriteLine("The diameter of your circle is " + Diameter);
        Console.WriteLine("The circumference of your circle is " + Circumference);
        Console.WriteLine("The area is " + Area);
    }
}