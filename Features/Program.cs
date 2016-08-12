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
				new Employee {Id = 2, Name = "Christian"},
				new Employee {Id = 3, Name = "Alibö"}
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
						.Where(e => e.Name.Length == 5)
						.OrderBy(e => e.Name)
					){
					Console.WriteLine(developer.Name);
			}

			//Func<int, int> square = num => num*num;
			//Func<int, int, int> add = (a,b) => a+b;
			//Console.WriteLine(square(3));
			//Action<int> write = num => Console.WriteLine(num);
			//write(add(1,5));
		}

		//private static bool NameStartsWithS(Employee employee)
		//{
		//	return employee.Name.StartsWith("S");
		//}
	}
}
