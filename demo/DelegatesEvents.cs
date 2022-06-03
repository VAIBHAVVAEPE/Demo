using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{

    //deleate is ref type in c# it is type ,delegatee inside the namespace
    public delegate void Mydel();
    public class Student
    {  //create an event
        public event Mydel Fail;
        public event Mydel Distinction;

        public void AcceptMarks(int marks)
        {

            if(marks>=40)
            {
                Fail();
            }
            else if(marks>= 75)
            {
                Distinction();
            }
            Console.WriteLine($"Your score is {marks}");

        }
    }

    class DelegatesEvents
    {
        static void FailMsg()
        {
            Console.WriteLine("Your Are Fail");
        }
        static void DistinctionMsg()
        {
            Console.WriteLine("Cong ! You Are pass with Distinction ");
        }
        static void Main(string[] args)
        {
            //this is method
            Student s1 = new Student();
            s1.Fail += new Mydel(FailMsg);
            s1.Distinction += new Mydel(DistinctionMsg);
            s1.AcceptMarks(64);



        }
    }


    public delegate void Mydel1();
    class Bank
    {
        public event Mydel1 ZeroBalance;
        public event Mydel1 InefficientBalance;

        public void InfoBalance(int bal,int debit)
        {
            if (bal < debit)
            {
                Console.WriteLine("Inefficient balance"+debit);
            }else if (bal == 0)
            {
                Console.WriteLine("Zero Balance");
            }

        }

    }
    class MainBank
    {
        static void Addamt()
        {

        }

        static void Main(string[] args)
        {
            Bank obj = new Bank();
            obj.InfoBalance(100,10);
        }
    }
}
