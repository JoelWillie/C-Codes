using System;
class Calculator
{
    public double Add(double a, double b)
    {
        return a + b;
    }

    public double Subtract(double a, double b)
    {
        return a - b;
    }

    public double Multiply(double a, double b)
    {
        return a * b;
    }

    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: Division by zero.");
            return 0;
        }
        return a / b;
    }
}
class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        Console.WriteLine("Enter first number:");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Select operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        int code = int.Parse(Console.ReadLine());
        double result;

        if (code == 1)
        {
            result = calc.Add(num1, num2);
            Console.WriteLine("Result: " + result);
        }
        else if (code == 2)
        {
            result = calc.Subtract(num1, num2);
            Console.WriteLine("Result: " + result);
        }
        else if (code == 3)
        {
            result = calc.Multiply(num1, num2);
            Console.WriteLine("Result: " + result);
        }
        else if (code == 4)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            }
            else
            {
                result = calc.Divide(num1, num2);
                Console.WriteLine("Result: " + result);
            }
        }
        else
        {
            Console.WriteLine("Error: Invalid code.");
        }
    }
}
