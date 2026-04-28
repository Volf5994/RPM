namespace WF_2_1_sr
{
	public partial class Form1 : Form
	{
		private List<Point> circles = new List<Point>();
		private const int Radius = 30;
		public Form1()
		{
			InitializeComponent();
			this.DoubleBuffered = true;
			this.MouseClick += (s, e) =>
			{
				if (e.Button == MouseButtons.Left)
				{
					circles.Add(e.Location);
					this.Invalidate();
				}
			};
			this.Paint += (s, e) =>
			{
				e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
				foreach (Point p in circles)
				{
					e.Graphics.FillEllipse(Brushes.Red, p.X - Radius, p.Y - Radius, Radius * 2, Radius * 2);
					e.Graphics.DrawEllipse(Pens.Black, p.X - Radius, p.Y - Radius, Radius * 2, Radius * 2);
				}
			};
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}
	}
}
