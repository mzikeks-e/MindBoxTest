using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox.Figures
{
    public class Triangle : Figure
    {
        private readonly double a;
        private readonly double b;
        private readonly double c;

        public override double S => Math.Sqrt((P / 2 - a) * (P / 2 - b) * (P / 2 - c));
        public override double P => a + b + c;

        public bool IsRectangular => 
            a * a + b * b == c * c 
            || a * a + c * c == b * b 
            || b * b + c * c == a * a;

        private Triangle(double a1, double b1, double c1) 
        { 
            a = a1;
            b = b1; 
            c = c1;
        }

        public static Triangle FromSides(double a1, double b1, double c1)
        {
            if (a1 <= 0 || b1 <= 0 || c1 <= 0)
                throw new ArgumentException("Длина каждой из сторон треугольника должна быть положительным числом");

            if (!(a1 + b1 > c1 && a1 + c1 > b1 && b1 + c1 > a1))
                throw new ArgumentException("Треугольника с указанными длинами сторон не существует");

            return new Triangle(a1, b1, c1);
        }

        public override string ToString()
            => $"Треугольник " + base.ToString();
    }
}
