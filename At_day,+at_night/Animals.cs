using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace At_day__at_night
{
    internal class Animals
    {
        public string name;
        public int age;
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

    class Tiger : Animals, IOutput
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

        public void Show()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }

        public void Show(string info)
        {
            Console.WriteLine($"Name: {name}, Age: {age}", "Зверинец в норме");
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