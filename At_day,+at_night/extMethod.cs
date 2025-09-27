using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace At_day__at_night
{
       public static class Collections
        {
            public static bool Method1(this int a)
            {
                if (a % 2 == 1)return true;
                else return false;
        }

            public static void method2(this int a)
            {
                if (a % 2 == 0) Console.WriteLine("Парное число");
            }

            public static void method3(this int a)
            {
                if(a % a == 1) Console.WriteLine("Простое число");
            }

            


        }
    }
