using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Создаем объект Graphics для рисования на форме
            // Получаем объект Graphics из PaintEventArgs
            Graphics g = e.Graphics;

            // Рисуем голову
            g.DrawEllipse(Pens.Black, 50, 50, 100, 100);

            // Рисуем тело
            g.DrawLine(Pens.Black, 100, 150, 100, 250);

            // Рисуем руки
            g.DrawLine(Pens.Black, 100, 200, 50, 150);
            g.DrawLine(Pens.Black, 100, 200, 150, 150);

            // Рисуем ноги
            g.DrawLine(Pens.Black, 100, 250, 50, 300);
            g.DrawLine(Pens.Black, 100, 250, 150, 300);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
