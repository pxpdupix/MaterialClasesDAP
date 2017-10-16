using System;

namespace Proyecto01
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = 10;
			for(int i=1;i<=n;i++){
				for (int x = i; x <= n; x++) {
					Console.Write (" ");
				}
				for (int x = 1; x <= i; x++) {
					Console.Write ("*");
				}
				Console.WriteLine ("");
			}
			Console.ReadLine ();
		}
	}
}
