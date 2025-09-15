using P41_C_Sharp;
using System;
using System.Diagnostics.Tracing;
using System.Runtime.InteropServices.Marshalling;
using System.Text.RegularExpressions;
using System.Collections;

namespace At_day__at_night
{
    internal class Program
    {
        static void PrintGroup(Hashtable group)
        {
            foreach (Student key in group.Keys)
            {
                Console.Write($"{key.LastName}{key.FirstName} - ");
                foreach (int item in (ArrayList)group[key])
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            }
            
        }

        static void AddMarkStudent(string lastName, string firstName, int mark, Hashtable group)
        {
            foreach (Student key in group.Keys)
            {
                if(key.LastName == lastName && key.FirstName == firstName)
                {
                    ((ArrayList)group[key]).Add(mark);
                    PrintGroup(group);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;



            Hashtable group = new Hashtable
{
    {
        new Student
        {
            LastName = "Sidorov",
            FirstName = "Ivan",
            BirthDay = new DateTime(2000, 10, 5),
            StudentCard = new StudentCard
            {
                Series = "AC",
                Number = 123456
            }
        },
        new ArrayList{ 8,9,8,6}
    },

    {
        new Student
        {
            LastName = "Ivanova",
            FirstName = "Maria",
            BirthDay = new DateTime(2000, 10, 3),
            StudentCard = new StudentCard
            {
                Series = "AB",
                Number = 123455
            }
        },
        new ArrayList{ 7,9,8,10}
    },

    {
        new Student
        {
            LastName = "Ivanov",
            FirstName = "Sidr",
            BirthDay = new DateTime(2002, 3, 3),
            StudentCard = new StudentCard
            {
                Series = "AA",
                Number = 123456
            }
        },
        new ArrayList{ 6,9,8,9}
    }
              
};

            AddMarkStudent("Sidorov", "Ivan", 10, group);


            //Tiger tiger = new Tiger("Tiger", 5, "Rrrr");
            //tiger.Show();
            //tiger.Show();
            /*
            Group group = new Group();
            Console.WriteLine("Group");
            Console.WriteLine("----------------------------------------");
            foreach (Student s in group)
            {
                Console.WriteLine(s);
            }

            group.Sort(new SerialsANDnumber());

            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            foreach (Student s in group)
            {
                Console.WriteLine(s);
            }
            */









            //int[] arr = new int[10];
            //int[] arr1 = {2,2,2];
            //int[] arr2;
            //arr2 = new int[] { 1, 2};
            //333333333333333333333333333333333333333333333333333333333333333333333333333
            /*int[] arr1 = new int[9] { 1, 2, 3, 4, 5, 6, 1, 2, 3 };
            int num1,num2,num3;
            Console.WriteLine("number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            num3 = Convert.ToInt32(Console.ReadLine());
            int Count = 0;
            for (int i = 0; i < arr1.Length; i++) 
            {
                if (arr1[i] == num1 && arr1[i+1] == num2 && arr1[i+2] == num3)
                {
                    Count ++;
                }
            }
            Console.WriteLine(Count);*/
            //444444444444444444444444444444444444444444444444444444444444444444444444444
            /*
            Random random = new Random();

            int size1 = 5;
            int size2 = 6;
            int[] arr1 = new int[size1];
            int[] arr2 = new int[size2];
            for (int i = 0; i < size1; i++)
            {
                arr1[i] = random.Next(1, 10);
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine(" ");
            for (int i = 0; i < size2; i++)
            {
                arr2[i] = random.Next(1, 10);
                Console.Write(arr2[i]+ " ");
            }

            int[] arr3;


            for (int i = 0;i < size1; i++)
            {
                for (int j = 0; j < size2; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                       arr3 = new int[size1 + size2];
                        arr3[i] = arr1[i];
                        arr3[j] = arr2[j];
                        Console.WriteLine(" ");
                        Console.WriteLine("elements: " + arr3[i]);
                    }
                }
            }*/
            //55555555555555555555555555555555555555555555555555555555
            /*
            int[,] Arr1 = new int[5,5];
            Random random = new Random();
            for (int i = 0; i < Arr1.GetLength(0); i++)
            {
                for (int j = 0; j < Arr1.GetLength(1); j++)
                {
                    Arr1[i, j] = random.Next(1, 100);
                    Console.Write(Arr1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(" ");
            int min = Arr1[0, 0];
            int max = Arr1[0, 0];
            for (int i = 0; i < Arr1.GetLength(0); i++)
            {
                for (int j = 0; j < Arr1.GetLength(1); j++)
                {
                    if (Arr1[i, j] < min)
                    {
                        min = Arr1[i, j];
                    }
                    if (Arr1[i, j] > max)
                    {
                        max = Arr1[i, j];
                    }
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
            */
            //777777777777777777777777777777777777777777777777


            /*
            Random random = new Random();
            int[] arr = new int[10];

            int num;
            Console.WriteLine("number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1, 10);
            }
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            int CountP = 0;
            int CountN = 0;
            int CountZ = 0;

            int[] numbers = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    CountP++;
                }
                if (arr[i] % 2 != 0)
                {
                    CountN++;
                }
                if (!numbers.Contains(numbers[i]))
                {
                    numbers[CountZ] = arr[i];
                    CountZ++;
                }
            }
            Console.WriteLine($"Positiv: {CountP} Negativ: {CountN} Unique: {CountZ}");
            


            */


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
            // int N;
            // Console.WriteLine("number: ");
            // N = Convert.ToInt32(Console.ReadLine());
            // for (int i = 0; i < N; i++)
            // {
            //     Console.Write(i);
            // }

        }

    }
}
