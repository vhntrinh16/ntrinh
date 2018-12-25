/*
 * Created by SharpDevelop.
 * User: dell
 * Date: 12/3/2018
 * Time: 3:14 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
namespace OOP02
{
	class Program
	{
		public static void Main(string[] args)
		{
			VIDOUtils ulti = new VIDOUtils();
			List<QLTS> listThiSinh = new List<QLTS>();
			List<QLTS> listThiSinhKA = new List<QLTS>();
			List<QLTS> listThiSinhKC = new List<QLTS>();
			List<QLTS> listThiSinhKD = new List<QLTS>();
			QLTS ts;
			StudentKhoiA a;
			StudentKhoiB c;
			StudentKhoiD d;
			
			ts = new QLTS();
			ts.Nhap();
			a = new StudentKhoiA();
			a.Nhap();
			c = new StudentKhoiB();
			c.Nhap();
			d = new StudentKhoiD();
			d.Nhap();
			
			Console.WriteLine(ts.ToString());
			Console.WriteLine(a.ToString());
			Console.WriteLine(c.ToString());
			Console.WriteLine(d.ToString());
			
			listThiSinhKA.Clear();
			listThiSinhKC.Clear();
			listThiSinhKD.Clear();
			foreach (var element in listThiSinh) {
				if(element is StudentKhoiA)
					listThiSinhKA.Add(element);
				else if(element is StudentKhoiB)
					listThiSinhKC.Add(element);
				else if(element is StudentKhoiD)
					listThiSinhKD.Add(element);
							
			}
			
			foreach (var element in ulti.Top(listThiSinhKA,2))
			{
				Console.WriteLine(element.ToString());
			}
			foreach (var element in ulti.Top(listThiSinhKC,2))
			{
				Console.WriteLine(element.ToString());
			}
			foreach (var element in ulti.Top(listThiSinhKD,2))
			{
				Console.WriteLine(element.ToString());
			}
			
			
			
			
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}