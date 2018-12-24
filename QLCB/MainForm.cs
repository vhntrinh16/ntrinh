/*
 * Created by SharpDevelop.
 * User: dell
 * Date: 12/20/2018
 * Time: 8:53 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QLCB
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		CanBo canbo = new CanBo();
		CongNhan congnhan = new CongNhan();
		NhanVien nhanvien = new NhanVien();
		KySu kysu = new KySu();
		List<CanBo> dsCanBo = new List<CanBo>();
		BindingList<CanBo> bindingList;
		BindingSource source;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			bindingList = new BindingList<CanBo>(dsCanBo);
 			source = new BindingSource(bindingList, null);
 			dgCanBo.DataSource = source;
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public void ClearData()
		{
			tbHoten.Text = "";
			tbYear.Text = "";
			tbAddress.Text = "";
			tbWork.Text = "";
			tbMajors.Text = "";
			tbLevel.Text = "";
		}
		
		
		void BtAddClick(object sender, EventArgs e)
		{
			canbo.hvt = tbHoten.Text;
			canbo.ns = int.Parse(tbYear.Text.ToString());
			canbo.dc = tbAddress.Text;
			source.Add(canbo);
			ClearData();
			dgCanBo.Refresh();
		}
	}
}
