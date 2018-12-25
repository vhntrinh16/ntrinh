/*
 * Created by SharpDevelop.
 * User: dell
 * Date: 11/29/2018
 * Time: 10:25 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace bai608
{
	/// <summary>
	/// Description of clsHopSua.
	/// </summary>
	public class clsHopSua
	{
		public string NhanHieu;
		public double TrongLuong;
		public DateTime HanSuDung;
		public clsHopSua()
		{
		}
		public void DatNhanHieu(string sNhanHieu)
		{
			NhanHieu = sNhanHieu;
		}
		public string LayNhanHieu()
		{
			return NhanHieu;
		}
		public void DatTrongLuong(double sTrongLuong)
		{
			TrongLuong = sTrongLuong;
		}
		public double XuatTL()
		{
			return TrongLuong;
		}
		public void DatNgay(DateTime sHanSuDung)
		{
			HanSuDung = sHanSuDung;
		}
		public DateTime XuatNgay()
		{
			return HanSuDung;
		}
		/*
		public void Nhap()
		{
			Console.WriteLine("Nhap trong luong: ");
			TrongLuong = double.Parse(Console.ReadLine());
			Console.WriteLine("Nhap han su dung: ");
			HanSuDung = DateTime.Parse(Console.ReadLine());
		}
		*/
	}
}
