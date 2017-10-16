using System;

namespace Proyecto01
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int cents;			cents = int.Parse (Console.ReadLine());			Console.WriteLine(cents+" céntimos se cambian por:");
			int monedas200 = cents / 200;
			cents = cents % 200; 			int monedas100 = cents / 100;			cents = cents % 100;			int monedas50 = cents / 50;			cents = cents % 50;			int monedas20 = cents / 20;			cents = cents % 20;			int monedas10 = cents / 10;			cents = cents % 10;			int monedas5 = cents / 5;			cents = cents % 5;			int monedas2 = cents / 2;			cents = cents % 2;			int monedas1 = cents;			Console.WriteLine(monedas200+" monedas de 2 euros,");			Console.WriteLine(monedas100+" monedas de 1 euro,");			Console.WriteLine(monedas50+" monedas de 50 céntimos,");			Console.WriteLine(monedas20+" monedas de 20 céntimos,");			Console.WriteLine(monedas10+" monedas de 10 céntimos,");			Console.WriteLine(monedas5+" monedas de 5 céntimos,");			Console.WriteLine(monedas2+" monedas de 2 céntimos,");			Console.WriteLine(monedas1+" monedas de 1 céntimos.");			Console.ReadLine ();
		}
	}
}
