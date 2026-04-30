using System;
using System.Drawing;
using System.Windows.Forms;

namespace Form2_1_sr
{
	public partial class Form2_1_sr : Form
	{
		// Координаты центра круга (-1 означает, что круг еще не рисовали)
		private int circleX = -1;
		private int circleY = -1;
		private const int RADIUS = 80;

		public Form2_1_sr()
		{
			InitializeComponent();

			// Привязываем событие клика
			this.MouseClick += Form2_1_sr_MouseClick;
		}

		private void Form2_1_sr_MouseClick(object sender, MouseEventArgs e)
		{
			// Запоминаем координаты клика
			circleX = e.X;
			circleY = e.Y;

			// Принудительно перерисовываем форму
			this.Invalidate();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			// Если круг еще не рисовали - выходим
			if (circleX == -1 || circleY == -1)
				return;

			Graphics g = e.Graphics;

			// Рисуем закрашенный красный круг
			using (SolidBrush brush = new SolidBrush(Color.GreenYellow))
			{
				g.FillEllipse(brush, circleX - RADIUS, circleY - RADIUS,
							  RADIUS * 2, RADIUS * 2);
			}
		}
	}
}