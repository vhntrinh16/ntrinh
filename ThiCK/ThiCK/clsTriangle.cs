/*
 * Created by SharpDevelop.
 * User: dell
 * Date: 1/8/2019
 * Time: 9:12 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;

namespace ThiCK
{
	/// <summary>
	/// Description of clsTriangle.
	/// </summary>
	public class clsTriangle: clsHinh
	{
		public clsDiem begin = new clsDiem();
		public clsDiem end = new clsDiem();
		public clsTriangle()
		{
		}
		public clsTriangle(clsDiem A, clsDiem B)
		{
			begin = A;
			end = B;
		}
		public void Draw(Graphics g, Pen p)
		{
			Rectangle rect = new Rectangle();
			foreach (var item in save)
			{
				for (int i = 0; i < save.Count - 1; i += 2)
				{
					rect.X = save[i].x;
					rect.Y = save[i].y;
					rect.Size = new Size(save[i+1].x - save[i].x, save[i + 1].y - save[i].y);
					g.DrawLine(p, rect.X, rect.Y + rect.Height, save[i+1].x, save[i + 1].y);
					g.DrawLine(p, rect.X, rect.Y, save[i+1].x, save[i + 1].y);
					g.DrawLine(p, rect.X, rect.Y, save[i+1].x, rect.Width, save[i + 1].y);
				}
			}
		}
		public void Draw_TamGiac(Graphics g, Pen p)
		{
			Rectangle rect = new Rectangle();
			rect.Size = new Size(end.x - begin.x, end.y - begin.y);
			rect.X = begin.x;
			rect.Y = end.y;
			g.DrawLine(p, rect.X, rect.Y + rect.Height, end.x, end.y);
			g.DrawLine(p, rect.X, rect.Y, end.x, end.y);
			g.DrawLine(p, rect.X, rect.Y, end.x - rect.Width, end.y);
		}
		public void AddPoint()
		{
			try{
				save.Add(begin);
				save.Add(end);
			}catch(Exception){
				
			}
		}
	}
}
