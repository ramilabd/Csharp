using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
	interface IAccount   
	{
		int CurrentSum { get; }  //свойство получает текущую сумму
		int Percentage { get; } //свойство получает текущую процент
		void Put(int sum);       // метод зачисляет сумму (int sum) на счет
		void Withdraw(int sum);  // метод снимает сумму (int sum) со счета
	}

	/* интерфейс определяет функционал без конкретной реализации, все члены интерфейса 
	не имеют модификатора доступа, но по умолчанию public - функционал должен быть открыт для 
	реализации*/
}
