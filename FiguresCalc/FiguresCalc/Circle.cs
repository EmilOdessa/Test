using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresCalc
{
    public class Circle : Shape2D 
    {
        const double pi = Math.PI;
        double radius;

        public double PI { get; }
        public double Radius
        {
            get { return radius; }
            set
            {
                if(value <= 0) { throw new Exception("Радиус должен быть больше нуля!"); }
                else { radius = value; }
            }
        }

        public Circle(string name) : base(name)
        {
            Radius = 5;
        }
        public Circle(string name, double radius) : base(name) 
        {
            Radius = radius;
        }

        public override double Area(double radius)
        {
            return pi * Math.Pow(radius, 2);
        }
    }
}
