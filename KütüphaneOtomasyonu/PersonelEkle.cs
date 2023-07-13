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
    public partial class PersonelEkle : Form
    {
        public PersonelEkle()
        {
            InitializeComponent();
        }

        private void button_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
        
        private void temizle()
        {
            maskedTextBox_personeldogum.Text = "";
            maskedTextBox_personeltelefon.Text = "";
            maskedTextBox_personelyetki.Text = "";
            textBox_personeladsoyad.Text = "";
            maskedTextBox_personelyetki.BackColor = Color.White;
            maskedTextBox_personelyetki.ForeColor = Color.Black;
            maskedTextBox_personeltelefon.BackColor = Color.White;
            maskedTextBox_personeltelefon.ForeColor = Color.Black;
            maskedTextBox_personeldogum.BackColor = Color.White;
            maskedTextBox_personeldogum.ForeColor = Color.Black;
            textBox_personeladsoyad.BackColor = Color.White;
            textBox_personeladsoyad.ForeColor = Color.Black;
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            if (maskedTextBox_personelyetki.Text != "" && maskedTextBox_personeltelefon.Text != "(   )    -   " && maskedTextBox_personeldogum.Text != "  .  ." && textBox_personeladsoyad.Text != "")
            {
                try
                {
                    Form_AnaEkran.baglantiac();
                    SqlCommand ekle = new SqlCommand("INSERT INTO Personeller (personel_ad,personel_dogum,personel_telefon,personel_yetki)VALUES('" + textBox_personeladsoyad.Text + "','" + maskedTextBox_personeldogum.Text + "','" + maskedTextBox_personeltelefon.Text + "','" + maskedTextBox_personelyetki.Text + "')", Form_AnaEkran.baglanti);
                    ekle.ExecuteNonQuery();
                    ekle = new SqlCommand("INSERT INTO PersonelGecmisleri (gecmis_acıklama,gecmis_detay,gecmis_saat,gecmis_tarih)VALUES('Personel ekleme işlemi.','" + textBox_personeladsoyad.Text + " adlı personel eklenmiştir.','" + DateTime.Now.ToShortTimeString() + "','" + DateTime.Now.ToShortDateString() + "')", Form_AnaEkran.baglanti);
                    ekle.ExecuteNonQuery();
                    MessageBox.Show("Personel kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if(maskedTextBox_personelyetki.Text == "")
                {
                    maskedTextBox_personelyetki.BackColor = Color.Red;
                    maskedTextBox_personelyetki.ForeColor = Color.White;
                    maskedTextBox_personelyetki.Focus();
                }
                if (maskedTextBox_personeltelefon.Text == "(   )    -   ")
                {
                    maskedTextBox_personeltelefon.BackColor = Color.Red;
                    maskedTextBox_personeltelefon.ForeColor = Color.White;
                    maskedTextBox_personeltelefon.Focus();
                }
                if (maskedTextBox_personeldogum.Text == "  .  .")
                {
                    maskedTextBox_personeldogum.BackColor = Color.Red;
                    maskedTextBox_personeldogum.ForeColor = Color.White;
                    maskedTextBox_personeldogum.Focus();
                }
                if (textBox_personeladsoyad.Text == "")
                {
                    textBox_personeladsoyad.BackColor = Color.Red;
                    textBox_personeladsoyad.ForeColor = Color.White;
                    textBox_personeladsoyad.Focus();
                }
                MessageBox.Show("Lütfen kırmızı ile işaretlenmiş olan alanları boş bırakmayınız.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
