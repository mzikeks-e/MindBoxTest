using MindBox.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class CalculateSquareTests
    {
        [Fact]
        public void CreateCorrectTriangle_Test()
        {
            var a = 5;
            var b = 6;
            var c = 7;

            var triange = Triangle.FromSides(a, b, c);

            Assert.Equal(Math.Sqrt(((a + b + c) / 2 - a) * ((a + b + c) / 2 - b) * ((a + b + c) / 2 - c)), triange.S);
        }

        [Fact]
        public void CreateCorrectRectangle_Test()
        {
            var a = 5;
            var b = 6;

            var rectangle = Rectangle.FromSides(a, b);

            Assert.Equal(a * b, rectangle.S);
        }

        [Fact]
        public void CreateCorrectCircle_Test()
        {
            var r = 5;
            var circle = Circle.FromRadius(r);

            Assert.Equal(Math.PI * r * r, circle.S);
        }
    }
}
