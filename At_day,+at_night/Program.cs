using P41_C_Sharp;
using System;
using System.Diagnostics.Tracing;
using System.Runtime.InteropServices.Marshalling;
using System.Text.RegularExpressions;
using System.Collections;
using System.Text;
using System.Xml.Serialization;
using System.Xml

using System.Xml.Linq;

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
        ////////////////////////////////////////////////////
        static T Maximym<T>(T a1, T a2, T a3) where T : IComparable<T>
        {
            if (a1.CompareTo(a2) >= 0 && a1.CompareTo(a3) >= 0)
            {
                return a1;
            }
            else if (a2.CompareTo(a3) >= 0)
            {
                return a2;
            }
            else
            {
                return a3;
            }
        }




        //////////////////////////////////////////////////////////////

        public delegate bool Dayoff(DateTime date);

        static void Main(string[] args)
        {
            //+380677157144 //удалить ноде джава скрипт и брекетс
            /*
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            XmlDocument doc = new XmlDocument();
            doc.Load("Computers.xml");

            List<Computer> computers = new List<Computer>();

            foreach (var item in doc.DocumentElement)
            {
                Computer comp = new Computer();

            }

            var compGame = computers.Where(c => c.Type == "Game").ToList();
            foreach (var computer in compGame)
            {
                Console.WriteLine(item);
            }*/

            /*
            Student st = new Student { LastName = "Sidorov", FirstName = "Ivan", BirthDay = new DateTime(2000, 10, 5), StudentCard = new StudentCard { Series = "AC", Number = 123456 } };

            XmlSerializer xml = new XmlSerializer(typeof(Student));

            using (Stream s = File.Create("student.xml"))
            {
                xml.Serialize(s, st);
            }*/

            /*
            using (FileStream fs = new FileStream("file.bin", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                string text = Console.ReadLine()!;
                byte[] bytes = Encoding.UTF8.GetBytes(text);
                fs.Write(bytes, 0, bytes.Length);
            }

            using (FileStream fs = new FileStream("file.bin", FileMode.Open, FileAccess.Read, FileShare.None))
            {
                byte[] bytes = new byte[fs.Length];
                fs.Read(bytes, 0, bytes.Length);
                string text = Encoding.UTF8.GetString(bytes);
                Console.WriteLine(text);
            }

            using (FileStream fs = new FileStream("file2.bin", FileMode.Create))
            {
                using (BinaryWriter writer = new BinaryWriter(fs, Encoding.UTF8))
                {
                    writer.Write(123);
                    writer.Write(45.67);
                    writer.Write(true);
                    writer.Write("Hello");
                }
            }
            */

            //FileInfo dir = new FileInfo("C:\\Users\\ma\\source\\repos\\At_day,+at_night\\At_day,+at_night\\text.txt");
            //dir.MoveTo("C:\\Users\\ma\\source\\repos\\At_day,+at_night\\text.txt");

            //dir.CopyTo("C:\\Users\\ma\\source\\repos\\text.txt");

            /*Calculator calculator = new Calculator();
            string expr = Console.ReadLine()!;
            string[] parts = expr.Split(' ');
            // 10 + 20
            int a = Int32.Parse(parts[0]);
            int b = Int32.Parse(parts[2]);
            char oper = parts[1][0];

            CalcDelegate calc = null;
            calc = new CalcDelegate(calculator.Sum);
            calc += calculator.Diff;
            calc += new CalcDelegate(Calculator.Mult);
            calc += calculator.Div;

            foreach (CalcDelegate item in calc.GetInvocationList())
            {
                Console.WriteLine(item(a, b));
            }
            */
            /*
            string pattern = @"^\d+\.\d";
            Regex regex = new Regex(pattern);
            while(true)
            {
                string text = Console.ReadLine();
                Console.WriteLine(regex.IsMatch(text));
            }*/



            //Point3D<int> point1 = new Point3D<int>(10,5,5);

            /*

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

            AddMarkStudent("Sidorov", "Ivan", 10, group);*/


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
