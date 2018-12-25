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
	/// Description of StudentKhoiB.
	/// </summary>
	public class StudentKhoiB: QLTS
	{
		public double Van;
		public double Su;
		public double Dia;
		public double TongDiem;
		public StudentKhoiB()
		{
			
		}
		public override void Nhap()
		{
			VIDOUtils ulti = new VIDOUtils();
			base.ToString();
			Console.WriteLine("Khoi C");
			Van = ulti.ReadNumber("Nhap diem van: ",0, 10);
			Su = ulti.ReadNumber("Nhap diem su: ", 0, 10);
			Dia = ulti.ReadNumber("Nhap diem dia: ",0, 10);
		
			TongDiem = Van + Su + Dia;
		}
		public override string ToString()
		{
			return base.ToString()+string.Format("[StudentKhoiB Van={0}, Su={1}, Dia={2}, TongDiem={3}]", Van, Su, Dia, TongDiem);
		}
 
	}
}
