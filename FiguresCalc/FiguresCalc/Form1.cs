using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiguresCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Shape2D shape = new Shape2D("Фигура");//Вычисление площади фигуры без знания типы фигуры
            double d = shape.Area(5,5);
            MessageBox.Show("Площадь " + shape.Name + " = " + d.ToString());
            /////////////////////////////////////////////////////////////////////////////////////////////
            
            Shape2D circle = new Circle("Круг");//Вычисление площади круга по радиусу
            d = circle.Area(5);
            MessageBox.Show("Площадь " + circle.Name + " = " + d.ToString());
            /////////////////////////////////////////////////////////////////////////////////////////////
            
            Shape2D triangle = new Triangle("Треугольник");//Вычисление площади треугольника и встроенная проверка на тип треугольника
            d = triangle.Area(5, 5, 5);
            MessageBox.Show("Площадь " + triangle.Name + " = " + d.ToString());
            /////////////////////////////////////////////////////////////////////////////////////////////
        }

    }
}
