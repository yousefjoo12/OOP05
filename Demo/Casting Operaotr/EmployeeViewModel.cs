using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.Casting_Operaotr
{
	//View Model: the class that will be rendered by views[Html]
	internal class EmployeeViewModel
	{
		public string Fname { get; set; }
		public string Lname { get; set; }
		public string Email { get; set; }

		public static  explicit operator EmployeeViewModel(Employee employee)
		{
			string[] Names = employee?.FullName.Split(" ");
			return new EmployeeViewModel()
			{
				// manual mapping
				Fname = Names?.Length > 0 ? Names[0] : string.Empty,
				Lname = Names?.Length > 0 ? Names[1] : string.Empty,
				Email = employee.Email
			};
		}

	}
}
