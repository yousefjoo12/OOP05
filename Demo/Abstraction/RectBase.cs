using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    internal abstract class RectBase : Shape
    {
        //public override double perimiter => throw new NotImplementedException();

        public override double CalArea()
        {
            return Dim01 * Dim02;
        }
    }
}
