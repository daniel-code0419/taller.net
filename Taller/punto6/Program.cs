/*
 * Created by SharpDevelop.
 * User: Daniel
 * Date: 10/09/2019
 * Time: 11:48 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace punto6
{
	class Program
	{
		public static void Main(string[] args)
		{
			int n;
			double f;
			Console.WriteLine("Digite N");
			n = int.Parse(Console.ReadLine());
			f = (1 / Math.Sqrt(5))*(Math.Pow((1+Math.Sqrt(5)/2),n)) - (Math.Pow(1+Math.Sqrt(5)/2),n);
			Console.WriteLine("La respuesta es "+ f );
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}