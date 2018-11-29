using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationDataTime
{
	class Program
	{
		static void Main(string[] args)
		{
			DateTime data1 = new DateTime(2017, 07, 18);
			TimeSpan data2 = new TimeSpan(5, 07, 12);
			DateTime data3 = data1.Add(data2);
			Console.WriteLine(data3);
		}
	}
}
