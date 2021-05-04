using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresCalc
{
    //Найти площадь фигуры не зная типа. Задача решена путем перегрузки методов. Если я правильно понял Вас)
    //Именно поэтому класс НЕ абстрактный 

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
            return new Circle(Name).Area(radius); 
        }
        public virtual double Area(double a, double b) //Квадрат или прямоугольник
        {
            if(a == b) { Name = "Квадрат"; }
            else { Name = "Прямоугольник"; }
            return new Rectangle(Name).Area(a, b);
        }
        public virtual double Area(double a, double b, double c) //треугольник
        {
            if((a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a)) { Name = "Прямоугольный треугольник"; }
            else { Name = "Треугольник"; }
            return new Triangle(Name).Area(a, b, c);
        }

        public virtual bool IsRightTriangle(double a, double b, double c) { return new Triangle("Треугольник").IsRightTriangle(a, b, c); }
        public virtual bool IsSquare(double a, double b) { return new Rectangle("Прямоугольник").IsSquare(a, b); }
    }
}
