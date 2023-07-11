using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Proje_Ödevi_2.Form1;

namespace Proje_Ödevi_2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kullaniciadi = textBox1.Text;
            sifre = textBox2.Text;
            MessageBox.Show("Kayıt yapıldı","Kayıt Ol",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            this.Hide();
        }
    }
}
