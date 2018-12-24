/*
 * Created by SharpDevelop.
 * User: user
 * Date: 12/6/2018
 * Time: 8:29 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_onequarter
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		fraction fra = new fraction();
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
		}
		public void ClearData()
		{
			this.txtBottom1.Text = "";
			this.txtBottom2.Text = "";
			this.txtBottom3.Text = "";
			this.txtTop1.Text = "";
			this.txtTop3.Text = "";
			this.txtTop2.Text = "";
		}
		
		
		void TxtTop1TextChanged(object sender, EventArgs e)
		{
			int ntop1;
			try
			{
				ntop1 = int.Parse(txtTop1.Text);
				
			}catch
			{
				txtTop1.Text = "";
			}
		}
		
		void TxtTop2TextChanged(object sender, EventArgs e)
		{
			int ntop2;
			try
			{
				ntop2 = int.Parse(txtTop2.Text);
				
			}catch
			{
				txtTop2.Text = "";
			}
		}
		
		void TxtBottom1TextChanged(object sender, EventArgs e)
		{
			int nbottom1;
			try
			{
				nbottom1 = int.Parse(txtBottom1.Text);
				if (nbottom1 == 0)
					
				{
					MessageBox.Show(" | Please check|", "Declare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtBottom1.Text ="";
				}
			}catch
			{
				txtBottom1.Text  = "";
			}
		}
		
		void TxtBottom2TextChanged(object sender, EventArgs e)
		{
			int nbottom2;
			try
			{
				nbottom2 = int.Parse(txtBottom2.Text);
				if (nbottom2 == 0)
					
				{
					MessageBox.Show(" | Please check|", "Declare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtBottom2.Text ="";
				}
			}catch
			{
				txtBottom2.Text  = "";
			}
		}
		
		void RdbPlusCheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void BtnEqualClick(object sender, EventArgs e)
		{
			mixel a = new mixel();
			mixel b = new mixel();
			mixel c = new mixel();
			a.Top = int.Parse(txtTop1.Text);
			a.Bottom = int.Parse(txtBottom1.Text);
			a.Interger = int.Parse(tbInterger1.Text);
			b.Top = int.Parse(txtTop2.Text);
			b.Bottom = int.Parse(txtBottom2.Text);
			b.Interger = int.Parse(tbInterger2.Text);
			
			if (rdbPlus.Checked == true)
			{
				c = a + b;
			}
			
			//=========================
			else if (rdbSub.Checked == true)
			{
				c = a - b;
			}
			
			//========================
			else if (rdbMult.Checked == true)
			{
				c = a * b;
			}
	
			else if (rdbDivi.Checked == true)
			{
				c = a / b;
			}
			txtTop3.Text = c.Top.ToString();
			txtBottom3.Text = c.Bottom.ToString();
			tbInterger3.Text = c.Interger.ToString();
		}
	}
}
