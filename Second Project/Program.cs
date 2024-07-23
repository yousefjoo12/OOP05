namespace Second_Project
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Enter number1");
			decimal num1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter number2");
			decimal num2 = int.Parse(Console.ReadLine());
			 

			decimal Resultadd = Maths.Add(num1, num2);
			Console.WriteLine($"Result: {Resultadd}");

			decimal ResultMul = Maths.Mul(num1, num2);
			Console.WriteLine($"Result: {ResultMul}");

			decimal ResultSub = Maths.Sub(num1, num2);
			Console.WriteLine($"Result: {ResultSub}");

			decimal ResultDiv = Maths.Div(num1, num2);
			Console.WriteLine($"Result: {ResultDiv}");


		}
	}
}
