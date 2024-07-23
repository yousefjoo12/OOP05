using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Sealed
{
	internal sealed class paymentProcessor
	{
		public void Processorpayment(double amount)
		{
			Console.WriteLine($"amount ={amount * 10}");
		}
	}

	//internal class inheritpayment : paymentProcessor
	//{
	//	public override void Processorpayment(double amount)
	//	{
	//		Console.WriteLine($"amount ={amount * 20}");

	//	}

	//}

	internal class Parent
	{
		private int salary;

		public virtual int Salary
		{
			get { return salary; }
			set { salary = value - 1000; }
		}

		public virtual void print()
		{
			Console.WriteLine("i am Parent");
		}
	}
	internal class Child : Parent
	{
		public sealed override int Salary
		{
			get => base.Salary;
			set => base.Salary = value - 2000;
		}
		public sealed override void print()
		{
			Console.WriteLine("i am Child");
		}
	}
	sealed internal class GrandChild : Child
	{

	}
	//class test : GrandChild
	//{

	//}
}
