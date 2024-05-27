using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 15; 
            dataGridView1.ColumnCount = 15; 
            int[,] a = new int[15, 15]; 
            int i, j;
            Random rand = new Random();
            for (i = 0; i < 15; i++)
            {
                for (j = 0; j < 15; j++)
                {
                    a[i, j] = rand.Next(1, 100);
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j].ToString();
                }
            }

            int rowNumber = -1; 
            double sum = 0; 
            bool foundRow = false; 

            for (i = 0; i < 15; i++)
            {
                if (a[i, 0] == 1) 
                {
                    foundRow = true;
                    for (j = 0; j < 15; j++)
                    {
                        sum += a[i, j];
                    }
                    rowNumber = i + 1; 
                    break; 
                }
            }

            if (foundRow)
            {
                double average = sum / 15; 
                textBox1.Text = $"Строка {rowNumber}: Среднеарифметическое = {average:F2}";
            }
            else
            {
                textBox1.Text = "Строки нет";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
