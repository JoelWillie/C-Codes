using System;

class Circle
{
    private double radius;

    // Default constructor
    public Circle()
    {
        radius = 0;
    }

    public Circle(double r)
    {
        radius = r;
    }

    // Destructor
    ~Circle()
    {
        Console.WriteLine("Circle object destroyed.");
    }

    // Get radius from user
    public void SetRadiusFromUser()
    {
        Console.Write("Enter the radius: ");
        radius = double.Parse(Console.ReadLine());
    }

    // Method to calculate diameter
    public double GetDiameter()
    {
        return 2 * radius;
    }

    public double GetArea()
    {
        return 3.14 * radius * radius; // Using 3.14 as PI 
    }

    public void Display()
    {
        Console.WriteLine("Radius: " + radius);
        Console.WriteLine("Diameter: " + GetDiameter());
        Console.WriteLine("Area: " + GetArea());
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create the circle with default constructor and get the user input
        Circle circle1 = new Circle();
        Console.WriteLine("For Circle 1:");
        circle1.SetRadiusFromUser();
        Console.WriteLine("\nCircle 1:");
        circle1.Display();
        Console.WriteLine();

        // Create circle with parameterized constructor and get the user input aswell
        Console.WriteLine("For Circle 2:");
        Console.Write("Enter the radius: ");
        double radius2 = double.Parse(Console.ReadLine());
        Circle circle2 = new Circle(radius2);
        Console.WriteLine("\nCircle 2:");
        circle2.Display();

        Console.ReadLine(); // Keeps console open
    }
}