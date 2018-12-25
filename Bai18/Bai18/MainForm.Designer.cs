/*
 * Created by SharpDevelop.
 * User: dell
 * Date: 12/25/2018
 * Time: 8:27 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Bai18
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.tbhdA = new System.Windows.Forms.TextBox();
			this.tbtdA = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbhdB = new System.Windows.Forms.TextBox();
			this.tbtdB = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tbCV = new System.Windows.Forms.TextBox();
			this.tbDT = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbhdC = new System.Windows.Forms.TextBox();
			this.tbtdC = new System.Windows.Forms.TextBox();
			this.btCalc = new System.Windows.Forms.Button();
			this.btClose = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.Location = new System.Drawing.Point(25, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(26, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "A";
			// 
			// tbhdA
			// 
			this.tbhdA.Location = new System.Drawing.Point(57, 27);
			this.tbhdA.Name = "tbhdA";
			this.tbhdA.Size = new System.Drawing.Size(100, 20);
			this.tbhdA.TabIndex = 1;
			// 
			// tbtdA
			// 
			this.tbtdA.Location = new System.Drawing.Point(163, 27);
			this.tbtdA.Name = "tbtdA";
			this.tbtdA.Size = new System.Drawing.Size(100, 20);
			this.tbtdA.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.Location = new System.Drawing.Point(25, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "B";
			// 
			// tbhdB
			// 
			this.tbhdB.Location = new System.Drawing.Point(57, 75);
			this.tbhdB.Name = "tbhdB";
			this.tbhdB.Size = new System.Drawing.Size(100, 20);
			this.tbhdB.TabIndex = 4;
			// 
			// tbtdB
			// 
			this.tbtdB.Location = new System.Drawing.Point(163, 75);
			this.tbtdB.Name = "tbtdB";
			this.tbtdB.Size = new System.Drawing.Size(100, 20);
			this.tbtdB.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.Location = new System.Drawing.Point(336, 30);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Chu vi =";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label4.Location = new System.Drawing.Point(328, 75);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Diện tích =";
			// 
			// tbCV
			// 
			this.tbCV.Location = new System.Drawing.Point(408, 27);
			this.tbCV.Name = "tbCV";
			this.tbCV.Size = new System.Drawing.Size(74, 20);
			this.tbCV.TabIndex = 8;
			// 
			// tbDT
			// 
			this.tbDT.Location = new System.Drawing.Point(409, 72);
			this.tbDT.Name = "tbDT";
			this.tbDT.Size = new System.Drawing.Size(73, 20);
			this.tbDT.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label5.Location = new System.Drawing.Point(25, 129);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(26, 17);
			this.label5.TabIndex = 10;
			this.label5.Text = "C";
			// 
			// tbhdC
			// 
			this.tbhdC.Location = new System.Drawing.Point(57, 126);
			this.tbhdC.Name = "tbhdC";
			this.tbhdC.Size = new System.Drawing.Size(100, 20);
			this.tbhdC.TabIndex = 11;
			// 
			// tbtdC
			// 
			this.tbtdC.Location = new System.Drawing.Point(163, 126);
			this.tbtdC.Name = "tbtdC";
			this.tbtdC.Size = new System.Drawing.Size(100, 20);
			this.tbtdC.TabIndex = 12;
			// 
			// btCalc
			// 
			this.btCalc.Location = new System.Drawing.Point(336, 126);
			this.btCalc.Name = "btCalc";
			this.btCalc.Size = new System.Drawing.Size(52, 23);
			this.btCalc.TabIndex = 13;
			this.btCalc.Text = "Calc";
			this.btCalc.UseVisualStyleBackColor = true;
			this.btCalc.Click += new System.EventHandler(this.BtCalcClick);
			// 
			// btClose
			// 
			this.btClose.Location = new System.Drawing.Point(408, 126);
			this.btClose.Name = "btClose";
			this.btClose.Size = new System.Drawing.Size(52, 23);
			this.btClose.TabIndex = 14;
			this.btClose.Text = "Close";
			this.btClose.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(57, 166);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(403, 174);
			this.panel1.TabIndex = 15;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MediumAquamarine;
			this.ClientSize = new System.Drawing.Size(517, 363);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btClose);
			this.Controls.Add(this.btCalc);
			this.Controls.Add(this.tbtdC);
			this.Controls.Add(this.tbhdC);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tbDT);
			this.Controls.Add(this.tbCV);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbtdB);
			this.Controls.Add(this.tbhdB);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbtdA);
			this.Controls.Add(this.tbhdA);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Bai18";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btClose;
		private System.Windows.Forms.Button btCalc;
		private System.Windows.Forms.TextBox tbtdC;
		private System.Windows.Forms.TextBox tbhdC;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbDT;
		private System.Windows.Forms.TextBox tbCV;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbtdB;
		private System.Windows.Forms.TextBox tbhdB;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbtdA;
		private System.Windows.Forms.TextBox tbhdA;
		private System.Windows.Forms.Label label1;
	}
}
