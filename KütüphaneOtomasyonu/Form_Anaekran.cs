using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KütüphaneOtomasyonu
{
    public partial class Form_AnaEkran : Form
    {
        public Form_AnaEkran()
        {
            InitializeComponent();
        }

        public static SqlConnection baglanti = new SqlConnection("Data Source = localhost; Initial Catalog = Kutuphane; Integrated Security = True");

        public static void baglantiac() { if (baglanti.State != ConnectionState.Open) baglanti.Open(); }
        public static void baglantikapa() { if (baglanti.State != ConnectionState.Closed) baglanti.Close(); }

        private void button_kitap_Click(object sender, EventArgs e)
        {
            Kitaplar kitaplar = new Kitaplar();
            kitaplar.ShowDialog();
        }

        private void button_uye_Click(object sender, EventArgs e)
        {
            Uyeler uyeler = new Uyeler();
            uyeler.ShowDialog();
        }

        private void button_yazar_Click(object sender, EventArgs e)
        {
            Yazarlar yazarlar = new Yazarlar();
            yazarlar.ShowDialog();
        }

        private void button_emanet_Click(object sender, EventArgs e)
        {
            Emanetler emanetler = new Emanetler();
            emanetler.ShowDialog();
        }

        private void button_personel_Click(object sender, EventArgs e)
        {
            Personeller personeller = new Personeller();
            personeller.ShowDialog();
        }

        private void button_rapor_Click(object sender, EventArgs e)
        {
            Raporlar raporlar = new Raporlar();
            raporlar.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblZaman.Text = "Saat: " + DateTime.Now.ToLongTimeString();
            lblTarih.Text = "Tarih: " + DateTime.Now.ToLongDateString();
            statusStrip1.Location = new Point((Width - statusStrip1.Width) / 2,372);
        }

        private void Form_AnaEkran_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Program kapatılacak onaylıyor musunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes) Application.Exit();
        }
    }
}