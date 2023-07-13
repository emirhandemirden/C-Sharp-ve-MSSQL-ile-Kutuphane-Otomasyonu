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
    public partial class UyeGuncelle : Form
    {
        public UyeGuncelle()
        {
            InitializeComponent();
        }

        private void UyeGetir()
        {
            label_uyeno.Text = Uyeler.satir["uye_id"].ToString();
            textBox_uyeadsoyad.Text = Uyeler.satir["uye_ad"].ToString();
            maskedTextBox_telefon.Text = Uyeler.satir["uye_telefon"].ToString();
            maskedTextBox_dogum.Text = Uyeler.satir["uye_dogum"].ToString();
            maskedTextBox_tcno.Text = Uyeler.satir["uye_tc"].ToString();
        }

        private void button_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void temizle()
        {
            UyeGetir();
            maskedTextBox_telefon.BackColor = Color.White;
            maskedTextBox_telefon.ForeColor = Color.Black;
            maskedTextBox_dogum.BackColor = Color.White;
            maskedTextBox_dogum.ForeColor = Color.Black;
            textBox_uyeadsoyad.BackColor = Color.White;
            textBox_uyeadsoyad.ForeColor = Color.Black;
            maskedTextBox_tcno.BackColor = Color.White;
            maskedTextBox_tcno.ForeColor = Color.Black;
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            if (maskedTextBox_telefon.Text != "(   )    -   " && maskedTextBox_dogum.Text != "  .  ." && textBox_uyeadsoyad.Text != "" && maskedTextBox_tcno.Text != "")
            {
                try
                {
                    Form_AnaEkran.baglantiac();
                    SqlCommand guncelle = new SqlCommand("UPDATE Uyeler SET uye_ad='" + textBox_uyeadsoyad.Text + "', uye_dogum='" + maskedTextBox_dogum.Text + "', uye_telefon='" + maskedTextBox_telefon.Text + "', uye_tc='" + maskedTextBox_tcno.Text + "' WHERE uye_id='" + label_uyeno.Text + "'", Form_AnaEkran.baglanti);
                    guncelle.ExecuteNonQuery();
                    SqlCommand ekle = new SqlCommand("INSERT INTO UyeGecmisleri (gecmis_acıklama,gecmis_detay,gecmis_saat,gecmis_tarih)VALUES('Üye güncelleme işlemi.','" + textBox_uyeadsoyad.Text + " adlı üye verileri güncellenmiştir.','" + DateTime.Now.ToShortTimeString() + "','" + DateTime.Now.ToShortDateString() + "')", Form_AnaEkran.baglanti);
                    ekle.ExecuteNonQuery();
                    MessageBox.Show("Başarıyla güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form_AnaEkran.baglantikapa();
                    Close();
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

        private void UyeGuncelle_Load(object sender, EventArgs e)
        {
            UyeGetir();
        }
    }
}