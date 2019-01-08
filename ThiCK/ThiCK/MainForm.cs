/*
 * Created by SharpDevelop.
 * User: dell
 * Date: 1/8/2019
 * Time: 8:30 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Web.Script.Serialization;

namespace ThiCK
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Dictionary<string, List<clsDiem>> data = new Dictionary<string, List<clsDiem>>(); // đối tượng lưu trữ
		Graphics g;
		Pen pen = new Pen(Color.Black, 1); //cây bút để vẽ
		bool canDraw = false; //kiểm tra điều kiện
		clsDiem begin = new clsDiem();
		clsDiem end = new clsDiem();
		clsLine line = new clsLine(); //đường thẳng
		clsTriangle triangle = new clsTriangle(); //tam giác
		Rectangle rect = new Rectangle(); //vùng tiếp diện hcn
		bool pointer, isLine, isTriangle; //menu chọn
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			g = pictureBox1.CreateGraphics();
			pointer = true;
			isLine = false;
			isTriangle = false;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Update()
		{
			for(int i = 0; i < line.save.Count - 1; i += 2)
			{
				line.Draw(g, pen);
			}
			for(int i = 0; i < triangle.save.Count - 1; i += 2)
			{
				triangle.Draw(g, pen);
			}
		}
		
		void PictureBox1MouseUp(object sender, MouseEventArgs e)
		{
			if (pointer == false)
			{
				end.x = e.X;
				end.y = e.Y;
				canDraw = false;
				if (isLine)
				{
					line.begin = begin;
					line.end = end;
					line.AddPoint();
				}
				else if (isTriangle)
				{
					triangle.begin = begin;
					triangle.end = end;
					triangle.AddPoint();
				}
			}
		}
		
		void PictureBox1MouseDown(object sender, MouseEventArgs e)
		{
			if (pointer == false)
			{
				canDraw = true;
				begin = new clsDiem(e.X, e.Y);
				rect.X = begin.x;
				rect.Y = begin.y;
			}
		}
		
		void PictureBox1MouseMove(object sender, MouseEventArgs e)
		{
			if (canDraw == true)
			{
				end = new clsDiem(e.X, e.Y);
				g.Clear(pictureBox1.BackColor);;
				if (pointer)
				{
					return;
				}
				else if (isLine == true)
				{
					g.DrawLine(pen, begin.x, begin.y, e.X, e.Y);
				}
				else if (isLine == true)
				{
					rect.Size = new Size(end.x - begin.x, end.y - begin.y);
					g.DrawRectangle(pen, rect);
				}
				Update();
			}
		}
		
		void ToolStripButton1Click(object sender, EventArgs e)
		{
			pointer = false;
			isLine = true;
			isTriangle = false;
		}
		
		void TbtPointClick(object sender, EventArgs e)
		{
			pointer = true;
			isLine = false;
			isTriangle = false;
		}
		
		void TbtTriangleClick(object sender, EventArgs e)
		{
			pointer = true;
			isLine = false;
			isTriangle = true;
		}
		
		void TbtSaveClick(object sender, EventArgs e)
		{
			pointer = true;
			isTriangle = false;
			isLine = false;
			SaveFileDialog save = new SaveFileDialog();
			save.Filter = "json| *.json";
			save.ShowDialog();
			data.Add("line", line.SaveData());
			data.Add("triangle", triangle.SaveData());
			StreamWriter writer = new StreamWriter(save.FileName);
			JavaScriptSerializer serializer = new JavaScriptSerializer();
			var json = serializer.Serialize(data);
			writer.Write(json);
			writer.Close();
		}
		
		void TbtLoadClick(object sender, EventArgs e)
		{
			pointer = true;
			isTriangle = false;
			isLine = false;
			OpenFileDialog open = new OpenFileDialog();
			open.Filter = "json| *.json";
			open.ShowDialog();
			StreamReader reader = new StreamReader(open.FileName);
			var json = reader.ReadToEnd();
			JavaScriptSerializer serializer = new JavaScriptSerializer();
			var deserializeObject = serializer.Deserialize<List<clsDiem>>(json);
			line.LoadData(data, "line");
			triangle.LoadData(data, "triangle");
			reader.Close();
			Update();
			
		}
	}
}
