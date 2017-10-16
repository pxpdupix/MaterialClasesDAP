using System;

namespace Proyecto01
{
	class MainClass
	{
		public static double[] RaizCuadrada(double[] v ){
			double[] ret = new double[v.Length];
			for (int i = 0; i < v.Length; i++)
				ret [i] = Math.Sqrt (v [i]);
			return ret;
		}
		public static void Main (string[] args)
		{
			double[] vector = new double[]{23.6, 56.7, 23.88};
			double[] raices = RaizCuadrada (vector);
			Console.Write ("[");
			for (int i = 0; i < raices.Length; i++)
				Console.Write (raices [i] + ", ");
			Console.WriteLine ("]");
			Console.ReadLine();
		}
	}
}