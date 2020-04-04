using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VizeFinalOrtalamaHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

         
            int veritabanivize1 = Convert.ToInt32(textBoxVeritabaniVize.Text);
            int veritabanifinal1 = Convert.ToInt32(textBoxVeritabaniFinal.Text);
            

            
            int isletimsistemlerivize1 = Convert.ToInt32(textBoxIsletimSistemleriVize.Text);
            int isletimsistemlerifinal1 = Convert.ToInt32(textBoxIsletimsistemleriFinal.Text);
           


            int bilgisayaraglarivize1 = Convert.ToInt32(textBoxBilgisayarAglariVize.Text);
            int bilgisayaraglarifinal1 = Convert.ToInt32(textBoxBilgisayarAglariFinal.Text);
            


            int projevize1 = Convert.ToInt32(textBoxProjeVize.Text);
            int projefinal1 = Convert.ToInt32(textBoxProjeFinal.Text);


            int veritabanidersiharfnotu = Convert.ToInt32(labelVeritabaniDersiHarfNotu.Text);
            int isletimsistemleridersiharfnotu = Convert.ToInt32(labelIsletimSistemleriDersiHarfNotu.Text);
            int bilgisayaraglaridersiharfnotu = Convert.ToInt32(labelBilgisayarAglariDersiHarfNotu.Text);
            int projedersiharfnotu = Convert.ToInt32(labelProjeDersiHarfNotu.Text);

            // Veritabanı dersinin vize ortalaması;
            int veritabanivizeortalamasi = veritabanivize1 * 30 / 100;
            labelVeritabaniVizeOrtalamasi.Text = veritabanivizeortalamasi.ToString();

            //Veritabanı dersi final ortalaması
            int veritabanifinalortalamasi = veritabanifinal1 * 70 / 100;
            labelVeritabaniFinalOrtalamasi.Text = veritabanifinalortalamasi.ToString();

            //Veritabanı dersi vize ve final ortalamalarının label üzerinde gösterilmesi
            labelVeritabaniDersOrtalamasi.Text = veritabanivizeortalamasi.ToString() + veritabanifinalortalamasi.ToString();







            //İşletim Sistemleri Dersinin vize ortalaması
            int isletimsistemlerivizeortalamasi = isletimsistemlerivize1 * 30 / 100;
            labelIsletimSistemleriVizeOrtalamasi.Text = isletimsistemlerivizeortalamasi.ToString();
            
            //İşletim Sistemleri Dersinin final ortalaması
            int isletimsistemlerifinalortalamasi = isletimsistemlerifinal1 * 70 / 100;
            labelIsletimSistemleriFinalOrtalamasi.Text = isletimsistemlerifinalortalamasi.ToString();

            //İşletim Sistemleri dersi vize ve final ortalamalarının label üzerinde gösterilmesi
            labelIsletimsistemleriDersOrtalamasi.Text = isletimsistemlerivizeortalamasi.ToString() + isletimsistemlerifinalortalamasi.ToString();







            //Bilgisayar Ağları Dersinin vize ortalaması
            int bilgisayaraglarivizeortalamasi = bilgisayaraglarivize1 * 30 / 100;
            labelBilgisayarAglariVizeOrtalamasi.Text = bilgisayaraglarivizeortalamasi.ToString();

            //Bilgisayar Ağları Dersinin final ortalaması
            int bilgisayaraglarifinalortalamasi = bilgisayaraglarifinal1 * 70 / 100;
            labelBilgisayarAglariFinalOrtalamasi.Text = bilgisayaraglarifinalortalamasi.ToString();

            //Bilgisayar Ağları dersi vize ve final ortalamalarının label üzerinde gösterilmesi
            labelBilgisayarAglariDersOrtalamasi.Text = bilgisayaraglarivizeortalamasi.ToString() + bilgisayaraglarifinalortalamasi.ToString();






            //Proje Dersinin vize ortalaması
            int projedersivizeortalamasi = bilgisayaraglarivize1 * 30 / 100;
            labelProjeVizeOrtalamasi.Text = projedersivizeortalamasi.ToString();

            //Proje Dersinin final ortalaması
            int projedersifinalortalamasi = projefinal1 * 70 / 100;
            labelProjeFinalOrtalamasi.Text = projedersifinalortalamasi.ToString();

            //Proje dersinin vize ve final ortalamalarının label üzerinde gösterilmesi
            labelProjeDersOrtalamasi.Text = projedersivizeortalamasi.ToString() + projedersifinalortalamasi.ToString();







            if (veritabanivize1 < 0 || veritabanivize1 > 100 || veritabanifinal1 < 0 || veritabanifinal1 > 100 || isletimsistemlerivize1 < 0 || isletimsistemlerivize1 > 100 || isletimsistemlerifinal1 < 0 || isletimsistemlerifinal1 > 100 || bilgisayaraglarivize1 < 0 || bilgisayaraglarivize1 > 100 || bilgisayaraglarifinal1 < 0 || bilgisayaraglarifinal1 > 100 || projevize1 < 0 || projevize1 > 100 || projefinal1 < 0 || projefinal1 > 100)
            {
                MessageBox.Show("Lütfen 0 ila 100 arasında değerler giriniz.");

            }


            if (veritabanidersiharfnotu <=49 )
            {
                MessageBox.Show("FF ile KALDINIZ");
            }

            else if (veritabanidersiharfnotu <=59 )
            {
                MessageBox.Show("FD ile KALDINIZ");
            }

            else if (veritabanidersiharfnotu <= 64)
            {
                MessageBox.Show("DD ile KALDINIZ");
            }

            else if (veritabanidersiharfnotu <= 69)
            {
                MessageBox.Show("DC ile KOŞULLU GEÇTİNİZ");
            }

            else if (veritabanidersiharfnotu <= 74)
            {
                MessageBox.Show("CC ile GEÇTİNİZ");
            }

            else if (veritabanidersiharfnotu <= 79)
            {
                MessageBox.Show("CB ile GEÇTİNİZ");
            }

            else if (veritabanidersiharfnotu <= 84)
            {
                MessageBox.Show("BB ile GEÇTİNİZ");
            }

            else if (veritabanidersiharfnotu <= 89)
            {
                MessageBox.Show("BA ile GEÇTİNİZ");
            }

            else if (veritabanidersiharfnotu <=100)
            {
                MessageBox.Show("AA ile GEÇTİNİZ");
            }










        }
    }
}
