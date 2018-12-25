/*
 * Created by SharpDevelop.
 * User: dell
 * Date: 12/3/2018
 * Time: 3:16 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace OOP02
{
	/// <summary>
	/// Description of StudentKhoiD.
	/// </summary>
	public class StudentKhoiD: QLTS
	{
		public double Toan;
		public double Van;
		public double Anh;
		public double TongDiem;
		public StudentKhoiD()
		{
			
		}
		public override void Nhap()
		{
			VIDOUtils ulti = new VIDOUtils();
			base.ToString();
			Console.WriteLine("Khoi D");
			Toan = ulti.ReadNumber("Nhap diem toan: ",0, 10);	
			Van = ulti.ReadNumber("Nhap diem van: ",0, 10);
			Anh= ulti.ReadNumber("Nhap diem anh: ",0, 10);
			
			TongDiem = Toan + Van + Anh;
		}
		public override string ToString()
		{
			return base.ToString()+string.Format("[StudentKhoiD Toan={0}, Van={1}, Anh={2}, TongDiem={3}]", Toan, Van, Anh, TongDiem);
		}

	}
}
