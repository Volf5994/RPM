using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_2_2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			//Метод для рисования эллипса
			DrawEllipse();
			//Метод для рисования прямоугольника
			DrawRectangle();
			//Метод для рисования текстовой строки
			DrawString();
		}
		//Рисуем эллипс
		private void DrawEllipse()
		{
			//Рисуем контур зеленого цвета, толщина 4 пикселя
			Pen myPen = new Pen(Color.Green, 4);
			Graphics formGraphics;
			formGraphics = this.CreateGraphics();
			//Задаем координаты эллипса и его размеры
			formGraphics.DrawEllipse(myPen, new Rectangle(50, 50, 200, 300));
			//Выполняем заливку эллипса желтым цветом
			formGraphics.FillEllipse(Brushes.Yellow, 50, 50, 200, 300);
			myPen.Dispose();
			formGraphics.Dispose();
		}
		//Рисуем прямоугольник
		private void DrawRectangle()
		{
			//Рисуем контур цвета Tomato, толщина 3 пикселя
			Pen myPen = new Pen(Color.Tomato, 3);
			Graphics formGraphics;
			formGraphics = this.CreateGraphics();
			//Задаем координаты прямоугольника и его размеры (ширина, длина) 
			formGraphics.DrawRectangle(myPen, new Rectangle(70, 70, 200, 300));
			myPen.Dispose();
			formGraphics.Dispose();
		}

		//Прорисовываем текст "РИСУНОК" на форме
		public void DrawString()
		{
			Graphics formGraphics = this.CreateGraphics();
			string drawString = "РИСУНОК";
			Font drawFont = new Font("Arial", 18);
			SolidBrush drawBrush = new
			System.Drawing.SolidBrush(Color.Blue);
			float x = 150.0F;
			float y = 20.0F;
			StringFormat drawFormat = new StringFormat();
			formGraphics.DrawString(drawString, drawFont, drawBrush, x, y,
			drawFormat);
			drawFont.Dispose();
			drawBrush.Dispose();
			formGraphics.Dispose();
		}
	}
}