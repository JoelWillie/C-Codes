using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PCQuiz
{
    public int KeepScore;
    public char Ans;
    public char MyAns;

    public PCQuiz()
    {
        KeepScore = 0;
    }

    public void Bank(int Question)
    {
        if (Question == 1)
        {
            Console.WriteLine("WHAT IS THE VALUE OF 4 X 4?");
            Console.WriteLine("a) 0  b) 7  c) 16  d) 5");
            Ans = 'c';
        }
        else if (Question == 2)
        {
            Console.WriteLine("WHAT IS THE VALUE OF 8 X 4 / 2?");
            Console.WriteLine("a) 16  b) 20  c) 56  d) 0");
            Ans = 'a';
        }
        else if (Question == 3)
        {
            Console.WriteLine("What is the capital of france?");
            Console.WriteLine("a) Berlin  b) Paris  c) Madrid  d) Rome");
            Ans = 'b';
        }
        else if (Question == 4)
        {
            Console.WriteLine("Which planet is kown as the red planet?");
            Console.WriteLine("a) Jupiter  b) Venus  c) Mars  d) Mercury");
            Ans = 'c';
        }
        else if (Question == 5)
        {
            Console.WriteLine("What is the largest mammal in the world?");
            Console.WriteLine("a) Elephant  b) Blue Whale  c) Giraffe  d) Great White Shark");
            Ans = 'b';
        }
    }

    public void AnsBank(int Question)
    {
        if (Question == 1)
        {
            Ans = 'c';
        }
        else if (Question == 2)
        {
            Ans = 'a';
        }
        else if (Question == 3)
        {
            Ans = 'b';
        }
        else if (Question == 4)
        {
            Ans = 'c';
        }
        else if (Question == 5)
        {
            Ans = 'b';
        }
    } // End of answer bank

    public void CheckAns()
    {
        if (MyAns == Ans)
        {
            KeepScore++;
        }
    }

    public void GetAns()
    {
        MyAns = char.Parse(Console.ReadLine());
    }

    static void Main()
    {
        PCQuiz ACET = new PCQuiz();
        PCQuiz MIS = new PCQuiz();
        int i;
        i = 1;
        while (i <= 5)
        {
            Console.WriteLine("ACET student Q #" + i + ":");
            ACET.Bank(i);
            ACET.GetAns();
            ACET.CheckAns();
            Console.WriteLine("MIS student Q #" + i + ":");
            MIS.Bank(i);
            MIS.GetAns();
            MIS.CheckAns();
            i++;
        }
        Console.WriteLine("ACET got: " + ACET.KeepScore);
        Console.WriteLine("MIS got: " + MIS.KeepScore);
        if (ACET.KeepScore > MIS.KeepScore)
        {
            Console.WriteLine("ACET is the winner");
        }
        else if (MIS.KeepScore > ACET.KeepScore)
        {
            Console.WriteLine("MIS is the winner");
        }
        else
        {
            Console.WriteLine("This is a tie");
        }
    }
}