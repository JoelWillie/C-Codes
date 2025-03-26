using System;

public class Circle
{
    public double radius;

    // Method to get radius from user
    public void GetRadius()
    {
        Console.WriteLine("Enter the radius of the circle: ");
        radius = double.Parse(Console.ReadLine());
    }

    // Method to calculate area
    private double CalculateArea()
    {
        double area = 3.14 * radius * radius;
        return area;
    }

    // Method to calculate diameter
    private double CalculateDiameter()
    {
        double diameter = 2 * radius;
        return diameter;
    }

    static void Main()
    {
        Circle c = new Circle();
        double D, A;

        c.GetRadius();

        D = c.CalculateDiameter();
        A = c.CalculateArea();

        Console.WriteLine("Area of the circle is: " + A);
        Console.WriteLine("Diameter of the circle is: " + D);
    }
}