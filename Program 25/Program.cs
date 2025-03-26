using System;

class Rectangle
{
    private double length, width;

    public Rectangle()
    {
        length = 0;
        width = 0;
    }

    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }

    public double Length
    {
        get { return length; }
        set { length = value; }
    }

    public double Width
    {
        get { return width; }
        set { width = value; }
    }

    public double Area
    {
        get { return length * width; }
    }

    public double Perimeter
    {
        get { return 2 * (length + width); }
    }

    public double RectArea()
    {
        return Area;
    }

    public double RectPerimeter()
    {
        return Perimeter;
    }

    public void GetMeasurements()
    {
        Console.WriteLine("Enter length:");
        length = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter width:");
        width = double.Parse(Console.ReadLine());
    }

    public void Display()
    {
        Console.WriteLine("Length: " + length);
        Console.WriteLine("Width: " + width);
        Console.WriteLine("Area: " + Area);
        Console.WriteLine("Perimeter: " + Perimeter);
    }
}

class Program
{
    static void Main()
    {
        Rectangle rect1 = new Rectangle();
        rect1.GetMeasurements();
        rect1.Display();

        Rectangle rect2 = new Rectangle(10, 20);
        rect2.Display();
    }
}