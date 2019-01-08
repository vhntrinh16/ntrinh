/*
 * Created by SharpDevelop.
 * User: dell
 * Date: 1/8/2019
 * Time: 8:30 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ThiCK
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tbtLine = new System.Windows.Forms.ToolStripButton();
			this.tbtTriangle = new System.Windows.Forms.ToolStripButton();
			this.tbtPoint = new System.Windows.Forms.ToolStripButton();
			this.tbtSave = new System.Windows.Forms.ToolStripButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tbtLoad = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.tbtLine,
									this.tbtTriangle,
									this.tbtPoint,
									this.tbtSave,
									this.tbtLoad});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(470, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tbtLine
			// 
			this.tbtLine.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.tbtLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tbtLine.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbtLine.Name = "tbtLine";
			this.tbtLine.Size = new System.Drawing.Size(33, 22);
			this.tbtLine.Text = "Line";
			this.tbtLine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tbtLine.Click += new System.EventHandler(this.ToolStripButton1Click);
			// 
			// tbtTriangle
			// 
			this.tbtTriangle.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.tbtTriangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tbtTriangle.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbtTriangle.Name = "tbtTriangle";
			this.tbtTriangle.Size = new System.Drawing.Size(53, 22);
			this.tbtTriangle.Text = "Triangle";
			this.tbtTriangle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tbtTriangle.Click += new System.EventHandler(this.TbtTriangleClick);
			// 
			// tbtPoint
			// 
			this.tbtPoint.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.tbtPoint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tbtPoint.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbtPoint.Name = "tbtPoint";
			this.tbtPoint.Size = new System.Drawing.Size(39, 22);
			this.tbtPoint.Text = "Point";
			this.tbtPoint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tbtPoint.Click += new System.EventHandler(this.TbtPointClick);
			// 
			// tbtSave
			// 
			this.tbtSave.BackColor = System.Drawing.Color.SlateGray;
			this.tbtSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tbtSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbtSave.Name = "tbtSave";
			this.tbtSave.Size = new System.Drawing.Size(35, 22);
			this.tbtSave.Text = "Save";
			this.tbtSave.Click += new System.EventHandler(this.TbtSaveClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(12, 43);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(446, 277);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1MouseDown);
			this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1MouseMove);
			this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1MouseUp);
			// 
			// tbtLoad
			// 
			this.tbtLoad.BackColor = System.Drawing.Color.SlateGray;
			this.tbtLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tbtLoad.Image = ((System.Drawing.Image)(resources.GetObject("tbtLoad.Image")));
			this.tbtLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbtLoad.Name = "tbtLoad";
			this.tbtLoad.Size = new System.Drawing.Size(37, 22);
			this.tbtLoad.Text = "Load";
			this.tbtLoad.Click += new System.EventHandler(this.TbtLoadClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(470, 332);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.toolStrip1);
			this.Name = "MainForm";
			this.Text = "ThiCK";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripButton tbtLoad;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolStripButton tbtSave;
		private System.Windows.Forms.ToolStripButton tbtPoint;
		private System.Windows.Forms.ToolStripButton tbtTriangle;
		private System.Windows.Forms.ToolStripButton tbtLine;
		private System.Windows.Forms.ToolStrip toolStrip1;
	}
}
