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
    public partial class KitapEkle : Form
    {
        public KitapEkle()
        {
            InitializeComponent();
        }

        private void button_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void temizle()
        {
            maskedTextBox_barkod.Text = "";
            maskedTextBox_dolapno.Text = "";
            maskedTextBox_rafno.Text = "";
            maskedTextBox_sayfasayisi.Text = "";
            maskedTextBox_yayıntarihi.Text = "";
            textBox_kitapad.Text = "";
            textBox_yazar.SelectedIndex = 0;
            maskedTextBox_dolapno.BackColor = Color.White;
            maskedTextBox_dolapno.ForeColor = Color.Black;
            maskedTextBox_rafno.BackColor = Color.White;
            maskedTextBox_rafno.ForeColor = Color.Black;
            maskedTextBox_barkod.BackColor = Color.White;
            maskedTextBox_barkod.ForeColor = Color.Black;
            maskedTextBox_sayfasayisi.BackColor = Color.White;
            maskedTextBox_sayfasayisi.ForeColor = Color.Black;
            textBox_yazar.BackColor = Color.White;
            textBox_yazar.ForeColor = Color.Black;
            maskedTextBox_yayıntarihi.BackColor = Color.White;
            maskedTextBox_yayıntarihi.ForeColor = Color.Black;
            textBox_kitapad.BackColor = Color.White;
            textBox_kitapad.ForeColor = Color.Black;
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            if (textBox_kitapad.Text != "" && maskedTextBox_yayıntarihi.Text != "  .  ." && textBox_yazar.Text != "" && maskedTextBox_sayfasayisi.Text != "" && maskedTextBox_barkod.Text != "" && maskedTextBox_rafno.Text != "" && maskedTextBox_dolapno.Text != "")
            {
                try
                {
                    Form_AnaEkran.baglantiac();
                    SqlCommand ekle = new SqlCommand("INSERT INTO Kitaplar (kitap_ad,kitap_yayıntarihi,kitap_yazar,kitap_sayfasayısı,kitap_barkod,kitap_rafno,kitap_dolapno)VALUES('" + textBox_kitapad.Text + "','" + maskedTextBox_yayıntarihi.Text + "','" + textBox_yazar.Text + "','" + maskedTextBox_sayfasayisi.Text + "','" + maskedTextBox_barkod.Text + "','" + maskedTextBox_rafno.Text + "','" + maskedTextBox_dolapno.Text + "')", Form_AnaEkran.baglanti);
                    ekle.ExecuteNonQuery();
                    ekle = new SqlCommand("INSERT INTO KitapGecmisleri (gecmis_acıklama,gecmis_detay,gecmis_saat,gecmis_tarih)VALUES('Kitap ekleme işlemi.','" + maskedTextBox_dolapno.Text + " nolu dolabın " + maskedTextBox_rafno.Text + " nolu rafına " + textBox_kitapad.Text + " adlı kitap eklenmiştir.','" + DateTime.Now.ToShortTimeString() + "','" + DateTime.Now.ToShortDateString() + "')", Form_AnaEkran.baglanti);
                    ekle.ExecuteNonQuery();
                    MessageBox.Show("Kitap kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if(maskedTextBox_dolapno.Text == "")
                {
                    maskedTextBox_dolapno.BackColor = Color.Red;
                    maskedTextBox_dolapno.ForeColor = Color.White;
                    maskedTextBox_dolapno.Focus();
                }
                if (maskedTextBox_rafno.Text == "")
                {
                    maskedTextBox_rafno.BackColor = Color.Red;
                    maskedTextBox_rafno.ForeColor = Color.White;
                    maskedTextBox_rafno.Focus();
                }
                if (maskedTextBox_barkod.Text == "")
                {
                    maskedTextBox_barkod.BackColor = Color.Red;
                    maskedTextBox_barkod.ForeColor = Color.White;
                    maskedTextBox_barkod.Focus();
                }
                if (maskedTextBox_sayfasayisi.Text == "")
                {
                    maskedTextBox_sayfasayisi.BackColor = Color.Red;
                    maskedTextBox_sayfasayisi.ForeColor = Color.White;
                    maskedTextBox_sayfasayisi.Focus();
                }
                if (textBox_yazar.Text == "")
                {
                    textBox_yazar.BackColor = Color.Red;
                    textBox_yazar.ForeColor = Color.White;
                    textBox_yazar.Focus();
                }
                if (maskedTextBox_yayıntarihi.Text == "  .  .")
                {
                    maskedTextBox_yayıntarihi.BackColor = Color.Red;
                    maskedTextBox_yayıntarihi.ForeColor = Color.White;
                    maskedTextBox_yayıntarihi.Focus();
                }
                if (textBox_kitapad.Text == "")
                {
                    textBox_kitapad.BackColor = Color.Red;
                    textBox_kitapad.ForeColor = Color.White;
                    textBox_kitapad.Focus();
                }
                MessageBox.Show("Lütfen kırmızı ile işaretlenmiş olan alanları boş bırakmayınız.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void KitapEkle_Load(object sender, EventArgs e)
        {
            yazarlarTableAdapter.Fill(yazarlarDataSet.Yazarlar);
        }
    }
}
