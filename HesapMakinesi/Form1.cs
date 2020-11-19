using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        double karekok;
        int islem = 0;
        double sayi1 = 0, sayi2 = 0;


        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "0")
                    textBox1.Text = "";
                textBox1.Text += ",";
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            {
                textBox1.Text = "0";
            }
        }

        private void bBir_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "0")
                    textBox1.Text = "";
                textBox1.Text += "1";
            }
        }

        private void bIkı_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "0")
                    textBox1.Text = "";
                textBox1.Text += "2";
            }
        }

        private void bUc_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "0")
                    textBox1.Text = "";
                textBox1.Text += "3";
            }
        }

        private void bDort_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "0")
                    textBox1.Text = "";
                textBox1.Text += "4";
            }
        }

        private void bBes_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "0")
                    textBox1.Text = "";
                textBox1.Text += "5";
            }
        }

        private void bAltı_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "0")
                    textBox1.Text = "";
                textBox1.Text += "6";
            }
        }

        private void bYedi_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "0")
                    textBox1.Text = "";
                textBox1.Text += "7";
            }
        }

        private void bSekız_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "0")
                    textBox1.Text = "";
                textBox1.Text += "8";
            }
        }

        private void bDokuz_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "0")
                    textBox1.Text = "";
                textBox1.Text += "9";
            }
        }

        private void bSıfır_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "0")
                    textBox1.Text = "";
                textBox1.Text += "0";
            }
        }

        private void bSilme_Click(object sender, EventArgs e)
        {
            {
                textBox1.Text = "0";
            }
        }

        private void bCıkarma_Click(object sender, EventArgs e)
        {
            {
                islem = 2;
                sayi1 = double.Parse(textBox1.Text);
                sifirla();
            }
            void sifirla()

            {
                textBox1.Text = "0";
            }

        }

        private void bSonuc_Click(object sender, EventArgs e)
        {
            {
                sayi2 = double.Parse(textBox1.Text);
                textBox1.Text = hesapla().ToString("#,#.00");
            }

            double hesapla()
            {
                double sonuc = 0;

                if (islem == 1)
                    sonuc = sayi1 + sayi2;
                else if (islem == 2)
                    sonuc = sayi1 - sayi2;
                else if (islem == 3)
                    sonuc = sayi1 * sayi2;
                else if (islem == 4)
                    sonuc = sayi1 / sayi2;
                else if (islem == 5)
                    sonuc = Math.Sqrt(sayi1);
                else if (islem == 6)
                    sonuc = sayi1 % sayi2;
                else
                    sonuc = 0;

                return sonuc;

            }
        }

        private void bBolme_Click(object sender, EventArgs e)
        {
            {
                islem = 4;
                sayi1 = double.Parse(textBox1.Text);
                sifirla();
            }
            
            void sifirla()
            {
                textBox1.Text = "0";
            }
            
        }

        private void bCarpma_Click(object sender, EventArgs e)
        {
            {
                islem = 3;
                sayi1 = double.Parse(textBox1.Text);
                sifirla();
            }

            void sifirla()
            {
                textBox1.Text = "0";
            }
        }

        private void bKok_Click(object sender, EventArgs e)
        {
            
            {
                islem = 5;
                sayi1 = double.Parse(textBox1.Text);
                sayi();
            }
 
            void sayi()
            {
                textBox1.Text = Convert.ToString(sayi1);
            }

        }

        private void bMod_Click(object sender, EventArgs e)
        {
            {
                islem = 6;
                sayi1 = double.Parse(textBox1.Text);
                sifirla();
                sayi2 = double.Parse(textBox1.Text);
            }

            void sifirla()
            {
                textBox1.Text = "0";
            }
        }

        private void bToplama_Click(object sender, EventArgs e)
        {
            {
                islem = 1;
                sayi1 = double.Parse(textBox1.Text);
                sifirla();
            }

             void sifirla()

            {
                textBox1.Text = "0";
            }
        }
    }
     
}
