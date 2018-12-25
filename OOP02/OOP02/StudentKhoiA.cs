/*
 * Created by SharpDevelop.
 * User: dell
 * Date: 12/3/2018
 * Time: 3:15 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace OOP02
{
	/// <summary>
	/// Description of StudentKhoiA.
	/// </summary>
	public class StudentKhoiA: QLTS
	{
		public double Toan;
		public double Ly;
		public double Hoa;
		public double TongDiem;

		public StudentKhoiA()
		{
			
		}
		public override void Nhap()
		{
			VIDOUtils ulti = new VIDOUtils();
			base.ToString();
			Console.WriteLine("Khoi A");
			Toan = ulti.ReadNumber("Nhap diem toan: ",0, 10);
			Ly = ulti.ReadNumber("Nhap diem ly: ",0, 10);
			Hoa = ulti.ReadNumber("Nha diem hoa: ", 0, 10);
			
			TongDiem = Toan + Ly + Hoa;
		}
		public override string ToString()
		{
			return base.ToString()+string.Format("[StudentKhoiA Toan={0}, Ly={1}, Hoa={2}, TongDiem={3}]", Toan, Ly, Hoa, TongDiem);
		}
 
	}
}
