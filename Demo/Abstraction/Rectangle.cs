using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    internal class Rectangle : RectBase // implement and inherit
    {
        public override double perimiter
        {
            get { return (Dim01 + Dim02) * 2; }
        }

        // concrete
        //public override double CalArea()
        //{
        //   return Dim01 * Dim02;
        //}
    }
}
