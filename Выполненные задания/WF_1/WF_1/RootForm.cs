using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_1
{
    public partial class RootForm : Form
    {
        public RootForm()
        {
            InitializeComponent();
        }

        private void RootForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Степень");
            comboBox1.Items.Add("Корень");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x1 = Convert.ToDouble(textBox2.Text);
                double x2 = Convert.ToDouble(textBox3.Text);

                string mop = comboBox1.SelectedItem?.ToString();
                double result = 0;

                if (mop == "Степень")
                {
                    result = Math.Pow(x2, x1);
                }
                else if (mop == "Корень")
                {
                    result = Math.Pow(x2, 1.0 / x1);
                }

                textBox1.Text = " = " + result.ToString();
            }
            catch (FormatException)
            {
                textBox1.Text = "Ошибка: введите числа!";
            }
        }
    }
    
}
