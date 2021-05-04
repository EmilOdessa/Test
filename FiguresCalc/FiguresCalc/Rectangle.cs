using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresCalc
{
    public class Rectangle : Shape2D
    {
        double width, height;

        public double Width
        {
            get { return width; }
            set
            {
                if (value <= 0) { throw new Exception("Длина должна быть больше нуля!"); }
                else { width = value; }
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value <= 0) { throw new Exception("Ширина должна быть больше нуля!"); }
                else { height = value; }
            }
        }

        public Rectangle(string name) : base(name)
        {
            Width = 10;
            Height = 20;
            IsSquare(width, height);
        }
        public Rectangle(string name, double width, double height) : base(name)
        {
            Width = width;
            Height = height;
            IsSquare(width, height);
        }

        public override double Area(double width, double height)
        {
IsSquare(width, height);
            return width * height;
        }

        public override bool IsSquare(double width, double height) 
        { 
            if( width == height)
            {
                Name = "Квадрат";
                return true;
            }

            else
            {
                Name = "Прямоугольник";
                return false;
            }
        }
    }
}
