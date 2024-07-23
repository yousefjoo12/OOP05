namespace OOP05
{
	internal class Program
	{

		static void Main(string[] args)
		{
			//Point3D point = new Point3D(1,3,5);

			//Console.WriteLine($"point: ({point.X}, {point.Y}, {point.Z})");
			//         Console.WriteLine(point.ToString());


			//Console.WriteLine("Enter the coordinates for Point P1 (x, y, z):");
			//Point3D p1 = ReadPointFromUser();

			//Console.WriteLine("Enter the coordinates for Point P2 (x, y, z):");
			//Point3D p2 = ReadPointFromUser();

			//Console.WriteLine($"P1: {p1.ToString()}");
			//Console.WriteLine($"P2: {p2.ToString()}");

			//if (p1 == p2)
			//	Console.WriteLine("p1 and p2 are equal.");
			//else
			//	Console.WriteLine("p1 and p2 are not equal.");// Does't work 

			Point3D[] p =
			{
				new Point3D(){X=1,Y=4,Z=5},
				new Point3D(){X=1,Y=5,Z=5},
				new Point3D(){X=1,Y=3,Z=5},

			};
			Array.Sort(p);

			foreach (var item in p)
			{
				Console.WriteLine(item);
			}


		}
		static Point3D ReadPointFromUser()
		{
			int x, y, z;

			Console.Write("Enter x coordinate: ");
			if (!int.TryParse(Console.ReadLine(), out x))
			{
				Console.WriteLine("Invalid input  x ");
				x = 0;
			}

			Console.Write("Enter y coordinate: ");
			if (!int.TryParse(Console.ReadLine(), out y))
			{
				Console.WriteLine("Invalid input  y ");
				y = 0;
			}

			Console.Write("Enter z coordinate: ");
			if (!int.TryParse(Console.ReadLine(), out z))
			{
				Console.WriteLine("Invalid input  z ");
				z = 0;
			}

			return new Point3D(x,y ,z);
		}
	}
}

