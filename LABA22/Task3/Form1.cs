namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x0, xk, dx, a, b;

            if (!double.TryParse(textBox6.Text, out x0) ||
                !double.TryParse(textBox5.Text, out xk) ||
                !double.TryParse(textBox4.Text, out dx) ||
                !double.TryParse(textBox1.Text, out a) ||
                !double.TryParse(textBox2.Text, out b))
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения.");
                return;
            }

            double x = x0;
            while (x <= (xk + dx / 2))
            {
                double y = 1.2 * Math.Pow((a - b), 3) * Math.Exp(Math.Pow(x, 2)) + x;
                textBox3.Text += "x = " + Convert.ToString(x) + "y = " + Convert.ToString(y) + Environment.NewLine;
                x += dx;
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

