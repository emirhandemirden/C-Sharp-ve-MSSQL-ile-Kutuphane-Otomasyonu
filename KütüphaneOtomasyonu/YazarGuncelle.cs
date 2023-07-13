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
    public partial class YazarGuncelle : Form
    {
        public YazarGuncelle()
        {
            InitializeComponent();
        }
        string olum = "Hayatta";

        private void YazarGetir()
        {
            label_yazarno.Text = Yazarlar.satir["yazar_id"].ToString();
            textBox_yazaradsoyad.Text = Yazarlar.satir["yazar_ad"].ToString();
            richTextBox_yazarhakkında.Text = Yazarlar.satir["yazar_hakkında"].ToString();
            maskedTextBox_dogum.Text = Yazarlar.satir["yazar_dogum"].ToString();
            if (Yazarlar.satir["yazar_olum"].ToString() != "Hayatta")
            {
                maskedTextBox_olum.Text = Yazarlar.satir["yazar_olum"].ToString();
                maskedTextBox_olum.Enabled = true;
                checkBox1.Checked = false;
            }
            maskedTextBox_kitapsayisi.Text = Yazarlar.satir["yazar_kitapsayısı"].ToString();
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            if (maskedTextBox_kitapsayisi.Text != "" && maskedTextBox_dogum.Text != "  .  ." && richTextBox_yazarhakkında.Text != "" && textBox_yazaradsoyad.Text != "" && (maskedTextBox_olum.Text != "  .  ." || checkBox1.Checked))
            {
                try
                {
                    if (checkBox1.Checked) olum = "Hayatta";
                    else olum = maskedTextBox_olum.Text;
                    Form_AnaEkran.baglantiac();
                    SqlCommand guncelle = new SqlCommand("UPDATE Yazarlar SET yazar_ad='" + textBox_yazaradsoyad.Text + "', yazar_hakkında='" + richTextBox_yazarhakkında.Text + "', yazar_dogum='" + maskedTextBox_dogum.Text + "', yazar_olum='" + olum + "', yazar_kitapsayısı='" + maskedTextBox_kitapsayisi.Text + "' WHERE yazar_id='" + label_yazarno.Text + "'", Form_AnaEkran.baglanti);
                    guncelle.ExecuteNonQuery();
                    SqlCommand ekle = new SqlCommand("INSERT INTO YazarGecmisleri (gecmis_acıklama,gecmis_detay,gecmis_saat,gecmis_tarih)VALUES('Yazar güncelleme işlemi.','" + textBox_yazaradsoyad.Text + " adlı yazar verileri güncellenmiştir.','" + DateTime.Now.ToShortTimeString() + "','" + DateTime.Now.ToShortDateString() + "')", Form_AnaEkran.baglanti);
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
            YazarGetir();
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

        private void YazarGuncelle_Load(object sender, EventArgs e)
        {
            YazarGetir();
        }
    }
}
