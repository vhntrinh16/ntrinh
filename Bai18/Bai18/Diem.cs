/*
 * Created by SharpDevelop.
 * User: dell
 * Date: 12/25/2018
 * Time: 8:29 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Bai18
{
	/// <summary>
	/// Description of Diem.
	/// </summary>
	public class Diem
	{
		public int hd, td;
		public Diem (int a, int b)
		{
			hd = a;
			td = b;
		}
		public int ihd
		{
			get{
				return hd;
			}
			set{
				hd = value;
			}
		}
		public int itd
		{
			get{
				return td;
			}
			set{
				td = value;
			}
		}
		public override string ToString()
		{
			return string.Format("[Diem Hd={0}, Td={1}]", hd, td);
		}

		public Diem()
		{
			hd = 0;
			td = 0;
		}
		public static double Khoangcach(Diem a, Diem b)
		{
			double kc = 0;
			kc = Math.Sqrt(Math.Pow(a.hd - b.hd,2)+Math.Pow(a.td - b.td,2));
			return kc;
		}
	}
}
