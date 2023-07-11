using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proje_Ödevi_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {   
            InitializeComponent();
        }
        int hesapla=0;
        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton10.Checked == true)
            {
                label25.Text = "30 TL";
            }
            if(radioButton11.Checked == true)
            {
                label25.Text = "15 TL";
            }
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton12.Checked == true)
            {
                label26.Text = "30 TL";
            }
            if (radioButton13.Checked == true)
            {
                label26.Text = "15 TL";
            }
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton14.Checked == true)
            {
                label27.Text = "16 TL";
            }
            if (radioButton15.Checked == true)
            {
                label27.Text = "8 TL";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label13.Text = "156 TL";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label13.Text = "185 TL";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                label13.Text = "250 TL";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                label15.Text = "200 TL";
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                label15.Text = "280 TL";
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                label15.Text = "350 TL";
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                label17.Text = "175 TL";
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true)
            {
                label17.Text = "250 TL";    
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                label17.Text = "325 TL";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sepetim.Items.Add(label5.Text);
            Fiyat.Items.Add(label6.Text);
            hesapla += 105;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sepetim.Items.Add(label7.Text);
            Fiyat.Items.Add(label8.Text);
            hesapla += 145;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sepetim.Items.Add(label9.Text);
            Fiyat.Items.Add(label11.Text);
            hesapla += 345;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked==false && radioButton2.Checked==false && radioButton3.Checked == false)
            {
                MessageBox.Show("Boyut Seçiniz");
            }
            else
            {
                Sepetim.Items.Add(label12.Text);
                Fiyat.Items.Add(label13.Text);
                if (radioButton1.Checked == true)
                {
                    Sepetim.Items.Add("(Küçük Boy)");
                    hesapla += 156;
                }
                if (radioButton2.Checked == true)
                {
                    Sepetim.Items.Add("(Orta Boy)");
                    hesapla += 185;
                }
                if (radioButton3.Checked == true)
                {
                    Sepetim.Items.Add("(Büyük Boy)");
                    hesapla += 250;
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        { 
            if (radioButton4.Checked==false && radioButton5.Checked==false && radioButton6.Checked == false)
            {
                MessageBox.Show("Boyut Seçiniz");
            }
            else
            {

           
            Sepetim.Items.Add(label14.Text);
            Fiyat.Items.Add(label15.Text);
            if (radioButton4.Checked == true)
            {
                    Sepetim.Items.Add("(Küçük Boy)");
                    hesapla += 200;
            }
            if (radioButton5.Checked == true)
            {
                    Sepetim.Items.Add("(Orta Boy)");
                    hesapla += 280;
            }
            if (radioButton6.Checked == true)
            {
                    Sepetim.Items.Add("(Büyük Boy)");
                    hesapla += 350;
            }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        { 
            if (radioButton7.Checked == false && radioButton8.Checked == false && radioButton9.Checked == false)
            {
                MessageBox.Show("Boyut Seçiniz");
            }
            else
            { 
            Sepetim.Items.Add(label16.Text);
            Fiyat.Items.Add(label17.Text);
            
            if (radioButton7.Checked == true)
            {
                    Sepetim.Items.Add("(Küçük Boy)");
                    hesapla += 175;
            }
            if (radioButton8.Checked == true)
            {
                    Sepetim.Items.Add("(Orta Boy)");
                    hesapla += 250;
            }
            if (radioButton9.Checked == true)
            {
                    Sepetim.Items.Add("(Büyük Boy)");
                    hesapla += 325;
            }
           }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Sepetim.Items.Add(label18.Text);
            Fiyat.Items.Add(label19.Text);
            hesapla += 20; 
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Sepetim.Items.Add(label20.Text);
            Fiyat.Items.Add(label21.Text);
            hesapla += 45;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Sepetim.Items.Add(label22.Text);
            Fiyat.Items.Add(label23.Text);
            hesapla += 150;
        }

        private void button10_Click(object sender, EventArgs e)
        {   if (radioButton10.Checked == false && radioButton11.Checked == false)
            {
                MessageBox.Show("Lütfen boyut seçiniz");
            }
            else
            {
                Sepetim.Items.Add(label24.Text);
                Fiyat.Items.Add(label25.Text);
                if (radioButton10.Checked == true)
                {
                    Sepetim.Items.Add("(Litrelik)");
                    hesapla += 30;
                }
                if (radioButton11.Checked == true)
                {
                    Sepetim.Items.Add("(Kutu)");
                    hesapla += 15;
                }

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {   if (radioButton12.Checked == false && radioButton13.Checked == false)
            {
                MessageBox.Show("Lütfen boyut seçiniz");
            }
            else
            {


                Sepetim.Items.Add(label28.Text);
                Fiyat.Items.Add(label26.Text);
                if (radioButton12.Checked == true)
                {
                    Sepetim.Items.Add("(Litrelik)");
                    hesapla += 30;
                }
                if (radioButton13.Checked == true)
                {
                    Sepetim.Items.Add("(Kutu)");
                    hesapla += 15;
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {    if(radioButton14.Checked == false && radioButton15.Checked == false)
            {
                MessageBox.Show("Lütfen bir boyut seçiniz");
            }
            else
            { 
                Sepetim.Items.Add(label29.Text);
                Fiyat.Items.Add(label27.Text);
                if (radioButton14.Checked == true)
                {
                    Sepetim.Items.Add("(Litrelik)");
                    hesapla += 16;
                }
                if (radioButton15.Checked == true)
                {
                    Sepetim.Items.Add("(Kutu)");
                    hesapla += 8;
                }
            }
        }

        private void Fiyat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = hesapla.ToString() +"TL";
            
            
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            Form4 Odeme = new Form4();
            if (Odeme.textBox1.Text == "" && Odeme.textBox2.Text == "" && Odeme.textBox3.Text == "" && Odeme.textBox4.Text == "")
            {
                Odeme.Show();
            }
            Ozet.Items.Clear();
            for (int i = 0; i < Sepetim.Items.Count; i++)
            {
                Ozet.Items.Add(Sepetim.Items[i]);
            }
        
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Sepetim.Items.Clear();
            Fiyat.Items.Clear();
            hesapla = 0;
            textBox1.Text = hesapla.ToString() + "TL";
           
        }

        private void button16_Click(object sender, EventArgs e)
        {
           

        }
    }
}
