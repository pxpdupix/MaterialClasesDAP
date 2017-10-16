using System;

namespace Proyecto01
{
	class MainClass
	{
		public static void tablaMultiplicar (int n)
		{
			for (int i = 1; i <= 10; i++) {
				Console.WriteLine (n + " x " + i + " = " + (n * i));
			}
		}

		public static void Main (string[] args)
		{
			for (int i = 0; i < 10; i++) {
				Console.WriteLine ("La tabla del {0} es:", i+1);
				tablaMultiplicar (i + 1);
			}
			Console.ReadLine ();
		}

	}
}
