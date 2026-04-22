using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_2_3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			
		}
		Point curPoint = new Point(200, 450);
		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			DrawImage(curPoint);
		}
		private void DrawImage(Point cp)
		{
			Bitmap myBitmap = new Bitmap("werty.png");
			Graphics g = this.CreateGraphics();
			g.DrawImage(myBitmap, cp);
		}
		private void Form1_MouseClick(object sender, MouseEventArgs e)
		{
			curPoint = e.Location;
			Invalidate();
		}

	}
}
