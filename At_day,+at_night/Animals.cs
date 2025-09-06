using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace At_day__at_night
{
    internal class Animals
    {
        string name;
        int age;
        public Animals(string n, int a)
        {
            name = n;
            age = a;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }

    class Tiger : Animals
    {
        string vois;
        public Tiger(string n, int a, string v) : base(n, a)
        {
            vois = v;
        }
        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Salary: {vois}");
        }

    }
    class Crocodile : Animals
    {
        string vois;
        public Crocodile(string n, int a, string v) : base(n, a)
        {
            vois = v;
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Salary: {vois}");
        }
    }

    class Dragon : Animals
    {
        string vois;
        public Dragon(string n, int a, string v) : base(n, a)
        {
            vois = v;
        }

        public new void Print()
        {
            base.Print(); 
            Console.WriteLine($"Salary: {vois}");
        }
    }
}