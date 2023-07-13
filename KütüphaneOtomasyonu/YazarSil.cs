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
    public partial class YazarSil : Form
    {
        public YazarSil()
        {
            InitializeComponent();
        }

        private void YazarGetir()
        {
            label_yazarno.Text = Yazarlar.satir["yazar_id"].ToString();
            textBox_yazaradsoyad.Text = Yazarlar.satir["yazar_ad"].ToString();
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show(textBox_yazaradsoyad.Text + " adlı yazarı silmek istediğinize emin misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                try
                {
                    Form_AnaEkran.baglantiac();
                    SqlCommand sil = new SqlCommand("DELETE FROM Yazarlar WHERE yazar_id='" + Yazarlar.satir["yazar_id"].ToString() + "'", Form_AnaEkran.baglanti);
                    sil.ExecuteNonQuery();
                    SqlCommand ekle = new SqlCommand("INSERT INTO YazarGecmisleri (gecmis_acıklama,gecmis_detay,gecmis_saat,gecmis_tarih)VALUES('Yazar silme işlemi.','" + textBox_yazaradsoyad.Text + " adlı yazar silinmiştir.','" + DateTime.Now.ToShortTimeString() + "','" + DateTime.Now.ToShortDateString() + "')", Form_AnaEkran.baglanti);
                    ekle.ExecuteNonQuery();
                    Form_AnaEkran.baglantikapa();
                    MessageBox.Show("Yazar silindi.", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Bir hata ile karşılaşıldı.\nHata:" + hata.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void YazarSil_Load(object sender, EventArgs e)
        {
            YazarGetir();
        }
    }
}
