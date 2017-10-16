using System;

namespace Proyecto01
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n;
			Console.Write ("Dame un número: ");
			n  = int.Parse (Console.ReadLine());
			for (int i = 1; i <= 10; i++) {
				Console.WriteLine (n +" x "+i+" = "+(n*i));
			}
			Console.ReadLine ();
		}
	}
}
