using System;

class Program
{
    static void Main()
    {
        int NumSub;
        double ExamFee;

        Console.WriteLine("Please enter the number of subjects you are doing. NB 4 is the maximum number of subjects");
        NumSub = int.Parse(Console.ReadLine());

        if (NumSub == 1)
        {
            ExamFee = 4000 + 5000 + 1000;
        }
        else if (NumSub == 2)
        {
            ExamFee = 7000 + 2 * 4500 + 1000;
        }
        else if (NumSub == 3)
        {
            ExamFee = 10000 + 3 * 4000 + 1000;
        }
        else
        {
            ExamFee = 12000 + 4 * 3500 + 1000;
        }

        Console.WriteLine("Your examination fee is " + ExamFee);
    }
}