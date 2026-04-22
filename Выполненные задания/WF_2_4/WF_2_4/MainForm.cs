using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_2_4
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void button_Grafik_Click(object sender, EventArgs e)
		{
			// Получаем значения, введенные пользователем в текстовые поля
			// и преобразовываем их в числовые
			double U0 = Convert.ToDouble(textBox_U0.Text);
			
			double f = Convert.ToDouble(textBox_f.Text);
			double fi_0 = Convert.ToDouble(textBox_fi_0.Text);//в градусах
			fi_0 = fi_0 * Math.PI / 180;//в радианах
			double tn = Convert.ToDouble(textBox_tn.Text);
			double tk = Convert.ToDouble(textBox_tk.Text);
			double dt = Convert.ToDouble(textBox_dt.Text);
			// Настраиваем тип графика (команда пишется в одну строку) 
			chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.
			Charting.SeriesChartType.Spline;
			// Очищаем существующие данные
			chart1.Series[0].Points.Clear();
			chart1.ChartAreas[0].AxisX.IsStartedFromZero = true;
			// Добавляем заголовок к графику функции
			chart1.Titles.Clear();
			chart1.Titles.Add("ГРАФИК ИЗМЕНЕНИЯ НАПРЯЖЕНИЯ");
			chart1.Titles[0].Font = new Font("Utopia",16);
			// Форматируем цвет фона области диаграммы
			chart1.ChartAreas[0].BackColor = Color.White;
			// Форматировать диаграмму
			chart1.BackColor = Color.Green;
			chart1.BackSecondaryColor = Color.WhiteSmoke;
			chart1.BorderlineColor = Color.DarkGreen;
			for (double t = tn; t <= tk; t += dt)
			{
				double U = U0 * Math.Sin(2 * Math.PI * f * t + fi_0);
				chart1.Series[0].Points.AddXY(t, U);
			}
		}
	}
}