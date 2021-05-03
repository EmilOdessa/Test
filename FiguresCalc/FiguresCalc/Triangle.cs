using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresCalc
{
    public class Triangle : Shape2D
    {
        double a, b, c;

        public double A
        {
            get { return a; }
            set
            {
                if (value <= 0) { throw new Exception("F ������ ���� ������ ����!"); }
                else { a = value; }
            }
        }

        public double B
        {
            get { return b; }
            set
            {
                if (value <= 0) { throw new Exception("B ������ ���� ������ ����!"); }
                else { b = value; }
            }
        }

        public double C
        {
            get { return c; }
            set
            {
                if (value <= 0) { throw new Exception("C ������ ���� ������ ����!"); }
                else { c = value; }
            }
        }
        public Triangle(string name) : base(name)
        {
            A = 10;
            B = 20;
            C = 30;
            IsRightTriangle(a, b, c);
        }

        public Triangle(string name, double a, double b, double c) : base(name)
        {
            A = a;
            B = b;
            C = c;
            IsRightTriangle(a, b, c);
        }

        public override double Area(double a, double b, double c)
        {
            double p = (a + b + c) / 2;//������������
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public override bool IsRightTriangle(double a, double b, double c)
        {
            if((a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a))
            {
                Name = "������������� �����������";
                return true;
            }
            Name = "�����������";
            return false;
        }
    }
}
