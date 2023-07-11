namespace Proje_Ödevi_2
{
    public partial class Form1 : Form
    {  
        public Form1()
        {
            InitializeComponent();
        }
        public static string kullaniciadi="";
        public static string sifre="";
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lütfen 'Menü' sekmesini ziyaret ediniz");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 siparis = new Form2();
            siparis.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 KayıtOl = new Form3();
            KayıtOl.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username,password;
            username = textBox1.Text;
            password = textBox2.Text;
            if(kullaniciadi == username)
            {
                if(sifre == password)
                {
                    MessageBox.Show("Giriş yapıldı");
                    label4.Visible = false;
                    textBox2.Visible = false;
                    button1.Visible = false;
                    button2.Visible = false;
                    textBox1.Text = kullaniciadi;
                    textBox1.Enabled = false;
                    label3.Location = new Point(1, 37);
                    textBox1.Location = new Point(121, 37);
                }
                else
                {
                    MessageBox.Show("Hatalı giriş yapıldı");
                }
            }
            else
            {
                MessageBox.Show("Hatalı giriş yapıldı");
            }


        }
    }
}