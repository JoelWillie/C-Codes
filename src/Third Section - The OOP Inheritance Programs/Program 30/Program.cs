using System;

class Rectangle
{
    protected double length;
    protected double width;

    // Constructor
    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }

    // Calculate area
    public double GetArea()
    {
        return length * width;
    }

    // Method to display rectangle information
    public void Display()
    {
        Console.WriteLine("Length: " + length);
        Console.WriteLine("Width: " + width);
        Console.WriteLine("Area: " + GetArea());
    }
}

class TableTop : Rectangle
{
    private double costPerUnit; // clarify it's cost per unit

    // Constructors
    public TableTop(double l, double w, double cost) : base(l, w)
    {
        costPerUnit = cost;
    }

    // Calculate total cost
    public double GetCost()
    {
        return GetArea() * costPerUnit;
    }

    // Display table top information
    public new void Display()
    {
        base.Display();
        Console.WriteLine("Cost per unit: " + costPerUnit);
        Console.WriteLine("Total Cost: " + GetCost());
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter length: ");
        double length = double.Parse(Console.ReadLine());
        Console.Write("Enter width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Enter cost per unit area: ");
        double costPerUnit = double.Parse(Console.ReadLine());

        TableTop table = new TableTop(length, width, costPerUnit);
        Console.WriteLine("\nTable Top Details:");
        table.Display();
    }
}