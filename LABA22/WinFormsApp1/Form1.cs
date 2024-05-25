namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;
            label.Text = "Начало работы";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label.Text = button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label.Text = button2.Text;  
        }
    }
}
