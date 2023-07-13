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
    public partial class YazarEkle : Form
    {
        public YazarEkle()
        {
            InitializeComponent();
        }
        string olum = "Hayatta";

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            if (maskedTextBox_kitapsayisi.Text != "" && maskedTextBox_dogum.Text != "  .  ." && richTextBox_yazarhakkında.Text != "" && textBox_yazaradsoyad.Text != "" && (maskedTextBox_olum.Text != "  .  ." || checkBox1.Checked))
            {
                try
                {
                    if (checkBox1.Checked) olum = "Hayatta";
                    else olum = maskedTextBox_olum.Text;
                    Form_AnaEkran.baglantiac();
                    SqlCommand ekle = new SqlCommand("INSERT INTO Yazarlar (yazar_ad,yazar_hakkında,yazar_dogum,yazar_olum,yazar_kitapsayısı)VALUES('" + textBox_yazaradsoyad.Text + "','" + richTextBox_yazarhakkında.Text + "','" + maskedTextBox_dogum.Text + "','" + olum + "','" + maskedTextBox_kitapsayisi.Text + "')", Form_AnaEkran.baglanti);
                    ekle.ExecuteNonQuery();
                    ekle = new SqlCommand("INSERT INTO YazarGecmisleri (gecmis_acıklama,gecmis_detay,gecmis_saat,gecmis_tarih)VALUES('Yazar ekleme işlemi.','" + textBox_yazaradsoyad.Text + " adlı yazar eklenmiştir.','" + DateTime.Now.ToShortTimeString() + "','" + DateTime.Now.ToShortDateString() + "')", Form_AnaEkran.baglanti);
                    ekle.ExecuteNonQuery();
                    MessageBox.Show("Yazar kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (maskedTextBox_kitapsayisi.Text == "")
                {
                    maskedTextBox_kitapsayisi.BackColor = Color.Red;
                    maskedTextBox_kitapsayisi.ForeColor = Color.White;
                    maskedTextBox_kitapsayisi.Focus();
                }
                if (maskedTextBox_dogum.Text == "  .  .")
                {
                    maskedTextBox_dogum.BackColor = Color.Red;
                    maskedTextBox_dogum.ForeColor = Color.White;
                    maskedTextBox_dogum.Focus();
                }
                if (maskedTextBox_olum.Text == "  .  ." && maskedTextBox_olum.Enabled)
                {
                    maskedTextBox_olum.BackColor = Color.Red;
                    maskedTextBox_olum.ForeColor = Color.White;
                    maskedTextBox_olum.Focus();
                }
                if (richTextBox_yazarhakkında.Text == "")
                {
                    richTextBox_yazarhakkında.BackColor = Color.Red;
                    richTextBox_yazarhakkında.ForeColor = Color.White;
                    richTextBox_yazarhakkında.Focus();
                }
                if (textBox_yazaradsoyad.Text == "")
                {
                    textBox_yazaradsoyad.BackColor = Color.Red;
                    textBox_yazaradsoyad.ForeColor = Color.White;
                    textBox_yazaradsoyad.Focus();
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
            textBox_yazaradsoyad.Text = "";
            richTextBox_yazarhakkında.Text = "";
            maskedTextBox_dogum.Text = "";
            maskedTextBox_olum.Text = "";
            maskedTextBox_kitapsayisi.Text = "";
            maskedTextBox_kitapsayisi.BackColor = Color.White;
            maskedTextBox_kitapsayisi.ForeColor = Color.Black;
            maskedTextBox_dogum.BackColor = Color.White;
            maskedTextBox_dogum.ForeColor = Color.Black;
            maskedTextBox_olum.BackColor = Color.White;
            maskedTextBox_olum.ForeColor = Color.Black;
            richTextBox_yazarhakkında.BackColor = Color.White;
            richTextBox_yazarhakkında.ForeColor = Color.Black;
            textBox_yazaradsoyad.BackColor = Color.White;
            textBox_yazaradsoyad.ForeColor = Color.Black;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) maskedTextBox_olum.Enabled = false;
            else maskedTextBox_olum.Enabled = true;
        }
    }
}
