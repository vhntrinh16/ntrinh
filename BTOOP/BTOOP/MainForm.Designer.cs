/*
 * Created by SharpDevelop.
 * User: dell
 * Date: 1/3/2019
 * Time: 8:15 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BTOOP
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tbHoTen = new System.Windows.Forms.TextBox();
			this.tbYear = new System.Windows.Forms.TextBox();
			this.tbAge = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tbCMND = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.tbDay = new System.Windows.Forms.TextBox();
			this.tbLP = new System.Windows.Forms.TextBox();
			this.tbGia = new System.Windows.Forms.TextBox();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.btClear = new System.Windows.Forms.Button();
			this.btAdd = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.Location = new System.Drawing.Point(212, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(227, 38);
			this.label1.TabIndex = 0;
			this.label1.Text = "Quản Lý Khách Sạn";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.Location = new System.Drawing.Point(27, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 28);
			this.label2.TabIndex = 1;
			this.label2.Text = "Người: ";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.Location = new System.Drawing.Point(49, 81);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 28);
			this.label3.TabIndex = 2;
			this.label3.Text = "Họ tên:";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label4.Location = new System.Drawing.Point(49, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 35);
			this.label4.TabIndex = 3;
			this.label4.Text = "Năm sinh:";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label5.Location = new System.Drawing.Point(49, 159);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 37);
			this.label5.TabIndex = 4;
			this.label5.Text = "Tuổi:";
			this.label5.Click += new System.EventHandler(this.Label5Click);
			// 
			// tbHoTen
			// 
			this.tbHoTen.Location = new System.Drawing.Point(126, 85);
			this.tbHoTen.Name = "tbHoTen";
			this.tbHoTen.Size = new System.Drawing.Size(128, 21);
			this.tbHoTen.TabIndex = 5;
			this.tbHoTen.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// tbYear
			// 
			this.tbYear.Location = new System.Drawing.Point(126, 120);
			this.tbYear.Name = "tbYear";
			this.tbYear.Size = new System.Drawing.Size(128, 21);
			this.tbYear.TabIndex = 6;
			this.tbYear.TextChanged += new System.EventHandler(this.TbYearTextChanged);
			// 
			// tbAge
			// 
			this.tbAge.Location = new System.Drawing.Point(126, 159);
			this.tbAge.Name = "tbAge";
			this.tbAge.Size = new System.Drawing.Size(128, 21);
			this.tbAge.TabIndex = 7;
			this.tbAge.TextChanged += new System.EventHandler(this.TbAgeTextChanged);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(49, 196);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 27);
			this.label6.TabIndex = 8;
			this.label6.Text = "CMND:";
			this.label6.Click += new System.EventHandler(this.Label6Click);
			// 
			// tbCMND
			// 
			this.tbCMND.Location = new System.Drawing.Point(126, 198);
			this.tbCMND.Name = "tbCMND";
			this.tbCMND.Size = new System.Drawing.Size(128, 21);
			this.tbCMND.TabIndex = 9;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label7.Location = new System.Drawing.Point(345, 52);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 10;
			this.label7.Text = "Khách Sạn:";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(375, 81);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(64, 23);
			this.label8.TabIndex = 11;
			this.label8.Text = "Số ngày:";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(375, 118);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(81, 23);
			this.label9.TabIndex = 12;
			this.label9.Text = "Loại phòng:";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(375, 159);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(70, 23);
			this.label10.TabIndex = 13;
			this.label10.Text = "Giá phòng:";
			this.label10.Click += new System.EventHandler(this.Label10Click);
			// 
			// tbDay
			// 
			this.tbDay.Location = new System.Drawing.Point(462, 85);
			this.tbDay.Name = "tbDay";
			this.tbDay.Size = new System.Drawing.Size(100, 21);
			this.tbDay.TabIndex = 14;
			this.tbDay.TextChanged += new System.EventHandler(this.TbDayTextChanged);
			// 
			// tbLP
			// 
			this.tbLP.Location = new System.Drawing.Point(462, 120);
			this.tbLP.Name = "tbLP";
			this.tbLP.Size = new System.Drawing.Size(100, 21);
			this.tbLP.TabIndex = 15;
			// 
			// tbGia
			// 
			this.tbGia.Location = new System.Drawing.Point(462, 159);
			this.tbGia.Name = "tbGia";
			this.tbGia.Size = new System.Drawing.Size(100, 21);
			this.tbGia.TabIndex = 16;
			this.tbGia.TextChanged += new System.EventHandler(this.TbGiaTextChanged);
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(72, 244);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.Size = new System.Drawing.Size(465, 182);
			this.dataGrid1.TabIndex = 17;
			// 
			// btClear
			// 
			this.btClear.Location = new System.Drawing.Point(364, 198);
			this.btClear.Name = "btClear";
			this.btClear.Size = new System.Drawing.Size(75, 23);
			this.btClear.TabIndex = 18;
			this.btClear.Text = "Clear";
			this.btClear.UseVisualStyleBackColor = true;
			this.btClear.Click += new System.EventHandler(this.BtClearClick);
			// 
			// btAdd
			// 
			this.btAdd.Location = new System.Drawing.Point(446, 198);
			this.btAdd.Name = "btAdd";
			this.btAdd.Size = new System.Drawing.Size(75, 23);
			this.btAdd.TabIndex = 19;
			this.btAdd.Text = "Add";
			this.btAdd.UseVisualStyleBackColor = true;
			this.btAdd.Click += new System.EventHandler(this.BtAddClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.ClientSize = new System.Drawing.Size(611, 438);
			this.Controls.Add(this.btAdd);
			this.Controls.Add(this.btClear);
			this.Controls.Add(this.dataGrid1);
			this.Controls.Add(this.tbGia);
			this.Controls.Add(this.tbLP);
			this.Controls.Add(this.tbDay);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.tbCMND);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tbAge);
			this.Controls.Add(this.tbYear);
			this.Controls.Add(this.tbHoTen);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.Name = "MainForm";
			this.Text = "BTOOP";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btAdd;
		private System.Windows.Forms.Button btClear;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.TextBox tbGia;
		private System.Windows.Forms.TextBox tbLP;
		private System.Windows.Forms.TextBox tbDay;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tbCMND;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbAge;
		private System.Windows.Forms.TextBox tbYear;
		private System.Windows.Forms.TextBox tbHoTen;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
