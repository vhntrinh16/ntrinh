/*
 * Created by SharpDevelop.
 * User: dell
 * Date: 12/3/2018
 * Time: 1:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace OOP01
{
	class Program
	{
		public static void Main(string[] args)
		{
			Animal a, b, c;
			//Cat c;
			Animal d;
			
			a = new Animal();
			b = new Animal("Cat");
			c = new Cat();
			d = new Duck();
			
			d.Sleep();
			d.Move();
			
			c.Sleep();
			c.Move();
			
			Console.WriteLine(a.ToString());
			Console.WriteLine(b.ToString());
			Console.WriteLine(c.ToString());
			/*
			a.Move();
			b.Move();
			c.Move();
			((Cat)c).Say();
			a.Sleep();
			b.Sleep();
			c.Sleep();
			*/
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}