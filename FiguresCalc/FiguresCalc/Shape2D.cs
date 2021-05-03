using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresCalc
{
    public class Shape2D
    {
        protected string name;

        public string Name
        {
            get { return name; }
            set{ name = value; }
        }

        public Shape2D(string name)
        {
            Name = name;
        }

        public virtual double Area(double radius) //Круг
        {
            Name = "Круг";
            return new Circle(Name).Area(radius); 
        }
        public virtual double Area(double a, double b) //Квадрат или прямоугольник
        {
            Name = "Прямоугольник";
            return new Rectangle(Name).Area(a, b);
        }
        public virtual double Area(double a, double b, double c) //треугольник
        {
            Name = "Треугольник";
            return new Triangle(Name).Area(a, b, c);
        }

        public virtual bool IsRightTriangle(double a, double b, double c) { return new Triangle("Треугольник").IsRightTriangle(a, b, c); }
        public virtual bool IsSquare(double a, double b) { return new Rectangle("Прямоугольник").IsSquare(a, b); }
    }
}
