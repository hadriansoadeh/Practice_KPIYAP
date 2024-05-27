using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputText = textBox1.Text;

            string[] words = inputText.Split(' ');

            int countWord = 0;

            foreach (string word in words)
            {
                countWord++;
            }

            textBox2.Text = Convert.ToString(countWord);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
