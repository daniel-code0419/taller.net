/*
 * Created by SharpDevelop.
 * User: Daniel
 * Date: 10/09/2019
 * Time: 8:50 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Punto1
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int opcion;
			double num1, num2;
			Console.WriteLine("Elige una opcion:");
			Console.WriteLine("1-  Adicion");
			Console.WriteLine("2-  Sustraccion");
			Console.WriteLine("3-  Multiplicacion");
			Console.WriteLine("4-  Division");
			opcion = int.Parse(Console.ReadLine());
			Console.WriteLine("Digite un numero");
			num1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Digite otro numero");
			num2 = int.Parse(Console.ReadLine());
			if (opcion == 1){
				Console.WriteLine("La suma de los numeros es " + (num1+num2));
			}if (opcion == 2){
				Console.WriteLine("La resta de los numeros es "+ (num1 - num2));
			}if (opcion ==3){
				Console.WriteLine("La multiplicacion de los numeros es "+ (num1 * num2));
			}if (opcion ==4){
				Console.WriteLine("La division de los numeros es "+ (num1 / num2));
			}else {
				Console.WriteLine("opcion no valida");
			}
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}