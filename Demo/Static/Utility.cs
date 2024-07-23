using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Static
{
    internal class Utility
    {
        public int X { get; set; }
        public int Y { get; set; }

        private static double pi;

        public static double PI
        {
            get { return pi; }
            set { pi = value; }
        }


        public Utility(int _x, int _y)
        {
            X = _x;
            Y = _y;
            // pi = 3.14;
        }


        public override string ToString()
        {
            return $"{X} , {Y}";
        }


        //has no modifier
        //has no Paramters

        static Utility()
        {
            //initialize for static members
            PI = 3.14;
        }

        // Static member method [Static]
        // helper method
        public static double CmToInch(double cm)
        {
            return cm * 2.54;
        }


        //object member method
        public static double CalCircleArea(double radius)
        {
            return PI * Math.Pow(radius, 2);
        }

    }
}
