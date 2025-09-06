using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace At_day__at_night
{
    abstract class Figure
    {
        public abstract double Area();
        public abstract double Perimeter();
    }
    abstract class Rectangle : Figure
    {
        double width;
        double height;

        public Rectangle(double w, double h)
        {
            width = w;
            height = h;
        }
    }
    class Circle : Figure
    {
        double radius;

        public Circle(double r)
        {
            radius = r;
        }
    }
}
