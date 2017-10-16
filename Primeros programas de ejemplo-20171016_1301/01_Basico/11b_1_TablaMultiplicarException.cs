using System;

namespace Proyecto01
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n;
			Console.Write ("Dame un número: ");
			try {
				n  = int.Parse (Console.ReadLine());
			} catch (FormatException x){
				Console.WriteLine ("No sé de qué me hablas. Voy a suponer la tabla del 5.");
				n = 5;
			}
			for (int i = 1; i <= 10; i++) {
				Console.WriteLine (n +" x "+i+" = "+(n*i));
			}
			Console.ReadLine ();
		}
	}
}
