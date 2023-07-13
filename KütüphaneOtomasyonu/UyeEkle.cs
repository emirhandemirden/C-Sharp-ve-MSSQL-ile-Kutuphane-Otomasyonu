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
    public partial class UyeEkle : Form
    {
        public UyeEkle()
        {
            InitializeComponent();
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            if (maskedTextBox_telefon.Text != "(   )    -   " && maskedTextBox_dogum.Text != "  .  ." && textBox_uyeadsoyad.Text != "" && maskedTextBox_tcno.Text != "")
            {
                try
                {
                    Form_AnaEkran.baglantiac();
                    SqlCommand ekle = new SqlCommand("INSERT INTO Uyeler (uye_ad,uye_dogum,uye_telefon,uye_tc)VALUES('" + textBox_uyeadsoyad.Text + "','" + maskedTextBox_dogum.Text + "','" + maskedTextBox_telefon.Text + "','" + maskedTextBox_tcno.Text + "')", Form_AnaEkran.baglanti);
                    ekle.ExecuteNonQuery();
                    ekle = new SqlCommand("INSERT INTO UyeGecmisleri (gecmis_acıklama,gecmis_detay,gecmis_saat,gecmis_tarih)VALUES('Üye ekleme işlemi.','" + textBox_uyeadsoyad.Text + " adlı üye eklenmiştir.','" + DateTime.Now.ToShortTimeString() + "','" + DateTime.Now.ToShortDateString() + "')", Form_AnaEkran.baglanti);
                    ekle.ExecuteNonQuery();
                    MessageBox.Show("Üye kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form_AnaEkran.baglantikapa();
                    temizle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata ile karşılaşıldı. Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                if (maskedTextBox_telefon.Text == "(   )    -   ")
                {
                    maskedTextBox_telefon.BackColor = Color.Red;
                    maskedTextBox_telefon.ForeColor = Color.White;
                    maskedTextBox_telefon.Focus();
                }
                if (maskedTextBox_dogum.Text == "  .  .")
                {
                    maskedTextBox_dogum.BackColor = Color.Red;
                    maskedTextBox_dogum.ForeColor = Color.White;
                    maskedTextBox_dogum.Focus();
                }
                if (textBox_uyeadsoyad.Text == "")
                {
                    textBox_uyeadsoyad.BackColor = Color.Red;
                    textBox_uyeadsoyad.ForeColor = Color.White;
                    textBox_uyeadsoyad.Focus();
                }
                if (maskedTextBox_tcno.Text == "")
                {
                    maskedTextBox_tcno.BackColor = Color.Red;
                    maskedTextBox_tcno.ForeColor = Color.White;
                    maskedTextBox_tcno.Focus();
                }
                MessageBox.Show("Lütfen kırmızı ile işaretlenmiş olan alanları boş bırakmayınız.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void temizle()
        {
            textBox_uyeadsoyad.Text = "";
            maskedTextBox_dogum.Text = "";
            maskedTextBox_telefon.Text = "";
            maskedTextBox_tcno.Text = "";
            maskedTextBox_telefon.BackColor = Color.White;
            maskedTextBox_telefon.ForeColor = Color.Black;
            maskedTextBox_dogum.BackColor = Color.White;
            maskedTextBox_dogum.ForeColor = Color.Black;
            textBox_uyeadsoyad.BackColor = Color.White;
            textBox_uyeadsoyad.ForeColor = Color.Black;
            maskedTextBox_tcno.BackColor = Color.White;
            maskedTextBox_tcno.ForeColor = Color.Black;
        }
    }
}