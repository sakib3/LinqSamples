using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Features
{
	class Program
	{
		static void Main(string[] args)
		{
			IEnumerable<Employee> developers = new Employee[]
			{
				new Employee {Id = 1, Name = "Scott"},
				new Employee {Id = 2, Name = "Chris"}
			};

			IEnumerable<Employee> sales = new List<Employee>()
			{
				new Employee {Id = 3, Name ="Alex"}
			};


			//IEnumerator<Employee> enumarator = developers.GetEnumerator();

			//while (enumarator.MoveNext())
			//{
			//	Console.WriteLine(enumarator.Current.Name);
			//}

			//IEnumerator<Employee> enumarator2 = sales.GetEnumerator();

			//while (enumarator2.MoveNext())
			//{
			//	Console.WriteLine(enumarator2.Current.Name);
			//}

			//Console.WriteLine(developers.Count());

			foreach (var developer in developers
					.Where(delegate(Employee employee){
								return employee.Name.StartsWith("S");
							})
					){
					Console.WriteLine(developer.Name);
			}
		}

		//private static bool NameStartsWithS(Employee employee)
		//{
		//	return employee.Name.StartsWith("S");
		//}
	}
}
