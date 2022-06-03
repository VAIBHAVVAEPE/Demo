using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Que
    {
        string Question;
        string Option_A;
        string Option_B;
        string Option_C;
        string Option_D;

        string CorrectOption;

        public Que(string question, string option_A, string option_B, string option_C, string option_D, string correctOption)
        {
            Question = question;
            Option_A = option_A;
            Option_B = option_B;
            Option_C = option_C;
            Option_D = option_D;
            CorrectOption = correctOption;
        }

        public string Question1 { get => Question; set => Question = value; }
        public string Option_A1 { get => Option_A; set => Option_A = value; }
        public string Option_B1 { get => Option_B; set => Option_B = value; }
        public string Option_C1 { get => Option_C; set => Option_C = value; }
        public string Option_D1 { get => Option_D; set => Option_D = value; }
        public string CorrectOption1 { get => CorrectOption; set => CorrectOption = value; }
    }
    
    class Quiz
    {
        static List<Que> java = new List<Que>();
        static List<Que> c_sharp = new List<Que>();
        static List<Que> html= new List<Que>();

        static Quiz()
        {
            c_sharp.Add(new Que("Q1 Which of the following converts a type to a double type in C#?", "ToDecimal", "ToDouble", "ToInt32", "ToInt16", "B"));
            c_sharp.Add(new Que("Q2 Which of the following is the default access specifier of a class member function?", "private", "protected", "public", "internaal", "A"));
            c_sharp.Add(new Que("Q3 Abstract class contains ___.", "Abstract methods", " Non Abstract methods", "both", "none", "C"));
            c_sharp.Add(new Que("Q4 The point at which an exception is thrown is called the ___.", "Default point", "Invoking point", "Calling point", "Throw point", "D"));
            c_sharp.Add(new Que("Q5 Struct’s data members are _ by default.", "Protected", "Public ", "Private", "Default", "C"));
            c_sharp.Add(new Que("Q6 Which of the following keywords is used to refer base class constructor to subclass constructor?", "this", "static", "base", "extend", "C"));
            c_sharp.Add(new Que("Q7 C# has strong resemblance with?", "C", "C++", "Java", "Python", "C"));
            c_sharp.Add(new Que("Q8 Number of digits upto which precision value of float data type is valid?", "Upto 6 digit", "Upto 7 digit", "Upto 8 digit", "Upto 9 digit", "B"));


            java.Add(new Que("Q1 _ Operator is used to creating an object.", "class", "new", "print", "main", "B"));
            java.Add(new Que("Q2 Which of the following is not a Looping statement _", "FOR", "SWITCH", "WHILE", "DO-WHILE", "B"));
            java.Add(new Que("Q3 _ is a multi-way branch statement", "switch", "continue", "break", "label", "A"));
            java.Add(new Que("Q4 The _ statement is used inside the switch to terminate a Statement sequence", "break ", "jump", "exit", "goto", "A"));
            java.Add(new Que("Q5 A class that is inherited is called a  _", "superclass", "subclass", "subsetclass", "relative class", "A"));

            html.Add(new Que("Q1 _ Operator is used to creating an object.", "class", "new", "print", "main", "B"));
            html.Add(new Que("Q2 Which of the following is not a Looping statement _", "FOR", "SWITCH", "WHILE", "DO-WHILE", "B"));
            html.Add(new Que("Q3 _ is a multi-way branch statement", "switch", "continue", "break", "label", "A"));
            html.Add(new Que("Q4 The _ statement is used inside the switch to terminate a Statement sequence", "break ", "jump", "exit", "goto", "A"));
            html.Add(new Que("Q5 A class that is inherited is called a  _", "superclass", "subclass", "subsetclass", "relative class", "A"));
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Hollow USER \n Enter the your Name");

            string st = Console.ReadLine();

            Console.WriteLine($"Hi {st} Wellcome To Quiz");

            Console.WriteLine("select the type of Quiz");
            Console.WriteLine($"1) C# \n2) HTML\n3) Java \n Enter Your Choice==");
            

            int choice = Convert.ToInt32(Console.ReadLine());
            int sco = 0;
           
            
                if (choice == 1)
                {
                    Console.WriteLine($"Hi {st} Your Choice {choice} To Start Quiz on C#");
                    for (int i = 0; i < c_sharp.Count; i++)
                    {
                        Console.WriteLine(c_sharp[i].Question1);
                        Console.WriteLine("a " + c_sharp[i].Option_A1);
                        Console.WriteLine("b " + c_sharp[i].Option_B1);
                        Console.WriteLine("c " + c_sharp[i].Option_C1);
                        Console.WriteLine("d " + c_sharp[i].Option_D1);
                        Console.WriteLine("enter your ans");
                        string ans1 = Console.ReadLine();
                        string ans = ans1.ToUpper();
                        if (ans == c_sharp[i].CorrectOption1)
                        {
                            Console.WriteLine("correct");
                            sco++;
                        }
                        else
                        {
                            Console.WriteLine("Wrong");
                        }

                    }
                    Console.WriteLine("score ==========" + sco + "/" + c_sharp.Count);

                }
                else if (choice == 2)
                {
                    Console.WriteLine($"Hi {st} Your Choice {choice} To Start Quiz on HTML");
                    for (int i = 0; i < html.Count; i++)
                    {
                        Console.WriteLine(html[i].Question1);
                        Console.WriteLine("a " + html[i].Option_A1);
                        Console.WriteLine("b " + html[i].Option_B1);
                        Console.WriteLine("c " + html[i].Option_C1);
                        Console.WriteLine("d " + html[i].Option_D1);
                        Console.WriteLine("enter your ans");
                        string ans1 = Console.ReadLine();
                        string ans = ans1.ToUpper();
                        if (ans == html[i].CorrectOption1)
                        {
                            Console.WriteLine("correct");
                            sco++;
                        }
                        else
                        {
                            Console.WriteLine("Wrong");
                        }

                    }
                    Console.WriteLine("score ==========" + sco + "/" + html.Count);
                }
                else if (choice == 3)

                {
                    Console.WriteLine($"Hi {st} Your Choice {choice} To Start Quiz on JAVA");
                    for (int i = 0; i < java.Count; i++)
                    {
                        Console.WriteLine(java[i].Question1);
                        Console.WriteLine("a " + java[i].Option_A1);
                        Console.WriteLine("b " + java[i].Option_B1);
                        Console.WriteLine("c " + java[i].Option_C1);
                        Console.WriteLine("d " + java[i].Option_D1);
                        Console.WriteLine("enter your ans");
                        string ans1 = Console.ReadLine();
                        string ans = ans1.ToUpper();
                        if (ans == java[i].CorrectOption1)
                        {
                            Console.WriteLine("correct");
                            sco++;
                        }
                        else
                        {
                            Console.WriteLine("Wrong");
                        }

                    }
                    Console.WriteLine("score ==========" + sco + "/" + java.Count);
                }

             

        }
    }
}
