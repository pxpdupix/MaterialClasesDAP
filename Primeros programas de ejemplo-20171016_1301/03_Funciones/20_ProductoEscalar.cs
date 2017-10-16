using System;

namespace Proyecto01
{
	class MainClass
	{
		public static double[] Multiplicar(double[] v1, double[] v2){
			double[] res = new double[v1.Length];
			for (int i = 0; i < v1.Length; i++) {
				res [i] = v1 [i] * v2 [i];
			}
			return res;
		}
		public static void Main (string[] args)
		{
			double[] v1 = { 13.6, 33.8, 11.95, 56.5, 17.8 };
			double[] v2 = { 2.3, 1.1, 4.67, 2.178, 3.0 };
			double[] res  = Multiplicar (v1, v2);
			Console.Write ("El resultado es: \n [");
			for (int i = 0; i < v1.Length; i++) {
				res [i] = v1 [i] * v2 [i];
				Console.Write (res [i] + ", ");
			}
			Console.WriteLine ("]");
		}
	}
}