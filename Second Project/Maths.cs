using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project
{
	internal static class Maths
	{
        public static decimal num1 { get; set; }
        public static decimal num2 { get; set; }

        public static decimal Add(decimal num1, decimal num2)
		{
			return num1 + num2;
		}
		public static decimal Sub(decimal num1, decimal num2)
		{
			return num1 - num2;
		}
		public static decimal Mul(decimal num1, decimal num2)
		{
			return num1 * num2;
		}
		public static decimal Div(decimal num1, decimal num2)
		{
			if (num2 == 0)
			{
				throw new ArgumentException("Can't divide by zero");
			}
		else
            return num1 / num2;
		}
	}
}
