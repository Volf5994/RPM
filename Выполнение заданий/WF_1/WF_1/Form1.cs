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
            // Добавляем элементы в список математических операций
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");
            // Устанавливаем выбранный элемент с индексом 0
            comboBox1.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
            // Определяем текст, введенный пользователем
            // в поле "Число 1"
            string sx1 = textBox1.Text;
            // Преобразуем текст в число
            int x1 = Convert.ToInt32(sx1);
            // Определяем текст, введенный пользователем
            // в поле "Число 2"
            string sx2 = textBox2.Text;
            // Преобразуем текст в число
            int x2 = Convert.ToInt32(sx2);
            // Определяем, какую математическую операцию выбрал пользователь
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
            else
            {
                result = x1 / x2;
            }

            // Выводим результат в текстовое поле
            textBox3.Text = " = " + result;
        }
        // Обрабатываем исключение возникающее при делении на ноль
        catch (DivideByZeroException)
        {
            textBox3.Text = "Деление на 0!";
        }
        // Обрабатываем исключение при неккоректном вводе числа в консоль
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
