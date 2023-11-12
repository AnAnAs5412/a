using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        private string sing;
        private double n1;
        private double n2;
        double rez;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = Convert.ToString(button.Text);
            textBox1.Text += button.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            n1 = Convert.ToDouble(textBox1.Text);
            sing = Convert.ToString(button.Text);
            if (sing == "sqrt")
            {
                rez = Math.Sqrt(n1);
                textBox1.Text = rez.ToString();
            }
            else
            {
                textBox1.Text = "";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            n2 = Convert.ToDouble(textBox1.Text);
            switch (sing)
            {
                case "+":
                    rez = n1 + n2;
                    break;
                case "-":
                    rez = n1 - n2;
                    break;
                case "*":
                    rez = n1 * n2;
                    break;
                case "/":
                    if (n2 == 0)
                    {
                        textBox1.Text = "Ошибка";
                    }
                    else
                    {
                        rez = n1 / n2;
                    }
                    break;
                case "%":
                    if (n2 == 0)
                    {
                        textBox1.Text = "Ошибка";
                    }
                    else
                    {
                        rez = n1 % n2;
                    }
                    break;
                case "^":
                    rez = Math.Pow(n1, n2);
                    break;
            }
            textBox1.Text = rez.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
