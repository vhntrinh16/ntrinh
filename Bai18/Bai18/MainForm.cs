/*
 * Created by SharpDevelop.
 * User: dell
 * Date: 12/25/2018
 * Time: 8:27 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bai18
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Diem a = new Diem();
		Diem b = new Diem();
		Diem c = new Diem();
		TamGiac tamgiac = new TamGiac();
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtCalcClick(object sender, EventArgs e)
		{
			a = new Diem(int.Parse(tbhdA.Text),int.Parse(tbtdA.Text));
			b = new Diem(int.Parse(tbtdB.Text),int.Parse(tbtdB.Text));
			c = new Diem(int.Parse(tbhdC.Text),int.Parse(tbtdC.Text));
			tamgiac = new TamGiac(a,b,c);
			tbCV.Text = TamGiac.Chuvi(a,b,c).ToString();
			tbDT.Text = TamGiac.Dientich(a,b,c).ToString();
			tamgiac.Draws(panel1.CreateGraphics(), new Pen(Color.Black, 3));
		}
	}
}
