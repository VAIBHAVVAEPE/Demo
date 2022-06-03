using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class Class6
    {
        static void Main(string[] args)

        {

            string userInput, systemInput;

            int randomNum;
            int count = 0;
            int count1 = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Give an input from Rock/ Paper/ Scissor ");

                userInput =Console.ReadLine();
                //userInput = Input.ToUpper();

                Random rnd = new Random();
                randomNum = rnd.Next(1, 4);
                switch (randomNum)

                {

                    case 1:

                        systemInput = "Rock";

                        Console.WriteLine("Computer chose Rock");

                        if (userInput == "Rock")

                        {

                            Console.WriteLine("It is a draw");
                            count++; count1++;

                        }
                        else if (userInput == "Paper")

                        {

                            Console.WriteLine("You Loose");
                            count1++;
                        }

                        else

                        {

                            Console.WriteLine("You win");
                            count++;
                        }


                        break;

                    case 2:

                        systemInput = "Paper";

                        Console.WriteLine("Computer chose Paper");

                        if (userInput == "Rock")

                        {

                            Console.WriteLine("You Loose");
                            count1++;

                        }

                        else if (userInput == "Paper")

                        {

                            Console.WriteLine("It is a draw");
                            count++; count1++;
                        }

                        else

                        {

                            Console.WriteLine("You win");
                            count++;
                        }

                        break;

                    case 3:

                        systemInput = "Scissor";

                        Console.WriteLine("Computer chose Scissor");

                        if (userInput == "Rock")

                        {

                            Console.WriteLine("You Win");
                            count++;

                        }

                        else if (userInput == "Paper")

                        {

                            Console.WriteLine("You Loose");
                            count1++;

                        }

                        else

                        {

                            Console.WriteLine("It is a draw");
                            count++; count1++;
                        }

                        break;

                    default :
                        {
                            
                            Console.WriteLine("invalid entry!");
                        }
                        break;

                }
                

            }
            Console.WriteLine(" your sco==" + count);
            Console.WriteLine(" System sco==" + count1);

            if (count >count1)
            {
                Console.WriteLine("your win");
            }
            else
            {
                Console.WriteLine("Computre win");
            }
        }    
    }
    
   
}
        