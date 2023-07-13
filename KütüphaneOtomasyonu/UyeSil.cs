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
    public partial class UyeSil : Form
    {
        public UyeSil()
        {
            InitializeComponent();
        }

        private void UyeGetir()
        {
            label_uyeno.Text = Uyeler.satir["uye_id"].ToString();
            maskedTextBox_tcno.Text = Uyeler.satir["uye_tc"].ToString();
            textBox_uyeadsoyad.Text = Uyeler.satir["uye_ad"].ToString();
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show(textBox_uyeadsoyad.Text + " adlı üyeyi silmek istediğinize emin misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                try
                {
                    Form_AnaEkran.baglantiac();
                    SqlCommand sil = new SqlCommand("DELETE FROM Uyeler WHERE uye_id='" + Uyeler.satir["uye_id"].ToString() + "'", Form_AnaEkran.baglanti);
                    sil.ExecuteNonQuery();
                    SqlCommand ekle = new SqlCommand("INSERT INTO UyeGecmisleri (gecmis_acıklama,gecmis_detay,gecmis_saat,gecmis_tarih)VALUES('Üye silme işlemi.','" + textBox_uyeadsoyad.Text + " adlı üye silinmiştir.','" + DateTime.Now.ToShortTimeString() + "','" + DateTime.Now.ToShortDateString() + "')", Form_AnaEkran.baglanti);
                    ekle.ExecuteNonQuery();
                    Form_AnaEkran.baglantikapa();
                    MessageBox.Show("Üye silindi.", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Bir hata ile karşılaşıldı.\nHata:" + hata.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UyeSil_Load(object sender, EventArgs e)
        {
            UyeGetir();
        }
    }
}
