using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
	class Client: IAccount, IPercentAccount
	{
		int summa;
		int percent;
		public string Name { get; set; }
		public Client (string name, int sum, int percentage)
		{
			Name = name;
			summa = sum;
			percent = percentage;
		}
		public int CurrentSum
		{
			get { return summa; }
		}
		public int Percentage
		{
			get { return percent; }
		}
		public void Put(int sum)
		{
			summa += sum;
		}
		public void Withdraw(int sum)
		{
			if (summa >= sum)
			{
				summa -= sum;
			}
			else
			{
				Console.WriteLine("Недостаточная сумма на счете");
			}
		}
		public void CalculationIncome()
		{

		}
		public void InfoClient()
		{
			Console.WriteLine("Клиент " + Name + " имеет счет на сумму " + summa);
		}
	}
}
