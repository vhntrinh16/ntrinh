/*
 * Created by SharpDevelop.
 * User: user
 * Date: 12/6/2018
 * Time: 9:00 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace OOP_onequarter
{
	/// <summary>
	/// Description of fraction.
	/// </summary>
	public class fraction
	{
		private int iTop, iBottom;
		public int Top{
			get
			{
				return iTop;
			}
			set
			{
				iTop = value;
			}
		}
		public int Bottom{
			get
			{
				return iBottom;
			}
			set
			{
				if (iBottom == 0)
				{
					iBottom = 1;
				}
				else
				{
					iBottom = value;
				}
			}
		}
		private int ucln (int a, int b)
		{
			int min;
			if (Math.Abs(a) > Math.Abs(b))
			{
				min = Math.Abs(a);
			}
			else min = Math.Abs(b);
			do
			{
				if(a % min ==0 && b % min == 0)
				{
					break;
				}
				min--;
			}while(min > 1);
			return min;
		}
		public fraction()
		{
			iBottom = 1;
			iTop = 0;
		}
		public static fraction operator+ (fraction a, fraction b)
		{
			fraction frac = new fraction();
			frac.iTop = a.iTop + b.iTop;
			frac.iTop = a.iBottom + b.iBottom;
			return frac;
		}
		public static bool operator== (fraction a, fraction b)
		{
			bool status = false;
			if(a.iTop == b.iTop && a.iBottom == b.iBottom)
			{
				status = true;
			}
			return status;
		}
		public static bool operator!= (fraction a, fraction b)
		{
			bool status = false;
			if(a.iTop != b.iTop || a.iBottom != b.iBottom)
			{
				status = true;
			}
			return status;
		}
		public static bool operator< (fraction a, fraction b)
		{
			bool status = false;
			if(a.iTop < b.iTop && a.iBottom < b.iBottom)
			{
				status = true;
			}
			return status;
		}
		public static bool operator> (fraction a, fraction b)
		{
			bool status = false;
			if(a.iTop > b.iTop && a.iBottom > b.iBottom)
			{
				status = true;
			}
			return status;
		}
		public static bool operator<= (fraction a, fraction b)
		{
			bool status = false;
			if(a.iTop <= b.iTop && a.iBottom <= b.iBottom)
			{
				status = true;
			}
			return status;
		}
		public static bool operator>= (fraction a, fraction b)
		{
			bool status = false;
			if(a.iTop >= b.iTop && a.iBottom >= b.iBottom)
			{
				status = true;
			}
			return status;
		}
		public fraction (int paraTop, int paraBottom)
		{
			Bottom = paraBottom;
			Top = paraTop;			
		}
		public static fraction Plus(fraction a, fraction b)
		{
			fraction c = new fraction();
			c.iTop = a.iTop*b.iBottom + a.iBottom*b.iTop;
			c.iBottom = a.iBottom * b.iBottom;
			c.PSEnd();
			return c;
		}
		public static fraction Subtract(fraction a, fraction b)
		{
			fraction c = new fraction();
			c.iTop = a.iTop*b.iBottom - a.iBottom*b.iTop;
			c.iBottom = a.iBottom * b.iBottom;
			c.PSEnd();
			return c;
		}
		public static fraction Multilpe(fraction a, fraction b)
		{
			fraction c = new fraction();
			c.iTop = a.iTop * b.iTop;
			c.iBottom = a.iBottom * b.iBottom;
			c.PSEnd();
			return c;
		}
		public static fraction Div(fraction a, fraction b)
		{
			fraction c = new fraction();
			c.iTop = a.iTop * b.iBottom;
			c.iBottom = a.iBottom * b.iTop;
			c.PSEnd();
			return c;
		}
		public void PSEnd()
		{
			int a = ucln(iTop, iBottom);
			if (a != 0)
			{
				if (a > 0)
				{
					iTop = iTop / a;
					iBottom = iBottom /a;
					if (iTop == 0)
					{
						iBottom = 0;
					}
				}
				if (a < 0)
				{
					iTop = iTop / (-a);
					iBottom = iBottom / (-a);
				}
			}
			
		}
	}
}
