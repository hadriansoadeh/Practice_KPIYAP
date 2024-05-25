namespace Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            int func = Convert.ToInt32(Math.Pow(x, 2));
            if (x == 0)
            {
                double b = Math.Pow(Math.Pow(func,2) + y, 3);
                textBox3.Text += "При x = " + x + Environment.NewLine + "При y = " + y + Environment.NewLine + "Результат b = " + b + Environment.NewLine;
            }
            else if (y == 0) 
            {
                double b = 0;
                textBox3.Text += "При x = " + x + Environment.NewLine + "При y = " + y + Environment.NewLine + "Результат b = " + b + Environment.NewLine;
            }
            else if (x / y > 0)
            {
                double b =  Math.Log(func + Math.Pow(Math.Pow(func, 2) + y, 3));
                textBox3.Text += "При x = " + x + Environment.NewLine + "При y = " + y + Environment.NewLine + "Результат b = " + b + Environment.NewLine;
            }
            else if (x / y < 0)
            {
                double b = Math.Log(Math.Abs((func / y) + Math.Pow(func + y, 3)));
                textBox3.Text += "При x = " + x + Environment.NewLine + "При y = " + y + Environment.NewLine + "Результат b = " + b + Environment.NewLine;
            }
            

        }
    }
}
