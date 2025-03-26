using System;

class Program
{
    static void Main()
    {
        int Oldest = 0, Age, Count;

        for (Count = 1; Count <= 200; Count++)
        {
            Console.WriteLine("Enter the age of the next family member");
            Age = int.Parse(Console.ReadLine());

            if (Age > Oldest)
            {
                Oldest = Age;
            }
        }

        Console.WriteLine("The oldest family member is " + Oldest);
    }
}