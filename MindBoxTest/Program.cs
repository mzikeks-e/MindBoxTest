
using MindBox.Figures;

namespace MindBox
{
    public static class Program
    {
        public static void Main()
        {
            FigureType figureType;
            Figure figure = null;
            while (true)
            {
                do
                {
                    Console.WriteLine("Введите тип фигуры (T - треугольник, R - прямоугольник, C - круг)");
                } while (!TryParseFigureType(Console.ReadLine(), out figureType));

                try
                {
                    if (figureType == FigureType.Triangle)
                        figure = GetFiguresFromConsole.GetTriangle();

                    if (figureType == FigureType.Rectangle)
                        figure = GetFiguresFromConsole.GetRectangle();

                    if (figureType == FigureType.Circle)
                        figure = GetFiguresFromConsole.GetCircle();
                }
                
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }

                Console.WriteLine(figure);

            }

        }

        private static bool TryParseFigureType(string s, out  FigureType figureType)
        {
            figureType = FigureType.None;
            switch (s)
            {
                case "T":
                    figureType = FigureType.Triangle;
                    return true;
                case "R":
                    figureType= FigureType.Rectangle;
                    return true;
                case "C":
                    figureType= FigureType.Circle;
                    return true;
                default: 
                    return false;
            }
        }

        enum FigureType
        {
            None = 0,
            Triangle,
            Rectangle,
            Circle
        }
    }

}

