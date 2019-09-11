/*
 * Created by SharpDevelop.
 * User: Daniel
 * Date: 10/09/2019
 * Time: 11:23 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace punto4
{
	class Program
	{
		public static void Main(string[] args)
		{
			string nombre;
			int unidad;
			Console.WriteLine("Cual es su nombre?");
			nombre = Console.ReadLine();
			Console.WriteLine("digite cuando consumio en electricidad");
			unidad = int.Parse(Console.ReadLine());
			if (unidad > 0 && unidad < 200){
				Console.WriteLine("Usted debe pagar " + unidad * 1.20+"$");
			}if (unidad >= 200 && unidad <= 400){
				Console.WriteLine("Usted debe pagar " + unidad * 1.50+"$");
			}if (unidad >400 && unidad < 600){
				Console.WriteLine("Usted debe pagar " + unidad * 1.80+"$");
			}if (unidad > 600){
				Console.WriteLine("Usted debe pagar " + unidad * 2.0+"$");
			}else {
				Console.WriteLine("Error");
			}
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}