using System;

namespace Program_23
{
    internal class Program
    {
        class Area
        {
            public int S1, S2, S3, SIDE, RADIUS;
            public double TRIAREA, SQAREA, CIRAREA;

            public Area()
            {
                S1 = 0;
                S2 = 0;
                S3 = 0;
                SIDE = 0;
                RADIUS = 0;
                TRIAREA = 0;
                SQAREA = 0;
                CIRAREA = 0;
            }

            public void Areaoftriangle()
            {
                double s = (S1 + S2 + S3) / 2.0;
                TRIAREA = Math.Sqrt(s * (s - S1) * (s - S2) * (s - S3)); // using matlab for sqare 
            }

            public void Areaofsquare()
            {
                SQAREA = SIDE * SIDE;
            }

            public void Areaofcircle()
            {
                CIRAREA = Math.PI * RADIUS * RADIUS; // Using matlab for pi
            }
        }

        static void Main(string[] args)
        {
            Area area = new Area();
            int choice = 0;

            do
            {
                Console.WriteLine("\nArea Calculator Menu:");
                Console.WriteLine("1. Calculate Triangle Area");
                Console.WriteLine("2. Calculate Square Area");
                Console.WriteLine("3. Calculate Circle Area");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice (1-4): ");

                if (int.TryParse(Console.ReadLine(), out choice)) // Had to use TryParse because 
                {
                    if (choice == 1)
                    {
                        Console.Write("Enter side 1: ");
                        area.S1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter side 2: ");
                        area.S2 = int.Parse(Console.ReadLine());
                        Console.Write("Enter side 3: ");
                        area.S3 = int.Parse(Console.ReadLine());
                        area.Areaoftriangle();
                        Console.WriteLine($"Triangle Area: {area.TRIAREA:F2}");
                    }
                    else if (choice == 2)
                    {
                        Console.Write("Enter side length: ");
                        area.SIDE = int.Parse(Console.ReadLine());
                        area.Areaofsquare();
                        Console.WriteLine($"Square Area: {area.SQAREA}");
                    }
                    else if (choice == 3)
                    {
                        Console.Write("Enter radius: ");
                        area.RADIUS = int.Parse(Console.ReadLine());
                        area.Areaofcircle();
                        Console.WriteLine($"Circle Area: {area.CIRAREA:F2}");
                    }
                    else if (choice == 4)
                    {
                        Console.WriteLine("Goodbye!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice! Please try again.");
                    } // End of instrutions
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a number.");
                    choice = 0;
                }  // End of choices

            } while (choice != 4); // End of do while
        }
    }
} // End Of Main
