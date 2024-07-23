using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    internal class Square : RectBase
    {
        public Square(double dim)
        {
            Dim01 = Dim02 = dim;
        }
        public override double perimiter
        {
            get { return Dim01 * Dim02; }
        }

        //public override double CalArea()
        //{
        //    return Dim01 * Dim02;
        //}
    }
}
