using MindBox.Figures;

namespace Tests
{
    public class CreatingFiguresTests
    {
        [Fact]
        public void CreateCorrectTriangle_Test()
        {
            var triange = Triangle.FromSides(5, 6, 7);
        }

        [Fact]
        public void CreateCorrectRectangle_Test()
        {
            var rectangle = Rectangle.FromSides(5, 6);
        }

        [Fact]
        public void CreateCorrectCircle_Test()
        {
            var circle = Circle.FromRadius(5);
        }

        [Fact]
        public void CreateTriangleWithNegativeSide_Throws_Test()
        {
            Assert.Throws<ArgumentException>(() => Triangle.FromSides(5, 6, -7));
        }

        [Fact]
        public void CreateRectangleWithNegativeSide_Throws_Test()
        {
            Assert.Throws<ArgumentException>(() => Rectangle.FromSides(5, -6));
        }

        [Fact]
        public void CreateCircleWithNegativeRadius_Throws_Test()
        {
            Assert.Throws<ArgumentException>(() => Circle.FromRadius(-5));
        }

        [Fact]
        public void CreateDoesnotExsistTriangle_Throws_Test()
        {
            Assert.Throws<ArgumentException>(() => Triangle.FromSides(5, 6, 12));
        }
    }
}