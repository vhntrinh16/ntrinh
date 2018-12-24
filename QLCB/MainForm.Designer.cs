/*
 * Created by SharpDevelop.
 * User: dell
 * Date: 12/20/2018
 * Time: 8:53 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace QLCB
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
			this.tbHoten = new System.Windows.Forms.TextBox();
			this.tbYear = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cbNam = new System.Windows.Forms.CheckBox();
			this.cbNu = new System.Windows.Forms.CheckBox();
			this.dgCanBo = new System.Windows.Forms.DataGrid();
			this.label5 = new System.Windows.Forms.Label();
			this.tbAddress = new System.Windows.Forms.TextBox();
			this.btAdd = new System.Windows.Forms.Button();
			this.btSave = new System.Windows.Forms.Button();
			this.btLoad = new System.Windows.Forms.Button();
			this.rdbWorker = new System.Windows.Forms.RadioButton();
			this.rdbEmploy = new System.Windows.Forms.RadioButton();
			this.rdbEngineer = new System.Windows.Forms.RadioButton();
			this.label6 = new System.Windows.Forms.Label();
			this.tbWork = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.tbMajors = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.tbLevel = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgCanBo)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.Location = new System.Drawing.Point(174, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(310, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "Quản Lý Sản Xuất";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tbHoten
			// 
			this.tbHoten.Location = new System.Drawing.Point(149, 68);
			this.tbHoten.Name = "tbHoten";
			this.tbHoten.Size = new System.Drawing.Size(126, 20);
			this.tbHoten.TabIndex = 1;
			// 
			// tbYear
			// 
			this.tbYear.Location = new System.Drawing.Point(149, 103);
			this.tbYear.Name = "tbYear";
			this.tbYear.Size = new System.Drawing.Size(126, 20);
			this.tbYear.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.Location = new System.Drawing.Point(53, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Họ tên:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.Location = new System.Drawing.Point(53, 103);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Năm sinh:";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label4.Location = new System.Drawing.Point(53, 140);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 24);
			this.label4.TabIndex = 6;
			this.label4.Text = "Giới tính:";
			// 
			// cbNam
			// 
			this.cbNam.Location = new System.Drawing.Point(150, 140);
			this.cbNam.Name = "cbNam";
			this.cbNam.Size = new System.Drawing.Size(104, 24);
			this.cbNam.TabIndex = 7;
			this.cbNam.Text = "Nam";
			this.cbNam.UseVisualStyleBackColor = true;
			// 
			// cbNu
			// 
			this.cbNu.Location = new System.Drawing.Point(150, 161);
			this.cbNu.Name = "cbNu";
			this.cbNu.Size = new System.Drawing.Size(104, 24);
			this.cbNu.TabIndex = 8;
			this.cbNu.Text = "Nữ";
			this.cbNu.UseVisualStyleBackColor = true;
			// 
			// dgCanBo
			// 
			this.dgCanBo.DataMember = "";
			this.dgCanBo.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgCanBo.Location = new System.Drawing.Point(306, 56);
			this.dgCanBo.Name = "dgCanBo";
			this.dgCanBo.Size = new System.Drawing.Size(328, 204);
			this.dgCanBo.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label5.Location = new System.Drawing.Point(53, 195);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(78, 17);
			this.label5.TabIndex = 10;
			this.label5.Text = "Địa chỉ:";
			// 
			// tbAddress
			// 
			this.tbAddress.Location = new System.Drawing.Point(150, 195);
			this.tbAddress.Name = "tbAddress";
			this.tbAddress.Size = new System.Drawing.Size(125, 20);
			this.tbAddress.TabIndex = 11;
			// 
			// btAdd
			// 
			this.btAdd.Location = new System.Drawing.Point(53, 236);
			this.btAdd.Name = "btAdd";
			this.btAdd.Size = new System.Drawing.Size(61, 24);
			this.btAdd.TabIndex = 12;
			this.btAdd.Text = "Add";
			this.btAdd.UseVisualStyleBackColor = true;
			this.btAdd.Click += new System.EventHandler(this.BtAddClick);
			// 
			// btSave
			// 
			this.btSave.Location = new System.Drawing.Point(120, 236);
			this.btSave.Name = "btSave";
			this.btSave.Size = new System.Drawing.Size(56, 24);
			this.btSave.TabIndex = 13;
			this.btSave.Text = "Save";
			this.btSave.UseVisualStyleBackColor = true;
			// 
			// btLoad
			// 
			this.btLoad.Location = new System.Drawing.Point(183, 236);
			this.btLoad.Name = "btLoad";
			this.btLoad.Size = new System.Drawing.Size(57, 24);
			this.btLoad.TabIndex = 14;
			this.btLoad.Text = "Load";
			this.btLoad.UseVisualStyleBackColor = true;
			// 
			// rdbWorker
			// 
			this.rdbWorker.Location = new System.Drawing.Point(53, 283);
			this.rdbWorker.Name = "rdbWorker";
			this.rdbWorker.Size = new System.Drawing.Size(61, 22);
			this.rdbWorker.TabIndex = 15;
			this.rdbWorker.TabStop = true;
			this.rdbWorker.Text = "Worker";
			this.rdbWorker.UseVisualStyleBackColor = true;
			// 
			// rdbEmploy
			// 
			this.rdbEmploy.Location = new System.Drawing.Point(132, 283);
			this.rdbEmploy.Name = "rdbEmploy";
			this.rdbEmploy.Size = new System.Drawing.Size(63, 22);
			this.rdbEmploy.TabIndex = 16;
			this.rdbEmploy.TabStop = true;
			this.rdbEmploy.Text = "Employ";
			this.rdbEmploy.UseVisualStyleBackColor = true;
			// 
			// rdbEngineer
			// 
			this.rdbEngineer.Location = new System.Drawing.Point(213, 283);
			this.rdbEngineer.Name = "rdbEngineer";
			this.rdbEngineer.Size = new System.Drawing.Size(73, 22);
			this.rdbEngineer.TabIndex = 17;
			this.rdbEngineer.TabStop = true;
			this.rdbEngineer.Text = "Engineer";
			this.rdbEngineer.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label6.Location = new System.Drawing.Point(52, 312);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 22);
			this.label6.TabIndex = 18;
			this.label6.Text = "Work:";
			// 
			// tbWork
			// 
			this.tbWork.Location = new System.Drawing.Point(110, 312);
			this.tbWork.Name = "tbWork";
			this.tbWork.Size = new System.Drawing.Size(100, 20);
			this.tbWork.TabIndex = 19;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label7.Location = new System.Drawing.Point(231, 312);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(55, 19);
			this.label7.TabIndex = 20;
			this.label7.Text = "Majors:";
			// 
			// tbMajors
			// 
			this.tbMajors.Location = new System.Drawing.Point(292, 312);
			this.tbMajors.Name = "tbMajors";
			this.tbMajors.Size = new System.Drawing.Size(100, 20);
			this.tbMajors.TabIndex = 21;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label8.Location = new System.Drawing.Point(423, 313);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(46, 21);
			this.label8.TabIndex = 22;
			this.label8.Text = "Level:";
			// 
			// tbLevel
			// 
			this.tbLevel.Location = new System.Drawing.Point(475, 311);
			this.tbLevel.Name = "tbLevel";
			this.tbLevel.Size = new System.Drawing.Size(100, 20);
			this.tbLevel.TabIndex = 23;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.ClientSize = new System.Drawing.Size(666, 380);
			this.Controls.Add(this.tbLevel);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.tbMajors);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.tbWork);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.rdbEngineer);
			this.Controls.Add(this.rdbEmploy);
			this.Controls.Add(this.rdbWorker);
			this.Controls.Add(this.btLoad);
			this.Controls.Add(this.btSave);
			this.Controls.Add(this.btAdd);
			this.Controls.Add(this.tbAddress);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dgCanBo);
			this.Controls.Add(this.cbNu);
			this.Controls.Add(this.cbNam);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbYear);
			this.Controls.Add(this.tbHoten);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "QLCB";
			((System.ComponentModel.ISupportInitialize)(this.dgCanBo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox tbLevel;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox tbMajors;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tbWork;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RadioButton rdbEngineer;
		private System.Windows.Forms.RadioButton rdbEmploy;
		private System.Windows.Forms.RadioButton rdbWorker;
		private System.Windows.Forms.Button btLoad;
		private System.Windows.Forms.Button btSave;
		private System.Windows.Forms.Button btAdd;
		private System.Windows.Forms.TextBox tbAddress;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGrid dgCanBo;
		private System.Windows.Forms.CheckBox cbNu;
		private System.Windows.Forms.CheckBox cbNam;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbYear;
		private System.Windows.Forms.TextBox tbHoten;
		private System.Windows.Forms.Label label1;
	}
}
