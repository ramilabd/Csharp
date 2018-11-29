using System;

namespace Inheritance
{
	class Employee2: Person2
	{
		// т.к. конструктор не наслудуется, то мы сами создаем контруктор для наследуемого класса, 
		// а т.к. переменные fName, lName это переменные конструктора в базовом классе то мы явно 
		// это указываем :base (fName, lName), а также можем добавить дополнительный парметр в 
		// конструктор Employee2() - string comp, и осбственные автосовойства public string Company { get; set; }
		 
		public string Company { get; set; }
		public Employee2(string fName, string lName, string comp)
			:base (fName, lName)
		{
			Company = comp;
		}
	}
}
