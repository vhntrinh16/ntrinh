/*
 * Created by SharpDevelop.
 * User: dell
 * Date: 12/3/2018
 * Time: 3:20 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace OOP02
{
	/// <summary>
	/// Description of QLTS.
	/// </summary>
	public class QLTS
	{
		public string MSTS;
		public string HoTen;
		public double TongDiem;
		public QLTS()
		{
			
		}
		public virtual void Nhap()
		{
			base.ToString();
			Console.Write("MSTS: ");
			MSTS = Console.ReadLine();
			Console.Write("Ho ten: ");
			HoTen = Console.ReadLine();
		}
		public override string ToString()
		{
			return string.Format("[QLTS MSTS={0}, HoTen={1}, TongDiem={2}]", MSTS, HoTen, TongDiem);
		}
	}
}
