using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, sum;

            Console.WriteLine("Enter the first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            num2 = int.Parse(Console.ReadLine());

            sum = num1 + num2;
            Console.WriteLine("The sum of the three numbers is: " + sum);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        } // End of Program
    }
}
