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
    public partial class KitapSil : Form
    {
        public KitapSil()
        {
            InitializeComponent();
        }

        private void KitapGetir()
        {
            label_kitapno.Text = Kitaplar.satir["kitap_id"].ToString();
            textBox_kitapad.Text = Kitaplar.satir["kitap_ad"].ToString();
            textBox_yazar.Text = Kitaplar.satir["kitap_yazar"].ToString();
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show(textBox_kitapad.Text + " adlı kitabı sileceksiniz! Onaylıyor musunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                try
                {
                    Form_AnaEkran.baglantiac();
                    SqlCommand sil = new SqlCommand("DELETE FROM Kitaplar WHERE kitap_id='" + Kitaplar.satir["kitap_id"].ToString() + "'", Form_AnaEkran.baglanti);
                    sil.ExecuteNonQuery();
                    SqlCommand ekle = new SqlCommand("INSERT INTO KitapGecmisleri (gecmis_acıklama,gecmis_detay,gecmis_saat,gecmis_tarih)VALUES('Kitap silme işlemi.','" + textBox_yazar.Text + " adlı yazarın " + textBox_kitapad.Text + " adlı eseri silinmiştir.','" + DateTime.Now.ToShortTimeString() + "','" + DateTime.Now.ToShortDateString() + "')", Form_AnaEkran.baglanti);
                    ekle.ExecuteNonQuery();
                    Form_AnaEkran.baglantikapa();
                    MessageBox.Show("Kitap silindi.", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (Exception hata) { MessageBox.Show("Bir hata ile karşılaşıldı.\nHata:" + hata.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void KitapSil_Load(object sender, EventArgs e)
        {
            KitapGetir();
        }
    }
}
