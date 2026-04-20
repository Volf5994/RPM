namespace WF_2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{

			//Рисуем линию максимальной непрозрачности,
			//красного цвета и толщиной 6 пикселей
			Pen pen = new Pen(Color.FromArgb(255, 255, 0, 0), 6);
			//Координаты линии: (20, 10) - начало линии, (300, 100) - конец линии
			e.Graphics.DrawLine(pen, 20, 10, 300, 100);
		}
	}
}
