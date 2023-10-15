using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MindBox.Figures
{
    public abstract class Figure
    {
        public abstract double S { get; }
        public abstract double P { get; }
        public override string ToString() => $"с площадью {Math.Round(S, 3)} и периметром {Math.Round(P, 3)}";
    }
}
