using Demo.Static;
using OOP05.Casting_Operaotr;
using OOP05.Operaot_Overloading;
using static System.Net.Mime.MediaTypeNames;

namespace OOP05
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Operaot Overloading

			Complex C1 = new Complex() { Real = 1, Imag = 4 };
			Complex C2 = new Complex() { Real = 2, Imag = 2 };

			#region Binary Operator

			//Complex C3 = C1 + C2;
			//C3 += C1;
			//// C3 = C3 + C1
			//C3 = C1 - C2;

			#endregion

			Complex C3 = C2;

			#region unary Operator

			//Console.WriteLine(C1.GetHashCode());
			//Console.WriteLine(C3.GetHashCode());

			//Console.WriteLine(C1);
			//Console.WriteLine(C3);

			//C3 = C1++;
			//Console.WriteLine("after postfix C1++ ");

			//Console.WriteLine(C1.GetHashCode());
			//Console.WriteLine(C3.GetHashCode());

			//Console.WriteLine(C1);
			//Console.WriteLine(C3);
			//C3 = C1--;
			//Console.WriteLine("after postfix C1-- ");

			//Console.WriteLine(C1.GetHashCode());
			//Console.WriteLine(C3.GetHashCode());

			//Console.WriteLine(C1);
			//Console.WriteLine(C3);
			//C3 = ++C1;
			//Console.WriteLine("after preefix ++C1 ");
			//Console.WriteLine(C1.GetHashCode());
			//Console.WriteLine(C3.GetHashCode());

			//Console.WriteLine(C1);
			//Console.WriteLine(C3);
			//C3 = --C1;
			//Console.WriteLine("after preefix --C1 ");
			//Console.WriteLine(C1.GetHashCode());
			//Console.WriteLine(C3.GetHashCode());

			//Console.WriteLine(C1);
			//Console.WriteLine(C3); 
			#endregion

			#region Comparison Operator [Relational]
			//if (C1> C2)
			//{
			//             Console.WriteLine("C1 is greater");
			//         }
			//else if (C1 < C2)
			//{
			//	Console.WriteLine("C2 is greater");
			//}
			//else
			//{
			//	Console.WriteLine("C1 = C2");
			//} 
			#endregion
			#endregion

			#region Casting Operator

			//long x = 50;
			//int y = (int)x;
			//int z = (int) C1;
			//         Console.WriteLine(z);
			//string str = (string)C1;//explicit
			//str =  C1;//implicit

			//Console.WriteLine(str); 
			#endregion

			#region Need Of Casting Operator

			//Employee employee = new Employee()
			//{
			//	Id = 10,
			//	FullName="Yousef Ayman",
			//	Email="yousefxbxd12@gmail.com",
			//	Password= "Password"

			//};
			//EmployeeViewModel employeeView = (EmployeeViewModel)employee;
			//         Console.WriteLine(employeeView.Fname);
			//         Console.WriteLine(employeeView.Lname);
			//         Console.WriteLine(employeeView.Email);
			#endregion

			#region Abstraction
			////Shape shape = new Shape();
			////shape.CalArea();


			////Rectangle rectangle = new Rectangle();
			//Rectangle rectangle = new Rectangle()
			//{
			//    Dim01 = 10,
			//    Dim02 = 10
			//};

			//Console.WriteLine(rectangle.CalArea());
			//Console.WriteLine(rectangle.perimiter);


			//Circle c = new Circle(10);
			//Console.WriteLine(c.CalArea());
			//Console.WriteLine(c.perimiter); 
			#endregion


			#region Static
			Utility obj1 = new Utility(1, 2);

			Utility obj2 = new Utility(2, 3);

			Console.WriteLine(Utility.CmToInch(10));
			Console.WriteLine(Utility.CmToInch(10)); 
			Console.WriteLine("******************");
			Console.WriteLine(Utility.CalCircleArea(10)); // 314
			Console.WriteLine(Utility.CalCircleArea(10)); // 314 
			#endregion
		}
	}
}
