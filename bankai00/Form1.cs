using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankai00
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1, s2;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            if (s1 > s2)
            {
                label3.Text = "1.Sayı 2.Sayıdan Büyüktür";
            }
            else if (s2 > s1)
            {
                label3.Text = "2.Sayı 1.Sayıdan Büyüktür";
            }
            else
            {
                label3.Text = "Sayılar Eşittir";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double s1, s2, p, ort = 0;
            s1 = Convert.ToDouble(textBox3.Text);
            s2 = Convert.ToDouble(textBox4.Text);
            p = Convert.ToDouble(textBox5.Text);
            ort = (s1 + s2 + p) / 3;
            if (ort < 50)
            {
                label4.Text = ort + " Ortalamanız , 1 Kaldınız";
            }
            else if (ort < 55)
            {
                label4.Text = ort + " Ortalamanız , 2 Geçtiniz";
            }
            else if (ort < 70)
            {
                label4.Text = ort + " Ortalamanız , 3 Geçtiniz";
            }
            else if (ort < 85)
            {
                label4.Text = ort + "  Ortalamanız , 4 Geçtiniz";
            }
            else
            {
                label4.Text = ort + " Ortalamanız , 5 Geçtiniz";
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenAy = comboBox1.SelectedItem.ToString();
            switch (secilenAy)
            {
                case "ARALIK":
                case "OCAK":
                case "ŞUBAT":
                    label8.Text = "KIŞ";
                    break;

                case "MART":
                case "NİSAN":
                case "MAYIS":
                    label8.Text = "İLKBAHAR";
                    break;
                case "HAZİRAN":
                case "TEMMUZ":
                case "AĞUSTOS":
                    label8.Text = "YAZ";
                    break;
                case "EYLÜL":
                case "EKİM":
                case "KASIM":
                    label8.Text = "SONBAHAR";
                    break;

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gunler = comboBox2.SelectedItem.ToString();
            switch (gunler)
            {
                case "PAZARTESİ":
                case "SALI":
                case "ÇARŞAMBA":
                case "PERŞEMBE":
                case "CUMA":
                    label9.Text = "HAFTA İÇİ";
                    break;
                case "CUMARTESİ":
                case "PAZAR":
                    label9.Text = "HAFTA SONU";
                    break;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int gun = Convert.ToInt32(textBox6.Text);

            switch (gun)
            {
                case 1:
                    label12.Text = "PAZARTESİ";
                    break;
                case 2:
                    label12.Text = "SALI";
                    break;
                case 3:
                    label12.Text = "ÇARŞAMBA";
                    break;
                case 4:
                    label12.Text = "PERŞEMBE";
                    break;
                case 5:
                    label12.Text = "CUMA";
                    break;
                case 6:
                    label12.Text = "CUMARTESİ";
                    break;
                case 7:
                    label12.Text = "PAZAR";
                    break;
                default:
                    label12.Text = "HATALI SAYI GİRDİNİZ... ";
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string kullaniciAdi, sifre;
            kullaniciAdi = textBox7.Text;
            sifre = textBox8.Text;
            if (kullaniciAdi == "ahmeterkul" && sifre == "deneme123")
            {
                label14.Text = "GİRİŞ BAŞARILI";
                label14.ForeColor = Color.Green;
             
            }
            else
            {
                label14.Text = "GİRİŞ BAŞARISIZ";
                label14.ForeColor = Color.Red;
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            int yas = Convert.ToInt32(textBox9.Text);
            if (yas>=20 && radioButton1.Checked)
            {
                label17.Text = "ASKERE GİDEBİLİRİSİNİZ";
                label17.ForeColor = Color.Green;
            }
            else
            {
                label17.Text = "ASKERE GİDEMEZSİNİZ";
                label17.ForeColor = Color.Red;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            double boy, kilo, vki = 0;
            boy = Convert.ToDouble(textBox10.Text);
            kilo = Convert.ToDouble(textBox11.Text);
            vki = kilo / ((boy / 100) * (boy / 100));
            if (vki<=19)
            {
                label18.Text = "Düşük Kilolusunuz..";
            }
            else if (vki > 19 && vki<=25)
            {
                label18.Text = "Sağlıklısnız..";
            }
            else if (vki > 25 && vki<=30)
            {
                label18.Text = "Fazla Kilolusunuz..";
            }
            else if (vki > 30 && vki<=35)
            {
                label18.Text = "1. Seviye Obezite..";
            }
            else if (vki > 35 && vki <= 40)
            {
                label18.Text = "2. Seviye Obezite..";
            }
            else
            {
                label18.Text = "3. Seviye Obezite..";
            }
        }
    }
}