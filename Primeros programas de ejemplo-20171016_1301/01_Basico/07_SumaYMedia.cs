using System;

namespace Proyecto01
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int num1, num2, num3;			num1 = int.Parse (Console.ReadLine());			num2 = int.Parse (Console.ReadLine());			num3 = int.Parse (Console.ReadLine());			Console.WriteLine("La suma es "+(num1+num2+num3));			Console.WriteLine("La media es "+(num1+num2+num3)/3);			Console.ReadLine ();
		}
	}
}
