using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features
{
	class Program
	{
		static void Main(string[] args)
		{
			Employee[] developers = new Employee[]
			{
				new Employee {Id = 1, Name = "Scott"},
				new Employee {Id = 2, Name = "Chris"}
			};

			List<Employee> sales = new List<Employee>()
			{
				new Employee {Id = 3, Name ="Alex"}
			};

			foreach (var developer in developers)
			{
				Console.WriteLine(developer.Name);
			}

			foreach (var employee in sales)
			{
				Console.WriteLine(employee.Name);
			}
		}
	}
}
