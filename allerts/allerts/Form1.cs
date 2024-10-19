namespace allerts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("costruttore del form", "DEBUG");
            //non esistono ancora i componenti del form

            /*inizializzazione degli attributi del form */
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Thread.Sleep(5000);
            MessageBox.Show("Load");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {

        }

        private void onemessaggio(object obj)
        {
            Class1 arg = (Class1)obj;
            MessageBox.Show(arg.Numero.ToString(), arg.Caption);
        }

        private void messaggio(object obj)
        {
            // primo metodo
            //Class1 arg = (Class1)obj;
            //MessageBox.Show(arg.Numero.ToString(), arg.Caption );

            //secondo metodo
            //Class1 argomento = obj as Class1;
            //MessageBox.Show(argomento.Numero.ToString(), argomento.Caption);

            //terzo metodo
            Thread[] mes=new Thread[3];
            for ( int i = 0; i < 3; i++ ) 
            {
                mes[i] = new Thread(onemessaggio);
                mes[i].Start(obj);
            }
       
            MessageBox.Show(((Class1)obj).Numero.ToString(), ((Class1)obj).Caption);


        }

        private void Form1_Shown(object sender, EventArgs e)
        {

            //  Thread.Sleep(3000);
            //  MessageBox.Show("domanda");
            //avvio un thread che eseguirà la messagebox shown
            Class1 uno = new Class1(1, "ciao");
            Class1 due = new Class1(2, "hello");

            Thread thread1 = new Thread(messaggio);
            thread1.Start(uno);
            Thread thread2 = new Thread(messaggio);
            thread2.Start(due);


        }
    }
}