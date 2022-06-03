using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{//A B C D E F
    //A B C D E F
    //F A B C D E
    //E F A B C D
    //D E F A B C
    //C D E F A B
    internal class Class2
    {
        static void Main(string[] args)
        {

            for (char i = 'A'; i <= 'Z'; i++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine(
                );
            for (char j = 'Z'; j >='A'; j--)
            {
                Console.Write(j + " ");
            }
        }

    }

    
}
