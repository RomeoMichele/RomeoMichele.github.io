namespace lampadina_V03_09._10._2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\romeo.21280\\Pictures\\Screenshots\\lamp_accesa.png");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\romeo.21280\\Pictures\\Screenshots\\lamp_spenta.png");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y > 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 50);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y < 1000)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 50);
            }
        }
    }
}