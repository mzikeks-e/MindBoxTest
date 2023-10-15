using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox.Figures
{
    public class Rectangle : Figure
    {
        private readonly double a;
        private readonly double b;

        public override double S => a * b;
        public override double P => a + b + a + b;

        private Rectangle(double a1, double b1)
        {
            a = a1;
            b = b1;
        }

        public static Rectangle FromSides(double a1, double b1)
        {
            if (a1 <= 0 || b1 <= 0)
                throw new ArgumentException("Длина каждой из сторон прямоугольника должна быть положительным числом");

            return new Rectangle(a1, b1);
        }

        public override string ToString()
            => $"Прямоугольник " + base.ToString();
    }
}
