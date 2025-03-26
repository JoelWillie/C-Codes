using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WagesOfEmployee
{
    internal class Program
    {
        class Employee
        {
            // Properties
            public int HoursWorked { get; set; }
            public string IdNumber
            {
                get { return idNumber; }
                set { idNumber = value; }
            }

            public string FirstName
            {
                get { return firstName; }
                set { firstName = value; }
            }

            public string LastName
            {
                get { return lastName; }
                set { lastName = value; }
            }

            // Fields
            private string firstName, lastName, idNumber;
            private decimal nis, nht, educationTax, netWage, totalDeductions, grossWage;

            // Deduction rates
            private const decimal NIS_RATE = 0.02m;  // 2%
            private const decimal NHT_RATE = 0.025m;  // 2.5%
            private const decimal EDUCATION_TAX_RATE = 0.05m;  // 5%
            public const int HourlyRate = 20; // 20 

            public Employee()
            {
                HoursWorked = 0;
                firstName = string.Empty;
                lastName = string.Empty;
                idNumber = string.Empty;
                nis = 0;
                nht = 0;
                educationTax = 0;
                netWage = 0;
                totalDeductions = 0;
                grossWage = 0;
            }

            public decimal CalculateGrossWage()
            {
                grossWage = HoursWorked * HourlyRate;
                return grossWage;
            }

            public void CalculateDeductions()
            {
                // Calculate individual deductions
                nis = grossWage * NIS_RATE;
                nht = grossWage * NHT_RATE;
                educationTax = grossWage * EDUCATION_TAX_RATE;

                // Calculate total deductions
                totalDeductions = nis + nht + educationTax;
            }

            public decimal CalculateNetWage()
            {
                netWage = grossWage - totalDeductions;
                return netWage;
            }

            public void PrintPaySlip()
            {
                Console.WriteLine("\n========== EMPLOYEE PAY SLIP ==========");
                Console.WriteLine($"Employee ID: {IdNumber}");
                Console.WriteLine($"Name: {FirstName} {LastName}");
                Console.WriteLine("\nEarnings:");
                Console.WriteLine($"Hours Worked: {HoursWorked}");
                Console.WriteLine($"Hourly Rate: ${HourlyRate:F2}");
                Console.WriteLine($"Gross Wage: ${grossWage:F2}");
                Console.WriteLine("\nDeductions:");
                Console.WriteLine($"NIS (3%): ${nis:F2}");
                Console.WriteLine($"NHT (2%): ${nht:F2}");
                Console.WriteLine($"Education Tax (2.25%): ${educationTax:F2}");
                Console.WriteLine($"Total Deductions: ${totalDeductions:F2}");
                Console.WriteLine("\nSummary:");
                Console.WriteLine($"Net Wage: ${netWage:F2}");
                Console.WriteLine("====================================");
            }
        }

        static void Main(string[] args)
        {
            Employee emp = new Employee();

            // This should Get employee information
            Console.WriteLine("Enter Employee Information");
            Console.Write("ID Number: ");
            emp.IdNumber = Console.ReadLine();

            Console.Write("First Name: ");
            emp.FirstName = Console.ReadLine();

            Console.Write("Last Name: ");
            emp.LastName = Console.ReadLine();

            Console.Write("Hours Worked: ");
            emp.HoursWorked = int.Parse(Console.ReadLine());

            if (emp.HoursWorked > 40)
            {
                Console.WriteLine("Employee has worked overtime.");
            }

            // Calculate wages and deduction
            emp.CalculateGrossWage();
            emp.CalculateDeductions();
            emp.CalculateNetWage();

            // Print the pay slip
            emp.PrintPaySlip();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
