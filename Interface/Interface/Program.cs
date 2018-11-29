using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
	class Program
	{
		static void Main(string[] args)
		{
			Client client = new Client("Ramil", 100, 15);
			client.Put(150);
			client.InfoClient();
		}
	}
}
