namespace WF_2_4
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.textBox_U0 = new System.Windows.Forms.TextBox();
			this.textBox_tn = new System.Windows.Forms.TextBox();
			this.textBox_f = new System.Windows.Forms.TextBox();
			this.textBox_tk = new System.Windows.Forms.TextBox();
			this.textBox_fi_0 = new System.Windows.Forms.TextBox();
			this.textBox_dt = new System.Windows.Forms.TextBox();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.button_Grafik = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox_U0
			// 
			this.textBox_U0.Location = new System.Drawing.Point(29, 43);
			this.textBox_U0.Name = "textBox_U0";
			this.textBox_U0.Size = new System.Drawing.Size(100, 20);
			this.textBox_U0.TabIndex = 0;
			// 
			// textBox_tn
			// 
			this.textBox_tn.Location = new System.Drawing.Point(29, 90);
			this.textBox_tn.Name = "textBox_tn";
			this.textBox_tn.Size = new System.Drawing.Size(100, 20);
			this.textBox_tn.TabIndex = 1;
			// 
			// textBox_f
			// 
			this.textBox_f.Location = new System.Drawing.Point(195, 43);
			this.textBox_f.Name = "textBox_f";
			this.textBox_f.Size = new System.Drawing.Size(100, 20);
			this.textBox_f.TabIndex = 2;
			// 
			// textBox_tk
			// 
			this.textBox_tk.Location = new System.Drawing.Point(195, 89);
			this.textBox_tk.Name = "textBox_tk";
			this.textBox_tk.Size = new System.Drawing.Size(100, 20);
			this.textBox_tk.TabIndex = 3;
			// 
			// textBox_fi_0
			// 
			this.textBox_fi_0.Location = new System.Drawing.Point(351, 42);
			this.textBox_fi_0.Name = "textBox_fi_0";
			this.textBox_fi_0.Size = new System.Drawing.Size(100, 20);
			this.textBox_fi_0.TabIndex = 4;
			// 
			// textBox_dt
			// 
			this.textBox_dt.Location = new System.Drawing.Point(351, 89);
			this.textBox_dt.Name = "textBox_dt";
			this.textBox_dt.Size = new System.Drawing.Size(100, 20);
			this.textBox_dt.TabIndex = 5;
			// 
			// chart1
			// 
			chartArea2.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea2);
			legend2.Name = "Legend1";
			this.chart1.Legends.Add(legend2);
			this.chart1.Location = new System.Drawing.Point(29, 147);
			this.chart1.Name = "chart1";
			series2.ChartArea = "ChartArea1";
			series2.Legend = "Legend1";
			series2.Name = "Series1";
			this.chart1.Series.Add(series2);
			this.chart1.Size = new System.Drawing.Size(341, 191);
			this.chart1.TabIndex = 6;
			this.chart1.Text = "chart1";
			// 
			// button_Grafik
			// 
			this.button_Grafik.Location = new System.Drawing.Point(376, 207);
			this.button_Grafik.Name = "button_Grafik";
			this.button_Grafik.Size = new System.Drawing.Size(75, 42);
			this.button_Grafik.TabIndex = 7;
			this.button_Grafik.Text = "Построить график";
			this.button_Grafik.UseVisualStyleBackColor = true;
			this.button_Grafik.Click += new System.EventHandler(this.button_Grafik_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(39, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "U0";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(16, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "tn";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(195, 27);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(10, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "t";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(198, 70);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(16, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "tk";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(348, 26);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(24, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "fi_0";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(348, 70);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(16, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "dt";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Lime;
			this.ClientSize = new System.Drawing.Size(454, 461);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button_Grafik);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.textBox_dt);
			this.Controls.Add(this.textBox_fi_0);
			this.Controls.Add(this.textBox_tk);
			this.Controls.Add(this.textBox_f);
			this.Controls.Add(this.textBox_tn);
			this.Controls.Add(this.textBox_U0);
			this.Name = "MainForm";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox_U0;
		private System.Windows.Forms.TextBox textBox_tn;
		private System.Windows.Forms.TextBox textBox_f;
		private System.Windows.Forms.TextBox textBox_tk;
		private System.Windows.Forms.TextBox textBox_fi_0;
		private System.Windows.Forms.TextBox textBox_dt;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Button button_Grafik;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
	}
}

