using System.Diagnostics.Eventing.Reader;

namespace TPIS_1
{
    public partial class Form1 : Form
    {
        private string turn;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Button pulsante = (Button)sender;
            if (pulsante.Text == " ")
            {
                pulsante.Text = turn;
                if (turn == "X") turn = "O";
                else turn = "X";
                labelturno.Text = turn;

            }
            if (
                button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != " " ||
                button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != " " ||
                button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != " " ||
                button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != " " ||
                button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != " " ||
                button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != " " ||
                button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != " " ||
                button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != " " ||
                button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != " " 
               )
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random generatore = new Random();
            if (generatore.Next(2) == 0) turn = "X";
            else turn = "O";
            labelturno.Text = turn;
        }


    }
}