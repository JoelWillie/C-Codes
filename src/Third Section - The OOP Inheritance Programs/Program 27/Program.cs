using System;

class Student
{
    private string idNumber;
    private string firstName;
    private string lastName;
    private double courseWorkGrade;
    private double examGrade;

    // This is the default constructor
    public Student()
    {
        idNumber = "";
        firstName = "";
        lastName = "";
        courseWorkGrade = 0;
        examGrade = 0;
    }

    // This is the parameterized constructor
    public Student(string id, string fn, string ln, double cw, double ex)
    {
        idNumber = id;
        firstName = fn;
        lastName = ln;
        courseWorkGrade = cw;
        examGrade = ex;
    }

    // Destructor to destroy the object (student)
    ~Student()
    {
        Console.WriteLine("Student object destroyed.");
    }

    // Function to get student data
    public void GetStudentData()
    {
        Console.Write("Enter ID number: ");
        idNumber = Console.ReadLine();
        Console.Write("Enter first name: ");
        firstName = Console.ReadLine();
        Console.Write("Enter last name: ");
        lastName = Console.ReadLine();
        Console.Write("Enter coursework grade: ");
        courseWorkGrade = double.Parse(Console.ReadLine());
        Console.Write("Enter exam grade: ");
        examGrade = double.Parse(Console.ReadLine());
    }

    // Display student information
    public void DisplayInfo()
    {
        Console.WriteLine("ID: " + idNumber);
        Console.WriteLine("Name: " + firstName + " " + lastName);
        Console.WriteLine("Coursework Grade: " + courseWorkGrade);
        Console.WriteLine("Exam Grade: " + examGrade);
    }

    // Function to calculate average grade
    public double GetAverageGrade()
    {
        return (courseWorkGrade + examGrade) / 2;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student();
        Console.WriteLine("Enter data for Student 1:");
        student1.GetStudentData();
        Console.WriteLine("\nStudent 1:");
        student1.DisplayInfo();
        Console.WriteLine("Average Grade: " + student1.GetAverageGrade());
        Console.WriteLine();

        // Student 2 using the parameterized constructor 
        Student student2 = new Student("S123", "Jane", "Smith", 88.5, 92.0);
        Console.WriteLine("Student 2:");
        student2.DisplayInfo();
        Console.WriteLine("Average Grade: " + student2.GetAverageGrade());
    }
}