namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double Factorial(double number)
        {
            if (number <= 1) return 1;
            else return number * Factorial(number - 1);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "-4.5";
            textBox2.Text = "0.75x10^-4";
            textBox3.Text = "0.845x10^2";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = -4.5;
            textBox4.Text +=  "X = " + x.ToString();
            double y = Math.Round(0.75 * Math.Pow(10, -4),4);
            textBox4.Text += Environment.NewLine + "Y = " + y.ToString();
            double z = 0.845 * Math.Pow(10, 2);
            textBox4.Text += Environment.NewLine + "Z = " + z.ToString();
            double u = Math.Sqrt((1 + Math.Pow(Math.Sin(x + y), 2)) / (x - (2 * y) / (1 + Math.Pow(x, 2) * Math.Pow(y, 2)))) * Factorial(x) + Math.Pow(Math.Cos(Math.Atan(1 / y)), 3);
            textBox4.Text += Environment.NewLine + "Результат U = " + u.ToString();

        }
    }
}
