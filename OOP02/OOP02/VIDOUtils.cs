/*
 * Created by SharpDevelop.
 * User: dell
 * Date: 12/4/2018
 * Time: 9:33 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP02
{
	/// <summary>
	/// Description of VIDOUtils.
	/// </summary>
	public class VIDOUtils
	{
		public VIDOUtils()
		{
		}
		public double ReadNumber(string Message, double Min, double Max)
		{
			double result = 0;
			do
			{
				try
				{
					Console.Write(Message);
					result = double.Parse(Console.ReadLine());
				}catch(Exception ex)
				{
					result = Min - 1;
					Console.WriteLine("Input is not correct !");
					//Console.WriteLine(ex.ToString());
				}
			}while (result < Min || result > Max);
			
			return result;
		}
		public int ReadNumber(string Message, int Min, int Max)
		{
			int result = 0;
			do
			{
				try
				{
					Console.Write(Message);
					result = int.Parse(Console.ReadLine());
				}catch(Exception ex)
				{
					result = Min - 1;
					Console.WriteLine("Input is not correct !");
					//Console.WriteLine(ex.ToString());
				}
			}while (result < Min || result > Max);
			
			return result;
		}
		public List<QLTS> Top(List<QLTS> list, int iNumber)
		{
			List<QLTS> result = list.OrderByDescending(ts => ts.TongDiem).ToList();
			result.RemoveRange(iNumber,list.Count - iNumber);
			return result;
		}
	}
}
