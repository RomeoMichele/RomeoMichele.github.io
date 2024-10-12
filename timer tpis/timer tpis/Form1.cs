namespace timer_tpis
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = (Convert.ToInt16(label4.Text) - 1).ToString();
            if (label4.Text == "0")
            {
                MessageBox.Show("BOOM!");
                timer1.Stop();
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.components.Add(label4);
            label4 = new System.Windows.Forms.Label();
            label4.Location = new Point(10, 10);
            label4.Font = new Font(FontFamily.Families[0], 36);
            label4.Size = new Size(100, 100);

            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Start();

            label4.Text = numericUpDown1.Value.ToString();
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
    }
}