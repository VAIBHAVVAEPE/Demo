using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public class Class84
    {
        //int Id;
        //string EmpName;

        public int id { get; set; }
        public string EmpName { get; set; }
        //public string empName
        //{

        //    get
        //    {
        //        return empName;
        //    }

        //    set
        //    {
        //        empName = value;
        //    }
        //}
        //public string id
        //{

        //    get
        //    {
        //        return id;
        //    }

        //    set
        //    {
        //        id = value;
        //    }
        //}


    }
    class Demo
    {
        static void Main(string[] args)
        {

            int[] arr = new int[5];
           

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("enter Emp name");
                string st =Console.ReadLine();
                Console.WriteLine(st);
            }
            
        }
    }
    //wap 
    class Employee11
    {
        string name;
        int age;
        int empid;

        public int Age { get; set; }
        public int  Empid { get; set; }
        public string Name { get; set; }
    }
    class InfoEmp
    {
        static void Main(string[] args)
        {
            Employee11[] obj = new Employee11[]
            {
                new Employee11{Age=22,Empid=1,Name="vai" },
            new Employee11 { Name = "vai", Age = 55, Empid = 2 }

            };
            foreach(dynamic st in obj)
            {
                Console.WriteLine(st);
            }
        }
    }

    //wap 
    class Product
    {
        string name;
        int id;
        public int Id { get; set; }
        public string Name { get; set; }
        static void Main(string[] args)
        {
            Product[] parr = new Product[5]
            {
                new Product{id=1,name="aaa"},
                new Product{id=2,name="bbb"},
                new Product{id=3,name="ccc"},
                 new Product{id=4,name="dddd"},
                new Product{id=5,name="eeee"},

            };
            foreach(Product pro in parr)
            {
                Console.WriteLine(pro);
            }
        }
    }

    //2d Array   4row,3col  total element=4*3=12
    class TwoD
    {
        static void Main(string[] args)
        {
            int[,]arr = new int[4,3]

            {
                 { 1, 2, 3 },
                 { 1, 2, 3 },
                 { 1, 2, 3 },
                 { 1, 2, 3 }
            };
            foreach(int d in arr)
            {
                Console.WriteLine(d+" ");
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }

            }

        }
    }


    //jagged array
    class Jagged
    {
        static void Main(string[] args)
        {
            int[][,] arr = new int [4][, ]
            {
                new int[, ]{{ 1,4},{ 3,4} },
                new int[, ]{{ 2,4},{ 3,5},{ 4,5} },
               new int[, ] { { 3,5},{ 4,5}},
                new int[, ]{ { 3,5},{ 4,5},{ 1,4}},
            };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].GetLength(0); j++)
                {
                    for (int k = 0; k < arr[j].GetLength(1); k++)
                    {
                        Console.Write(arr[i][j,k]+" ");

                    }

                }

                Console.WriteLine();
            }
            
        }
    }

    //Dictionary<T,T>

    class Dic
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> oj = new Dictionary<int, string>();
            oj.Add(91, "India");
            oj.Add(63, "Aus");
            oj.Add(1, "USA");

            foreach(dynamic a in oj)
            {    
                Console.WriteLine("key"+a.Key+"value"+a.Value);
            }

        }

    }

    //Generic  method in class
    
        public class  Test<T>  //placeholder for type(data type)
        {
            T element;
            public void Add(T element)
            {
                this.element = element;
            }
            public T Display()
            {
                return element;
            }
        }

    class Generic
    {

        static void Main(string[] args)
        {
            Test<int> obj = new Test<int>();
            obj.Add(12);

            Test<string> obj1 = new Test<string>();
            obj1.Add("vaibhav");
            

        }
    }

    //GEneric Mathod

    class Program
    {
        static void Swap<T>(T a,T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"a={a} b={b}");
        }
        static void Main(string[] args)
        {
            Swap<int>(10, 20);
            Swap<string>("vaibhav", "Varpe");
            Swap<double>(455.33, 44.44);
        }
    }
    class Program11
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"a={a} b={b}");
        }
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            Swap<int>(ref a, ref b);
            Console.WriteLine($"a={a} b={b}");
            string num1 = "Vaibhav", num2 = "Varpeeee";
            Swap<string>(ref num1,ref num2);
            Console.WriteLine($"a={num1} b={num2}");
            
        }
    }

    //out

    class pro
    {
        static void calculation(int a,int b ,out int sum ,out int multi )

        {
            sum = a + b;
            multi = a * b;
        }
        static void Main(string[] args)
        {

            int a = 5, b = 4, sum, multi;
            calculation(a, b,out sum,out multi);
            Console.WriteLine($"add {sum} multi {multi}");
        }

    }









    //
    //disanary

    class Tests<TKeys,TValues>
    {
        TKeys element1;
        TValues element;

        
    }



}
