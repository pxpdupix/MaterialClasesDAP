using System;

namespace Proyecto01
{
	class MainClass
	{
		public static int[,] Sumar(int[,] a1, int[,] a2){
			int[,] res = new int[a1.GetLength(0), a1.GetLength(1)];
			for (int i = 0; i < a1.GetLength(0); i++) {
				for (int j = 0; j < a1.GetLength (1); j++) {
					res [i, j] = a1 [i, j] + a2 [i, j];
				}
			}
			return res;
		}
		public static void Ver(int[,] a){
			Console.Write ("[");
			for (int i = 0; i < a.GetLength(0); i++) {
				Console.Write ("[");
				for (int j = 0; j < a.GetLength (1); j++) {
					Console.Write (a[i,j]+",");
				}
				Console.WriteLine ("],");
			}
			Console.WriteLine ("]");
		}
		public static void Main (string[] args)
		{
			int[,] a1 = new int[5,10];
			Random rnd = new Random ();
			for (int i = 0; i < a1.GetLength(0); i++) {
				for (int j = 0; j < a1.GetLength (1); j++) {
					a1 [i, j] = rnd.Next() % 100;
				}
			}
			Ver (a1);
			int[,] a2 = new int[5,10];
			for (int i = 0; i < a2.GetLength(0); i++) {
				for (int j = 0; j < a2.GetLength (1); j++) {
					a2 [i, j] = rnd.Next() % 100;
				}
			}
			Ver (a2);
			int[,] res = Sumar (a1, a2);
			Ver (res);
			Console.ReadLine();
		}
	}
}