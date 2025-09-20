using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace At_day__at_night
{

    class StudentCard : IComparable<StudentCard>, ICloneable
    {
        public string? Series { get; set; }

        public int Number { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(StudentCard? sc)
        {
            return (Series + Number.ToString()).CompareTo(sc!.Series + sc!.Number.ToString());
        }

        public override string ToString()
        {
            return $"{Series} {Number}";
        }
    }


    class Student : IComparable<Student>, ICloneable
    {
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public DateTime BirthDay { get; set; }
        public StudentCard? StudentCard { get; set; }

        public static IComparer<Student> FromBirthDay { get; } = new DateComparer();

        public static IComparer<StudentCard> FromStudentCard { get; } = new StudentCardComparer();

        public int CompareTo(Student? st)
        {

            if (st != null)
                return (LastName + FirstName).CompareTo(st.LastName + st.FirstName);

            throw new NullReferenceException("  ");
        }

        public override string ToString()
        {
            return $"{LastName,-10} {FirstName,-8} {BirthDay.ToShortDateString()} {StudentCard}";
        }

        public object Clone()
        {
            Student temp = (Student)this.MemberwiseClone();
            temp.StudentCard = new StudentCard { Series = this.StudentCard!.Series, Number = this.StudentCard!.Number };
            return temp;
        }

        public override int GetHashCode()
        {
            return (LastName + FirstName).GetHashCode();
        }
    }

    class Group : IEnumerable
    {
        Student[] students;

        public Group()
        {
            students = new Student[4]
            {
                new Student { LastName="Sidorov", FirstName="Ivan",   BirthDay=new DateTime(2000,10,5), StudentCard=new StudentCard { Series="AC", Number=123456 } },
                new Student { LastName="Ivanova", FirstName="Maria",  BirthDay=new DateTime(2000,10,3), StudentCard=new StudentCard { Series="AB", Number=123455 } },
                new Student { LastName="Ivanov",  FirstName="Sidr",   BirthDay=new DateTime(2002,3,3),  StudentCard=new StudentCard { Series="AA", Number=123456 } },
                new Student { LastName="Smirnov", FirstName="Sergey", BirthDay=new DateTime(1999,4,4),  StudentCard=new StudentCard { Series="AB", Number=123466 } }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return students.GetEnumerator();
        }




        public void Sort()
        {
            Array.Sort(students);
        }


        public void Sort(IComparer comparer)
        {
            Array.Sort(students, comparer);
        }
    }



    class DateComparer : IComparer<Student>
    {
        public int Compare(Student? st1, Student? st2)
        {
            return DateTime.Compare(st1!.BirthDay, st2!.BirthDay);
        }
    }


    class StudentCardComparer : IComparer<StudentCard>
    {
        public int Compare(StudentCard? st1, StudentCard? st2)
        {
            return st1!.CompareTo(st2!);
        }
    }
}
