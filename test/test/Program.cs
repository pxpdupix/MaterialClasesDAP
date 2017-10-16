using System;

namespace Proyecto01
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int agno;
			agno = int.Parse(Console.ReadLine());
			if (((agno % 4 == 0) && (agno % 100 != 0)) || (agno % 400 == 0)){
				Console.WriteLine(agno + " es bisiesto.");
			}
			else
			{
				Console.WriteLine(agno + " no es bisiesto.");
			}
			Console.ReadLine();
		}
	}
}

