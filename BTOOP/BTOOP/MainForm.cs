/*
 * Created by SharpDevelop.
 * User: dell
 * Date: 1/3/2019
 * Time: 8:15 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace BTOOP
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		clsNguoi nguoi = new clsNguoi();
		clsKhachSan pt = new clsKhachSan();
		List<clsKhachSan> dspt = new List<clsKhachSan>();
		BindingList<clsKhachSan> bindingLists;
		BindingSource source;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			bindingLists = new BindingList<clsKhachSan>(dspt);
			source = new BindingSource(bindingLists, null);
			dataGrid1.DataSource = source;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public void ClearData()
		{
			tbHoTen.Text = "";
			tbYear.Text = "";
			tbAge.Text = "";
			tbCMND.Text = "";
			tbDay.Text = "";
			tbLP.Text = "";
			tbGia.Text = "";
		}
		void Label5Click(object sender, EventArgs e)
		{
			
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void Label6Click(object sender, EventArgs e)
		{
			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		void Label10Click(object sender, EventArgs e)
		{
			
		}
		
		void BtClearClick(object sender, EventArgs e)
		{
			ClearData();
		}
		
		void BtAddClick(object sender, EventArgs e)
		{
			nguoi.hvt = tbHoTen.Text;
			nguoi.ns = DateTime.Parse(tbYear.Text.ToString());
			nguoi.tuoi = double.Parse(tbAge.Text.ToString());
			nguoi.scm = tbCMND.Text;
			pt.snt = int.Parse(tbDay.Text.ToString());
			pt.lp = tbLP.Text;
			pt.gp = double.Parse(tbGia.Text.ToString());
			source.Add(nguoi);
			source.Add(pt);
			ClearData();
			nguoi = new clsNguoi();
			pt = new clsKhachSan();
			dataGrid1.Refresh();
		}
		
		void TbYearTextChanged(object sender, EventArgs e)
		{
			try{
				nguoi.ns = DateTime.Parse(tbYear.Text.ToString());
			}catch{
				
			}
		}
		
		void TbGiaTextChanged(object sender, EventArgs e)
		{
			try{
				pt.gp = double.Parse(tbGia.Text.ToString());
			}catch{
				
			}
		}
		
		void TbDayTextChanged(object sender, EventArgs e)
		{
			try{
				pt.snt = int.Parse(tbDay.Text.ToString());
			}catch{
				
			}
		}
		
		void TbAgeTextChanged(object sender, EventArgs e)
		{
			try{
				nguoi.tuoi = double.Parse(tbAge.Text.ToString());
			}catch{
				
			}
		}
	}
}
