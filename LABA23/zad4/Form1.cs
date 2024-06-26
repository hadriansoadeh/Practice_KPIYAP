﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputText = textBox1.Text.Trim().ToUpper();
            int x = int.Parse(textBox2.Text);
            int y = int.Parse(textBox3.Text);

            Control newControl = null;

            switch (inputText)
            {
                case "К":
                    newControl = new Button
                    {
                        Text = "Новая кнопка",
                        Location = new Point(x, y),
                        Size = new Size(100, 100),
                        BackColor = Color.Red,
                    };
                    break;
                case "П":
                    newControl = new TextBox
                    {
                        Text = "Новое поле ввода",
                        Location = new Point(x, y),
                        Size = new Size(150, 150),
                        BackColor = Color.Green,
                    };
                    break;
                case "М":
                    newControl = new Label
                    {
                        Text = "Новая метка",
                        Location = new Point(x, y),
                        AutoSize = true,
                        BackColor = Color.Yellow,
                    };
                    break;
                default:
                    MessageBox.Show("Неверный ввод. Введите 'К', 'П' или 'М'.");
                    break;
            }

            if (newControl != null)
            {
                newControl.MouseEnter += (s, ev) => Controls.Remove(newControl);
                Controls.Add(newControl);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
