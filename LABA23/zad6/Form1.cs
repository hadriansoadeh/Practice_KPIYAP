using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad6
{
    public partial class Form1 : Form
    {
        private double[] A;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            A = new double[25];
            Random random = new Random();
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = random.NextDouble() * 6 - 3;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int negativeCount = 0;
            int rangeCount = 0;

            foreach (double num in A)
            {
                if (num < 0)
                {
                    negativeCount++;
                }
                else if (num >= 1 && num <= 2)
                {
                    rangeCount++;
                }
            }

            // Выводим результаты в textBox2 и textBox3
            textBox2.Text = negativeCount.ToString();
            textBox3.Text = rangeCount.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Join(Environment.NewLine, A.Select((num, index) => $"Mas[{index}] = {num}"));
        }
    }

        
}
