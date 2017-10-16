using System;

namespace Proyecto01
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[,] a = new int[5,10];
			Random rnd = new Random ();
			for (int i = 0; i < a.GetLength(0); i++) {
				for (int j = 0; j < a.GetLength (1); j++) {
					a [i, j] = rnd.Next() % 100;
				}
			}
			Console.Write ("[");
			for (int i = 0; i < a.GetLength(0); i++) {
				Console.Write ("[");
				for (int j = 0; j < a.GetLength (1); j++) {
					Console.Write (a[i,j]+",");
				}
				Console.WriteLine ("],");
			}
			Console.WriteLine ("]");
			Console.ReadLine();
		}
	}
}
