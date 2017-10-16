using System;

namespace Proyecto01
{
	class MainClass
	{
		public static void RaizCuadrada(double[] v ){
			for (int i = 0; i < v.Length; i++)
				v [i] = Math.Sqrt (v [i]);
		}
		public static void Main (string[] args)
		{
			double[] vector = new double[]{23.6, 56.7, 23.88};
			RaizCuadrada (vector);
			Console.Write ("[");
			for (int i = 0; i < vector.Length; i++)
				Console.Write (vector [i] + ", ");
			Console.WriteLine ("]");
			Console.ReadLine();
		}
	}
}