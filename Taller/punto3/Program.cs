/*
 * Created by SharpDevelop.
 * User: Daniel
 * Date: 10/09/2019
 * Time: 11:11 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace punto3
{
	class Program
	{
		public static void Main(string[] args)
		{
			int mes;
			Console.WriteLine("Digite el numero el mes del que quiere saber los dias");
			mes = int.Parse(Console.ReadLine());
			switch (mes){
					case 1: mes = 31;
					break;
					case 2: mes = 28;
					break;
					case 3: mes = 31;
					break;
					case 4: mes = 30;
					break;
					case 5: mes = 31;
					break;
					case 6: mes = 30;
					break;
					case 7: mes = 31;
					break;
					case 8: mes = 31;
					break;
					case 9: mes = 30;
					break;
					case 10: mes = 31;
					break;
					case 11: mes = 30;
					break;
					case 12: mes = 31;
					break;
	
			}
			Console.WriteLine("el mes tiene " + mes + " dias" );
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}