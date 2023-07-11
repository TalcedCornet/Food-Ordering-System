using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Ödevi_2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız");
            }
            else
            {
                MessageBox.Show("Ödeme bilgileriniz alınmıştır");
                MessageBox.Show("Siparişiniz Onaylanmıştır..");
                this.Close();
            }
            
        }
    }
}
