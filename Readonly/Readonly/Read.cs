using System;

namespace Readonly
{
	class Read
	{
		public readonly int x;

		public Read(int y) //конструктор
		{
			x = y;
		}

		public void Display()
		{
			Console.WriteLine(x);
		}
	}
}
