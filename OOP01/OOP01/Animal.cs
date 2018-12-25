/*
 * Created by SharpDevelop.
 * User: dell
 * Date: 12/3/2018
 * Time: 1:34 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace OOP01
{
	/// <summary>
	/// Description of Animal.
	/// </summary>
	public class Animal
	{
		public string Name;
		public Animal()
		{
			Name  = "Animal";
		}
		public Animal(string sName)
		{
			Name = sName;
		}
		public override string ToString()
		{
			return string.Format("Name:{0}", Name);
		}
		public virtual void Move()
		{
			Console.WriteLine("Animal Move: {0}", Name);
		}
		public void Sleep()
		{
			Console.WriteLine("Sleep: {0}", Name);
		}
	}
}
