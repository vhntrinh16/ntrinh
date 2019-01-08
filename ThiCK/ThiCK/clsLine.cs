/*
 * Created by SharpDevelop.
 * User: dell
 * Date: 1/8/2019
 * Time: 8:49 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Collections.Generic;

namespace ThiCK
{
	/// <summary>
	/// Description of clsLine.
	/// </summary>
	public class clsLine: clsHinh
	{
		public clsDiem begin = new clsDiem();
		public clsDiem end = new clsDiem();
		public clsLine()
		{
			begin = new clsDiem();
			end = new clsDiem();
		}
		public clsLine(clsDiem a, clsDiem b)
		{
			begin = a;
			end = b;
		}
		public void Draw(Graphics g, Pen p)
		{
			 foreach (var item in save)
            {
                for (int i = 0; i < save.Count - 1; i += 2)
                {
                    g.DrawLine(p, save[i].x, save[i].y, save[i + 1].x, save[i + 1].y);
                }
            }
		}
		 public void AddPoint()
        {
            try
            {
                save.Add(begin);
                save.Add(end);
            }
            catch (Exception)
            {
            }
        }
		
	}
}
