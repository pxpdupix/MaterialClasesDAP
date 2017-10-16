using System;

namespace Proyecto01
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int pos;
			pos  = int.Parse (Console.ReadLine());
			if (pos == 1) {
				Console.WriteLine("Esa posición la ocupa Mercurio.");
			} else if (pos == 2) {
				Console.WriteLine("Esa posición la ocupa Venus.");
			} else if (pos == 3) {
				Console.WriteLine("Esa posición la ocupa Tierra.");
			} else if (pos == 4) {
				Console.WriteLine("Esa posición la ocupa Marte.");
			} else if (pos == 5) {
				Console.WriteLine("Esa posición la ocupa Júpiter.");
			} else if (pos == 6) {
				Console.WriteLine("Esa posición la ocupa Saturno.");
			} else if (pos == 7) {
				Console.WriteLine("Esa posición la ocupa Urano.");
			} else if (pos == 8) {
				Console.WriteLine("Esa posición la ocupa Neptuno.");
			} else if (pos == 9) {
				Console.WriteLine("Esa posición la ocupa el planeta enano Plutón.");
			} else {
				Console.WriteLine ("Eso debe estar fuera del sistema solar.");
			}
			Console.ReadLine ();
		}
	}
}
