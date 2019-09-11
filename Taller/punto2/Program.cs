/*
 * Created by SharpDevelop.
 * User: Daniel
 * Date: 10/09/2019
 * Time: 9:12 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace punto2
{
	class Program
	{
		public static void Main(string[] args)
		{
			int opcion;
			double bas, altura,ra,h;
			Console.WriteLine("Programa para calcular el area de diferentes figuras geometricas:");
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("Eliga una opcion");
			Console.WriteLine("Digite 1 para el area del circulo");
			Console.WriteLine("Digite 2 para el area del rectangulo");
			Console.WriteLine("Digite 3 para el area del trinagulo");
			opcion = int.Parse(Console.ReadLine());
			if (opcion == 1){
				Console.WriteLine("Digite el radio del circulo");
				ra = double.Parse(Console.ReadLine());
				Console.WriteLine("El area del circulo es " + 3.14*(ra*ra));
			}if (opcion == 2){
				Console.WriteLine("digite la base del rectangulo");
				bas = double.Parse(Console.ReadLine());
				Console.WriteLine("Digite la altura del rectangulo");
				h = double.Parse(Console.ReadLine());
				Console.WriteLine("El area del rectangulo es " + bas * h );
			}if (opcion == 3){
				Console.WriteLine("Digite la base del triangulo");
				bas = double.Parse(Console.ReadLine());
				Console.WriteLine("Digite la altura del triangulo");
				h = double.Parse(Console.ReadLine());
				Console.WriteLine("El area del rectangulo es " + (bas * h )/2 );
				
			}else if (opcion > 3) {
				Console.WriteLine("opcion incorrecta");
			}
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}