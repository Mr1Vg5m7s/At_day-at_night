using System;

namespace At_day__at_night
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int num;
            Console.WriteLine("number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 6; i++)
            {
                int d = num % 10;
                num /= 10;
                Console.Write(d);
            }*/

            //3
            /*
            int numStart;
            int numEnd;
            numStart = Convert.ToInt32(Console.ReadLine());
            numEnd = Convert.ToInt32(Console.ReadLine());
            
            for (int i = numStart; i < numEnd; i++)
            {
                int sum = i-1 + i;

                if (i+1 == sum)
                {
                    Console.WriteLine(i);
                }
            }
            */

            //7
            int N;
            Console.WriteLine("number: ");
            N = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                Console.Write(i);
            }

        }

    }
}
