using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAge
{
	class Program
	{
		static void Main(string[] args)
		{
			/*DateTime thisDay = DateTime.Now;
			/*Console.WriteLine("Привет, сегодня ", thisDay);
			Console.WriteLine("Что бы узнать свой возраст на определенную дату, введите дату ...");
			Console.ReadLine()
			DateTime summaDateTime = thisDay;
			Console.WriteLine(thisDay);
			DateTime newthisDay = thisDay.AddYears(15);
			Console.WriteLine(newthisDay);
			DateTime t;
			t.GetDateTimeFormats();*/

			InputDate d = new InputDate(17,12,31);
			Console.WriteLine(d.InfoInputDate());
		}
	}
}
