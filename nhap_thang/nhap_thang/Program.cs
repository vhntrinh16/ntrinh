/*
 * Created by SharpDevelop.
 * User: dell
 * Date: 11/27/2018
 * Time: 9:35 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace nhap_thang
{
	class Program
	{
		public static void Main(string[] args)
		{
			int n;
			Console.Write("Enter n: ");
			n = int.Parse(Console.ReadLine());
			switch(n)
			{
				case 1:
				case 2:
				case 3:
					Console.WriteLine("Thang {0} thuoc quy I", n);
					break;
				case 4:
				case 5:
				case 6:
					Console.WriteLine("Thang {0} thuoc quy II", n);
					break;
				case 7:
				case 8:
				case 9:
					Console.WriteLine("Thang {0} thuoc quy III", n);
					break;
				case 10:
				case 11:
				case 12:
					Console.WriteLine("Thang {0} thuoc quy IV", n);
					break;
				default:
					Console.WriteLine("áđas");
					break;
			}
		
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}