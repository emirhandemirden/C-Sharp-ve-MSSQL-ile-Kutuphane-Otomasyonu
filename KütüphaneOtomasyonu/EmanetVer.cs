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
    public partial class EmanetVer : Form
    {
        public EmanetVer()
        {
            InitializeComponent();
        }

        private void EmanetVer_Load(object sender, EventArgs e)
        {
            kitaplarTableAdapter.Fill(kitaplarDataSet.Kitaplar);
            DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
            maskedTextBox_alim.Text = bugun.ToShortDateString();
            maskedTextBox_son.Text = bugun.AddMonths(1).ToShortDateString();
        }

        private void button_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void temizle()
        {
            comboBox_kitap.SelectedIndex = 0;
            maskedTextBox_uyetc.Text = "";
            textBox_uyead.Text = "";
            textBox_uyead.BackColor = Color.White;
            textBox_uyead.ForeColor = Color.Black;
            maskedTextBox_uyetc.BackColor = Color.White;
            maskedTextBox_uyetc.ForeColor = Color.Black;
            comboBox_kitap.BackColor = Color.White;
            comboBox_kitap.ForeColor = Color.Black;
        }

        private void maskedTextBox_uyetc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Form_AnaEkran.baglantiac();
                SqlCommand adal = new SqlCommand("SELECT * FROM Uyeler WHERE uye_tc='" + maskedTextBox_uyetc.Text + "'", Form_AnaEkran.baglanti);
                SqlDataReader oku = adal.ExecuteReader();
                if (oku.Read()) textBox_uyead.Text = oku["uye_ad"].ToString();
                oku.Close();
                Form_AnaEkran.baglantikapa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata ile karşılaşıldı. Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            if (comboBox_kitap.Text != "" && textBox_uyead.Text != "" && maskedTextBox_uyetc.Text != "")
            {
                try
                {
                    Form_AnaEkran.baglantiac();
                    SqlCommand ekle = new SqlCommand("INSERT INTO Emanetler (emanet_kitap,emanet_uyetc,emanet_uye,emanet_alım,emanet_son,emanet_say)VALUES('" + comboBox_kitap.Text + "','" + maskedTextBox_uyetc.Text + "','" + textBox_uyead.Text + "','" + maskedTextBox_alim.Text + "','" + maskedTextBox_son.Text + "','0')", Form_AnaEkran.baglanti);
                    ekle.ExecuteNonQuery();
                    ekle = new SqlCommand("INSERT INTO EmanetGecmisleri (gecmis_acıklama,gecmis_detay,gecmis_saat,gecmis_tarih)VALUES('Emanet verme işlemi.','" + textBox_uyead.Text + " adlı kullanıcıya, " + comboBox_kitap.Text + " adlı kitap emanet olarak verilmiştir.','" + DateTime.Now.ToShortTimeString() + "','" + DateTime.Now.ToShortDateString() + "')",Form_AnaEkran.baglanti);
                    ekle.ExecuteNonQuery();
                    MessageBox.Show("Emanet verildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if(textBox_uyead.Text == "")
                {
                    textBox_uyead.BackColor = Color.Red;
                    textBox_uyead.ForeColor = Color.White;
                    textBox_uyead.Focus();
                }
                if(maskedTextBox_uyetc.Text == "")
                {
                    maskedTextBox_uyetc.BackColor = Color.Red;
                    maskedTextBox_uyetc.ForeColor = Color.White;
                    maskedTextBox_uyetc.Focus();
                }
                if (comboBox_kitap.Text == "")
                {
                    comboBox_kitap.BackColor = Color.Red;
                    comboBox_kitap.ForeColor = Color.White;
                    comboBox_kitap.Focus();
                }
                MessageBox.Show("Lütfen kırmızı ile işaretlenmiş olan alanları boş bırakmayınız.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
