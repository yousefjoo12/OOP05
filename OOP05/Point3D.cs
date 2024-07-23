using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05
{
	internal class Point3D  : IComparable, ICloneable
	{
		public int X { get; set; }
		public int Y { get; set; }
		public int Z { get; set; }
		public Point3D() : this(0, 0, 0)
		{
		}
		public Point3D(int _x, int _y, int _z) 
		{
			X = _x;
			Y = _y;
			Z = _z;
		}
		public Point3D(int _x, int _y) : this(_x, _y, 0)
		{
		}
		public Point3D(int _x) : this(_x,0, 0)
		{
		}
		public override string ToString()
		{
			return $"Point: ({X}, {Y}, {Z})";
		}

		public int CompareTo(object? obj)
		{
			Point3D pass = (Point3D)obj;
			if (this.X < pass.X)
				return -1;
			else if (this.X > pass.X)
					return 1;
			else
				return 0;
		} 
		public object Clone()
		{
			return new Point3D(X, Y, Z);
		}
	}
}
