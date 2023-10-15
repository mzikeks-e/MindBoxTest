using MindBox.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox
{
    public class GetFiguresFromConsole
    {
        public static Triangle GetTriangle()
        {
            double a;
            double b;
            double c;

            do
            {
                Console.WriteLine("Введите первую сторону треугольника");
            } while (!double.TryParse(Console.ReadLine(), out a));

            do
            {
                Console.WriteLine("Введите вторую сторону треугольника");
            } while (!double.TryParse(Console.ReadLine(), out b));

            do
            {
                Console.WriteLine("Введите третью сторону треугольника");
            } while (!double.TryParse(Console.ReadLine(), out c));

            return Triangle.FromSides(a, b, c);
        }


        public static Rectangle GetRectangle()
        {
            double a;
            double b;

            do
            {
                Console.WriteLine("Введите первую сторону прямоугольника");
            } while (!double.TryParse(Console.ReadLine(), out a));

            do
            {
                Console.WriteLine("Введите вторую сторону прямоугольника");
            } while (!double.TryParse(Console.ReadLine(), out b));


            return Rectangle.FromSides(a, b);
        }

        public static Circle GetCircle()
        {
            double r;

            do
            {
                Console.WriteLine("Введите радиус круга");
            } while (!double.TryParse(Console.ReadLine(), out r));

            return Circle.FromRadius(r);
        }
    }
}
