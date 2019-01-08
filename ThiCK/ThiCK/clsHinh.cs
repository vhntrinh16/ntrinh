/*
 * Created by SharpDevelop.
 * User: dell
 * Date: 1/8/2019
 * Time: 9:16 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.IO;
using System.ComponentModel;
using System.Web.Script.Serialization;

namespace ThiCK
{
	/// <summary>
	/// Description of clsHinh.
	/// </summary>
	public class clsHinh
	{
		public List<clsDiem> save = new List<clsDiem>();
		public clsHinh()
		{
		}
		public void LoadData(Dictionary<string, List<clsDiem>> input, string input_Name)
		{
			foreach(var item in input)
			{
				if (item.Key == input_Name)
				{
					save = item.Value;
				}
			}
		}
		public List<clsDiem> SaveData()
		{
			List<clsDiem> temp = new List<clsDiem>();
			temp = save;
			return temp;
		}
	}
}
