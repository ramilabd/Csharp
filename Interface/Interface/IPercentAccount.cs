using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
	interface IPercentAccount: IAccount
	{
		void CalculationIncome();
	}

	/*интерфейс IPercentAccount наследует от интерфейса IAccount. При применении интерфейса IPercentAccount класс Client должен 
	 * будет реализовать как методы и свойства интерфейса IDepositAccount, так и методы и свойства базового интерфейса IAccount*/
}
