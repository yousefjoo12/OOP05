using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    internal class Circle : Shape
    {
        public Circle(double radius)
        {
            Dim01 = Dim02 = radius;
        }
        public override double perimiter
        {
            get { return 2 * 3.14 * Dim01; } 
        }

        public override double CalArea()
        {
            return 3.14 * Math.Pow(Dim01, 2);
        }
    }
}
