using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAge
{
	class InputDate
	{
			public int year;
			public int month;
			public int day;

			public InputDate(int year, int month, int day)
			{
				this.year = year;
				this.month = month;
				this.day = day;
			}

			public void InfoInputDate()
			{
				Console.WriteLine("Введенная дата: {0}.{1}.{2}г", day, month, year);
			}
	}
}
