/*
 * Created by SharpDevelop.
 * User: Daniel
 * Date: 11/09/2019
 * Time: 12:11 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace punto8
{
	class Program
	{
		public static void Main(string[] args)
		{
			double articulo, descuento;
			Console.WriteLine("Digite cuanto le costo el articulo");
			articulo = double.Parse(Console.ReadLine());
			if (articulo >= 200){
				descuento = articulo * 0.15;
				Console.WriteLine("su articulo tiene un descuento del 15% y ahora cuesta " + (articulo - descuento) );
			}if (articulo > 100 && articulo <200){
				descuento = articulo *0.12;
				Console.WriteLine("Su articulo tiene un descuento del 12% y ahora cuesta " + (articulo - descuento) );
			}if (articulo <= 100){
				descuento = articulo *0.10;
				Console.WriteLine("Su articulo tiene un descuento del 10% y ahora cuesta " + (articulo - descuento) );
			}
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}