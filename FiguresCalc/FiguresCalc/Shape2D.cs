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

        public virtual double Area(double radius) //����
        {
            Name = "����";
            return new Circle(Name).Area(radius); 
        }
        public virtual double Area(double a, double b) //������� ��� �������������
        {
            Name = "�������������";
            return new Rectangle(Name).Area(a, b);
        }
        public virtual double Area(double a, double b, double c) //�����������
        {
            Name = "�����������";
            return new Triangle(Name).Area(a, b, c);
        }

        public virtual bool IsRightTriangle(double a, double b, double c) { return new Triangle("�����������").IsRightTriangle(a, b, c); }
        public virtual bool IsSquare(double a, double b) { return new Rectangle("�������������").IsSquare(a, b); }
    }
}
