/*
 * Created by SharpDevelop.
 * User: dell
 * Date: 12/25/2018
 * Time: 8:29 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
namespace Bai18
{
	/// <summary>
	/// Description of TamGiac.
	/// </summary>
	public class TamGiac
	{
		Diem A = new Diem();
		Diem B = new Diem();
		Diem C = new Diem();
		public TamGiac()
		{
		}
		public TamGiac(Diem d1, Diem d2, Diem d3)
		{
			A = d1;
			B = d2;
			C = d3;
		}
		public double AB, BC, AC;
		public static double Chuvi(Diem A, Diem B, Diem C)
		{
			double cv = 0;
			double AB, BC, AC;
			AB = Diem.Khoangcach(A,B);
			BC = Diem.Khoangcach(B,C);
			AC = Diem.Khoangcach(A,C);
			cv = AB + BC + AC;
			return cv;
		}
		public static double Dientich(Diem A, Diem B, Diem C)
		{
			double dt;
			float p;
			double AB, BC, AC;
		
			AB = Diem.Khoangcach(A,B);
			BC = Diem.Khoangcach(B,C);
			AC = Diem.Khoangcach(A,C);
			p = (float)(AB + BC + AC)/2;
			dt = Math.Sqrt(p*(p - AB)*(p - BC)*(p - AC));
			return dt;
		}
		public void Draws (Graphics g, Pen p)
		{
			g.Clear(Color.White);
			Point [] a = new Point[4];
			a[0] = new Point(A.ihd,A.itd);
			a[1] = new Point(B.ihd,B.itd);
			a[2] = new Point(C.ihd,C.itd);
			a[3] = new Point(A.ihd,A.itd);
			g.DrawLines(p, a);
		}
	}
}
