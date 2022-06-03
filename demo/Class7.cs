using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Class7
    {
        static void Main(string[] args)
        {
            string user;
            string computer;

            Console.WriteLine("WellCome To Game");
            Console.WriteLine("Enter The Your Name ");
            string u = Console.ReadLine();
            int uscore = 0;
            int cscore = 0;
            string Rock, Paper, Scissor;

            
            for (int j = 0; j <= 5; j++)
            {
                Console.WriteLine("Give an input from Rock/ Paper/ Scissor");
                string use;
                user = Console.ReadLine();

                if (user == "Rock" || user == "Paper" || user == "Scisssor")
                {
                    for (int i = 0; i<1; i++)
                    {
                        // user = use.ToUpper();


                        Random rnd = new Random();
                        int randomNumber = rnd.Next(1, 4);  //123

                        if (randomNumber == 1)
                        {
                            Console.WriteLine("Comp Choice ==Paper");

                            if (user == "Paper")
                            {
                                Console.WriteLine(u + " draw");
                                uscore++; cscore++;
                            }
                            else if (user == "Rock")
                            {
                                Console.WriteLine(u + " you lost");
                                cscore++;
                            }
                            else if (user == "Scissor")
                            {
                                Console.WriteLine(u + " you win");
                                uscore++;
                            }

                        }
                        if (randomNumber == 2)
                        {
                            Console.WriteLine("Comp ==Rock");

                            if (user == "Paper")
                            {
                                Console.WriteLine(u + " You win");
                                uscore++;
                            }
                            else if (user == "Rock")
                            {
                                Console.WriteLine(u + " you draw");
                                uscore++; cscore++;
                            }
                            else if (user == "Scissor")
                            {
                                Console.WriteLine(u + " you lost");
                                cscore++;
                            }

                        }
                        if (randomNumber == 3)
                        {
                            Console.WriteLine("Comp ==Scissor");


                            if (user == "Paper")
                            {
                                Console.WriteLine(u + " You lost");
                                cscore++;
                            }
                            else if (user == "Rock")
                            {
                                Console.WriteLine(u + " you win");
                                uscore++;
                            }
                            else if (user == "Scissor")
                            {
                                Console.WriteLine(u + " you draw");
                                cscore++;
                                uscore++;
                            }

                        }


                    }


                }
                else
                {
                    Console.WriteLine("invalid entry");

                }
            }

            
            Console.WriteLine(u +" SCore== "+uscore);
            Console.WriteLine("Computer SCore== " + cscore);
            
            if(uscore>cscore)
            {
                Console.WriteLine("\t\t\t\t\t"+u+"  IS WINNER *********");
            }
            else if (uscore < cscore)
            {
                Console.WriteLine("\t\t\t\t\tComputer IS WINNER+++++++++++++");
            }
        }
    }
    
}
