/*
 * Created by SharpDevelop.
 * User: dell
 * Date: 11/29/2018
 * Time: 10:25 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace bai608
{
	class Program
	{
		public static void Main(string[] args)
		{
			clsHopSua a,b,c;
			a = new clsHopSua();
			a.DatNhanHieu("Vinamilk");
			Console.WriteLine("Hop sua: {0}", a.LayNhanHieu());
			//a.Nhap();
			
			b = new clsHopSua();
			b.DatTrongLuong(10);
			Console.WriteLine("Trong luong: {0}", b.XuatTL());
			
			c = new clsHopSua();
			c.DatNgay(DateTime.Now);
			Console.WriteLine("Han su dung: {0}", c.XuatNgay());
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
	}
}
		}