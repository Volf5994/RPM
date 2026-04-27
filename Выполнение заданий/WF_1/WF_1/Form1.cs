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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");
            comboBox1.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sx1 = textBox1.Text;
                double x1 = Convert.ToDouble(sx1);
                string sx2 = textBox2.Text;
                double x2 = Convert.ToDouble(sx2);
                string mop = comboBox1.SelectedItem.ToString();
                double result = 0;
                if (mop == "+")
                {
                    result = x1 + x2;
                }
                else if (mop == "-")
                {
                    result = x1 - x2;
                }
                else if (mop == "*")
                {
                    result = x1 * x2;
                }
                else if (mop == "/")
                {
                    if (x2 == 0 || x1 == 0)
                    {
                        textBox3.Text = "Деление на 0!";
                        return;
                    }
                    result = x1 / x2;
                }
            }
            catch (FormatException)
            {
                textBox3.Text = "Это НЕ число!";
            }
            Console.ReadLine();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("+");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RootForm NewRootForm = new RootForm();
            NewRootForm.Show();
        }
    }
}
