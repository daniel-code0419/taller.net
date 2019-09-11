/*
 * Created by SharpDevelop.
 * User: Daniel
 * Date: 11/09/2019
 * Time: 12:02 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace punto7
{
	class Program
	{
		public static void Main(string[] args)
		{
			int A, B, C;
			Console.WriteLine("ingrese el primer numero");
			A = int.Parse(Console.ReadLine());
			Console.WriteLine("ingrese el segundo numero");
			B = int.Parse(Console.ReadLine());
			Console.WriteLine("ingrese el tercer numero");
			C = int.Parse(Console.ReadLine());
			if(A > B && A > C){
        Console.WriteLine("El numero mayor es "+A);
        }else
            if(B > A && B > C){
            Console.WriteLine("El numero mayor es "+B);
            }else{
            Console.WriteLine("El numero mayor es "+C);
            }      
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}