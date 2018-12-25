/*
 * Created by SharpDevelop.
 * User: dell
 * Date: 12/3/2018
 * Time: 3:01 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace OOP01
{
	/// <summary>
	/// Description of Duck.
	/// </summary>
	public class Duck: Animal
	{
		public Duck():base()
		{
		}
		public new void Move()
		{
			Console.WriteLine("Duck Move..");
		}
	}
}
