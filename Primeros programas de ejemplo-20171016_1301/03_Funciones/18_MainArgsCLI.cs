using System;

namespace Proyecto01
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			for (int i = 0; i < args.Length; i++) {
				Console.WriteLine ("El parámetro {0} vale: {1}", i, args[i]);
			}
			Console.ReadLine ();
		}

	}
}
