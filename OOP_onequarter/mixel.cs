/*
 * Created by SharpDevelop.
 * User: dell
 * Date: 12/13/2018
 * Time: 9:04 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace OOP_onequarter
{
	/// <summary>
	/// Description of mixel.
	/// </summary>
	public class mixel : fraction
	{
		private int iInterger;
		public int Interger
		{
			get{return iInterger;}
			set{iInterger = value;}
		}
		public mixel()
		{
			Top = 0;
			Bottom = 1;
			iInterger = 0;
		}
		private void Tofraction()
		{
			Top = Top + iInterger * Bottom;
			iInterger = 0;
		}
		private void Tomixel()
		{
			iInterger = iInterger + (Top / Bottom);
			Top = Top % Bottom;
		}
		public static mixel operator+ (mixel a, mixel b)
		{
			mixel c = new mixel();
			a.Tofraction();
			b.Tofraction();
			c.Top = a.Top*b.Bottom + a.Interger*b.Top;
			c.Bottom = a.Bottom * b.Bottom;
			c.PSEnd();
			c.Tomixel();
			return c;
		}
		public static mixel operator- (mixel a, mixel b)
		{
			mixel c = new mixel();
			a.Tofraction();
			b.Tofraction();
			c.Top = a.Top*b.Bottom - a.iInterger*b.Top;
			c.Bottom = a.Bottom * b.Bottom;
			c.PSEnd();
			c.Tomixel();
			return c;
		}
		public static mixel operator* (mixel a, mixel b)
		{
			mixel c = new mixel();
			a.Tofraction();
			b.Tofraction();
			c.Top = a.Top*b.Top;
			c.Bottom = a.Bottom * b.Bottom;
			c.PSEnd();
			c.Tomixel();
			return c;
		}
		public static mixel operator/ (mixel a, mixel b)
		{
			mixel c = new mixel();
			a.Tofraction();
			b.Tofraction();
			c.Top = a.Top*b.Bottom;
			c.Bottom = a.Bottom * b.Top;
			c.PSEnd();
			c.Tomixel();
			return c;
		}
	}
}
