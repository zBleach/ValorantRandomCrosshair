using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValorantRandomCrosshairForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            // ANA ÇİZGİ VE NOKTA

            // Ana Çizgi / Nokta Saydamlık
            int crossdurum = random.Next(0, 2);
            switch (crossdurum)
            {
                case 0:
                    anacizgi.Text = "Açık";
                    break;
                case 1:
                    anacizgi.Text = "Kapalı";
                    break;
            }
            switch (crossdurum)
            {
                case 0:
                    nokta.Text = "Açık";
                    break;
                case 1:
                    nokta.Text = "Kapalı";
                    break;
            }
            int anacizginoktasaydamlık = random.Next(0, 2);
            anacizgisaydam.Text = anacizginoktasaydamlık.ToString();
            noktasaydam.Text = anacizginoktasaydamlık.ToString();

            // Ana Çizgi / Nokta Kalınlık
            int anacizginoktakalinlik = random.Next(0, 7);
            anacizgikalinlik.Text = anacizginoktakalinlik.ToString();
            noktakalin.Text = anacizginoktakalinlik.ToString();

            // ANA ÇİZGİ VE NOKTA

            //İÇ ÇİZGİ
            switch (crossdurum)
            {
                case 0:
                    iccizgi.Text = "Açık";
                    break;
                case 1:
                    iccizgi.Text = "Kapalı";
                    break;
            }
            //İç Çizgi Saydamlık
            int iccizgisaydamlikdegisken = random.Next(0, 2);
            iccizgisaydam.Text = iccizgisaydamlikdegisken.ToString();

            //İç Çizgi Uzunluk
            int iccizgiuzunlukdegisken = random.Next(0, 21);
            iccizgiuzun.Text = iccizgiuzunlukdegisken.ToString();

            //İç Çizgi Kalınlık
            int iccizgikalinlikdegisken = random.Next(0, 11);
            iccizgikalin.Text = iccizgikalinlikdegisken.ToString();

            //İç Çizgi Uzunluk
            int iccizgiuzaklikdegisken = random.Next(0, 21);
            iccizgiuzaklik.Text = iccizgiuzaklikdegisken.ToString();

            //İÇ ÇİZGİ

            //DIŞ ÇİZGİ
            switch (crossdurum)
            {
                case 0:
                    discizgi.Text = "Açık";
                    break;
                case 1:
                    discizgi.Text = "Kapalı";
                    break;
            }
            //Dış Çizgi Saydamlık
            int discizgisaydamlikdegisken = random.Next(0, 2);
            discizgisaydam.Text = discizgisaydamlikdegisken.ToString();

            //Dış Çizgi Uzunluk
            int discizgiuzunlukdegisken = random.Next(0, 11);
            discizgiuzun.Text = discizgiuzunlukdegisken.ToString();

            //Dış Çizgi Kalınlık
            int discizgikalinlikdegisken = random.Next(0, 11);
            discizgikalin.Text = discizgikalinlikdegisken.ToString();

            //Dış Çizgi Uzunluk
            int discizgiuzaklikdegisken = random.Next(0, 41);
            discizgiuzaklik.Text = discizgiuzaklikdegisken.ToString();

            //DIŞ ÇİZGİ





        }
    }
}
