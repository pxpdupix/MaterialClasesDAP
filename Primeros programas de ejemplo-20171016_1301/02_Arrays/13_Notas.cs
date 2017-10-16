using System;

namespace Proyecto01
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] n = new int[5];
			string[] calificaciones = new string[5];
			for (int i = 0; i < 5; i++) {
				Console.Write ("Introduce el valor de la posición "+i+": ");
				n [i] = int.Parse (Console.ReadLine ());
			}
			for (int i = 0; i < 5; i++) {
				if (n [i] < 5)
					calificaciones [i] = "Suspenso";
				else if (n [i] < 8)
					calificaciones [i] = "Aprobado";
				else if (n [i] < 9)
					calificaciones [i] = "Notable";
				else if (n [i] < 10)
					calificaciones [i] = "Sobresaliente";
				else 
					calificaciones [i] = "Matrícula de Honor";
			}
			for (int i = 0; i < 5; i++) {
				Console.Write ("La nota de la posición "+i+" es: "+calificaciones[i]);
			}
			Console.ReadLine ();
		}
	}
}
