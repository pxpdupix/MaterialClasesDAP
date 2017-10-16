using System;

namespace Proyecto01
{
	class MainClass
	{
		public static double AreaEsfera(double radio){
			return 4 * Math.PI * Math.Pow(radio, 2);
		}
		public static void Main (string[] args)
		{
			double radio = double.Parse (Console.ReadLine());
			Console.WriteLine ("La superficie de un planeta de radio {0} es {1}.", radio, AreaEsfera (radio));
			Console.ReadLine();
		}
	}
}