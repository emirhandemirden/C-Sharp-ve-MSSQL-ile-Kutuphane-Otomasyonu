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
    public partial class PersonelSil : Form
    {
        public PersonelSil()
        {
            InitializeComponent();
        }

        private void PersonelGetir()
        {
            label_personelno.Text = Personeller.satir["personel_id"].ToString();
            textBox_personeladsoyad.Text = Personeller.satir["personel_ad"].ToString();
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show(textBox_personeladsoyad.Text + " adlı personeli silmek istediğinize emin misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                try
                {
                    Form_AnaEkran.baglantiac();
                    SqlCommand sil = new SqlCommand("DELETE FROM Personeller WHERE personel_id='" + Personeller.satir["personel_id"].ToString() + "'", Form_AnaEkran.baglanti);
                    sil.ExecuteNonQuery();
                    SqlCommand ekle = new SqlCommand("INSERT INTO PersonelGecmisleri (gecmis_acıklama,gecmis_detay,gecmis_saat,gecmis_tarih)VALUES('Personel silme işlemi.','" + textBox_personeladsoyad.Text + " adlı personel silinmiştir.','" + DateTime.Now.ToShortTimeString() + "','" + DateTime.Now.ToShortDateString() + "')", Form_AnaEkran.baglanti);
                    ekle.ExecuteNonQuery();
                    Form_AnaEkran.baglantikapa();
                    MessageBox.Show("Personel silindi.", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Bir hata ile karşılaşıldı.\nHata:" + hata.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PersonelSil_Load(object sender, EventArgs e)
        {
            PersonelGetir();
        }
    }
}
