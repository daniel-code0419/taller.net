/*
 * Created by SharpDevelop.
 * User: Daniel
 * Date: 10/09/2019
 * Time: 11:34 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace punto5
{
	class Program
	{
		public static void Main(string[] args)
		{
			string letra;
			Console.WriteLine("Digite una letra");
			letra = Console.ReadLine().ToLower();
			if ( letra =="a" || letra == "e" || letra =="i" || letra == "o" || letra == "u"){
				Console.WriteLine("La letra es una vocal");
			}else {
				Console.WriteLine("La letra es una consonante");
			}
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}