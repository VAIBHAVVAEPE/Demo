using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    enum Role
    {
        Admin, Developer, Tester
    }
    class Emp
    {
        string name;
        Role role;

        public string Name { get => name; set => name = value; }
        internal Role Role { get => role; set => role = value; }

        public override string ToString()
        {
            return $"Name :{Name} Role:{role}";
        }
        static void Main(string[] args)
        {
            Emp e = new Emp();
            Console.WriteLine("enter name");
            string nm = Console.ReadLine();
            Console.WriteLine("enter the role");

            foreach(var d in Enum.GetNames<Role>())
            {
                Console.WriteLine(d);
            }
            Console.WriteLine("enter the choice");
            string choice = Console.ReadLine();
            e.name = nm;
            e.Role = Enum.Parse<Role>(choice);
            Console.WriteLine(e);



        }
    }


}
