namespace Third_Project
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Duration D = new Duration(1, 10, 15);
			Console.WriteLine(D.ToString());
			//Output: Hours: 1, Minutes: 10, Seconds: 15

			Duration D1 = new Duration(3600);
			Console.WriteLine(D1.ToString());
			//Output: Hours: 1, Minutes: 0, Seconds: 0

			Duration D2 = new Duration(7800);
			Console.WriteLine(D2.ToString());
			//Output: Hours: 2, Minutes: 10, Seconds: 0

			Duration D3 = new Duration(666);
			Console.WriteLine(D3.ToString());
			//Output: Minutes: 11, Seconds: 6

		}
	}
}
