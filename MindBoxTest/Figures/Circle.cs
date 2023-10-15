using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MindBox.Figures
{
    public class Circle : Figure
    {
        private readonly double r;

        public override double S => Math.PI * r * r;
        public override double P => 2 * Math.PI * r;

        private Circle(double r1)
            => r = r1;

        public static Circle FromRadius(double r1)
        {
            if (r1 <= 0)
                throw new ArgumentException("Радиус круга должен быть положительным числом");

            return new Circle(r1);
        }

        public override string ToString()
            => $"Круг " + base.ToString();
    }
}
