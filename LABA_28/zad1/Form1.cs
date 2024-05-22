using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Point[] trianglePoints = { new Point(10, 50), new Point(50, 10), new Point(90, 50) };
            g.DrawPolygon(Pens.Black, trianglePoints);

            Rectangle ellipseRect = new Rectangle(110, 10, 80, 60);
            g.DrawEllipse(Pens.Black, ellipseRect);

            Rectangle filledCircleRect = new Rectangle(220, 10, 60, 60);
            g.FillEllipse(Brushes.Blue, filledCircleRect);

            Rectangle filledRectangleRect = new Rectangle(320, 10, 80, 60);
            g.FillRectangle(Brushes.Green, filledRectangleRect);

            Rectangle sectorRect = new Rectangle(440, 10, 80, 60);
            g.FillPie(Brushes.Red, sectorRect, 0, 90);

            Rectangle targetRect = new Rectangle(10, 210, 80, 80);
            g.DrawEllipse(Pens.Black, targetRect);
            g.DrawEllipse(Pens.Black, targetRect.X + 20, targetRect.Y + 20, 40, 40);
            g.DrawEllipse(Pens.Black, targetRect.X + 40, targetRect.Y + 40, 0, 0);

            int squareSize = 20;
            for (int i = 0; i < 5; i++)
            {
                Rectangle squareRect = new Rectangle(150 + i * squareSize, 210 + i * squareSize, squareSize, squareSize);
                g.FillRectangle(Brushes.White, squareRect); 
                g.DrawRectangle(Pens.Black, squareRect);
            }

            int gridSize = 10;
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    Brush brush = (row + col) % 2 == 0 ? Brushes.Black : Brushes.White;
                    Rectangle cellRect = new Rectangle(300 + col * gridSize, 210 + row * gridSize, gridSize, gridSize);
                    g.FillRectangle(brush, cellRect);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
