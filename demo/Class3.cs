using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class Class3
    {
       
        public static void Startque()
        {
            Console.WriteLine("Hollow USER \n Enter the your Name");

            string st = Console.ReadLine();

            Console.WriteLine($"Hi {st} Wellcome To Quiz");

            Console.WriteLine("select the type of Quiz");
            Console.WriteLine("select the type of Quiz");
            Console.WriteLine($"1) C# \n2) HTML\n3) Java \n Enter Your Choice==");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine($"Hi {st} Your Choice {choice} To Start Quiz on C#");
            }
            else if (choice == 2)
            {
                Console.WriteLine($"Hi {st} Your Choice {choice} To Start Quiz on HTML");
            }
            else if (choice == 3)
            {
                Console.WriteLine($"Hi {st} Your Choice {choice} To Start Quiz on JAVA");
            }

        }
        public static void QuestionOne()
        {
            int count = 0;
            Console.WriteLine("What is your name\n1)aaaa.\n2)bbbb.\n3)cccc.\n4)dddd");
            int ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 2)
            {
                Console.WriteLine("correct");
                count++;
            }
            else
            {
                Console.WriteLine("incorrect");
            }
            Console.WriteLine($"Your Score is {count}");
                
        }
        static void Main(string[] args)
        {
            Startque();
            QuestionOne();
        }
    }
}
