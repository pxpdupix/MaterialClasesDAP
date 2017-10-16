using System;

namespace Proyecto01
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			char[] letras={'T','R','W','A','G','M','Y','F','P','D','X','B','N','J','Z','S','Q','V','H','L','C','K','E'};
			int dninumero;
			dninumero = int.Parse (Console.ReadLine ());
			Console.WriteLine ("La letra asociada es: " + letras [dninumero % 23]);
			Console.ReadLine ();
		}
	}
}
