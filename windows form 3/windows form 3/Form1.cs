namespace windows_form_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == false)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            else
            {
                pictureBox1.Visible=false;
                pictureBox2.Visible=true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible=false; 
        }
    }
}
