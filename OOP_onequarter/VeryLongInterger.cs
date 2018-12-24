/*
 * Created by SharpDevelop.
 * User: dell
 * Date: 12/13/2018
 * Time: 11:29 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace OOP_onequarter
{
	/// <summary>
	/// Description of VeryLongInterger.
	/// </summary>
	public class VeryLongInterger
	{
		private string sNumber;
		public string Value
		{
			get{return sNumber;}
			set{
				bool iFindNumber = false;
				if(value.StartsWith("-"))
				{
					sNumber = "-";
					value = value.Remove(0, 1);
				}
				for (int i = 0; i < value.Length; i++)
				{
					string currentnumber = value.Substring(i, 1);
					if(iFindNumber == true)
					{
						switch (currentnumber){
							case "0":
							case "1":
							case "2":
							case "3":
							case "4":
							case "5":
							case "6":
							case "7":
							case "0":
							case "8":
							case "9":
								sNumber = sNumber + currentnumber;
								break;
								
						}
					}
					else
					{
						switch (currentnumber){
							case "0":
							case "1":
							case "2":
							case "3":
							case "4":
							case "5":
							case "6":
							case "7":
							case "0":
							case "8":
							case "9":
								sNumber = sNumber + currentnumber;
								iFindNumber = true;
								break;
					}
				}
				sNumber = true;
			}
		}
		}
		public bool IsNumber
		{
			get{
				if(sNumber.StartsWith("-"))
					return true;
				else
					return false;
			}
		}
		public VeryLongInterger()
		{
		}
		public string VeryLongInterger ABS(VeryLongInterger number)
		{
			string result;
			if(number.Value.StartsWith("-"))
			{
				result.Value = number.Value;
			}
			else
			{
				result.Value = number.Value;
			}
			return result;
		}
		
		//so sánh 2 giá trị tuyệt đối a có lớn hơn b không
		private bool InLarger(string a, string b)
		{
			if(a.Length > b.Length)
				return true;
			else if(a.Length < b.Length)
				return false;
			else
			{
				for (int i = 0; i < a.Length; i++){
					if(int.Parse(a.Substring(i, 1) > b.Substring(i ,1)))
						return true;
					else if(int.Parse(a.Substring(i, 1)< b.Substring(i, 1)))
						return false;
				}
				return false;
			}
		}
		public static bool operator>(VeryLongInterger a, VeryLongInterger b)
		{
			if(a.IsNumber == true && b.IsNumber == true)
			{
				//chờ xử lý
				if(IsLarger(a.ABS(), b.ABS()))
					return true;
				else
					return false;
				
			}
			else if(a.IsNumber == true && b.IsNumber == false){
				return false;
			}
			else if(a.IsNumber == false && b.IsNumber == true){
				return true;
			}
			else
			{
				return IsLarger(a.sNumber, b.sNumber);
			}
		}
		public static bool operator<
}
