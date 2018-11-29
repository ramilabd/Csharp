using System;
using System.Collections.Generic;

namespace GenericType
{
	class Bank_Int<T>
	{
		private int[] v;

		public Bank_Int(int[] v)  //конструктор
		{
			this.v = v;
		}
	}
}
