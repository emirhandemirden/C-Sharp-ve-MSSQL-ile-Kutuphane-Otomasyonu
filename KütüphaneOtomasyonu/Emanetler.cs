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
    public partial class Emanetler : Form
    {
        public Emanetler()
        {
            InitializeComponent();
        }

        int secilisatir = 0;
        public static DataRow satir;

        private void Emanetler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'uyelerDataSet.Uyeler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.uyelerTableAdapter.Fill(this.uyelerDataSet.Uyeler);
            emanetlerTableAdapter.Fill(emanetlerDataSet.Emanetler);
        }

        private void kayıtlıÜyeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmanetVer emanetVer = new EmanetVer();
            emanetVer.ShowDialog();
            emanetlerTableAdapter.Fill(emanetlerDataSet.Emanetler);
        }

        private void yeniÜyeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UyeEkle uyeEkle = new UyeEkle();
            uyeEkle.ShowDialog();
        }

        private void emanetAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // seçili satırı alıyoruz.
            secilisatir = gridView1.FocusedRowHandle;
            // seçili satırın bilgilerini alıyoruz.
            satir = gridView1.GetDataRow(secilisatir);
            // emaneti müşteriden alırken bilgileri ile beraber bir onay penceresi gösteriyoruz.
            DialogResult cevap = MessageBox.Show(satir["emanet_id"].ToString() + " numaralı emaneti alıyorsunuz, onaylıyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            // onay penceresinde 'evet' e tıklanırsa emaneti müşteriden alacağız.
            if (DialogResult.Yes == cevap)
            {
                try
                {
                    Form_AnaEkran.baglantiac();
                    // Emaneti verilen emanetlerden siliyoruz.
                    SqlCommand al = new SqlCommand("DELETE FROM Emanetler WHERE emanet_id='" + satir["emanet_id"].ToString() + "'", Form_AnaEkran.baglanti);
                    al.ExecuteNonQuery();
                    // Bilgisini geçmişlere ekliyoruz.
                    SqlCommand ekle = new SqlCommand("INSERT INTO EmanetGecmisleri (gecmis_acıklama,gecmis_detay,gecmis_saat,gecmis_tarih)VALUES('Emanet alma işlemi.','" + satir["emanet_uye"].ToString() + " adlı kullanıcıdan, " + satir["emanet_kitap"].ToString() + " adlı kitap alınmıştır.','" + DateTime.Now.ToShortTimeString() + "','" + DateTime.Now.ToShortDateString() + "')", Form_AnaEkran.baglanti);
                    ekle.ExecuteNonQuery();
                    Form_AnaEkran.baglantikapa();
                    MessageBox.Show("Emanet alındı.", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Bir hata ile karşılaşıldı.\nHata:" + hata.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            emanetlerTableAdapter.Fill(emanetlerDataSet.Emanetler);
        }

        private void süresiniUzatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // seçili satırı alıyoruz.
            secilisatir = gridView1.FocusedRowHandle;
            // seçili satırın bilgilerini alıyoruz.
            satir = gridView1.GetDataRow(secilisatir);
            // bir emanet en fazla  kere uzatılabilir bu sebepten dolayı 3 kere uzatılıp uzatılmadığını kontrol ediyoruz.
            if (satir["emanet_say"].ToString() != "3")
            {
                // süre uzatma onay penceresini görüntülüyoruz.
                DialogResult cevap = MessageBox.Show(satir["emanet_id"].ToString() + " numaralı emanetin süresini uzatıyorsunuz, onaylıyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                // Eğer uzatma işlemi onaylanırsa uzatma işlemine geçiyoruz.
                if (DialogResult.Yes == cevap)
                {
                    try
                    {
                        Form_AnaEkran.baglantiac();
                        // son teslim tarihini alıyoruz.
                        DateTime son = DateTime.Parse(satir["emanet_son"].ToString());
                        // ve 1 ay uzatıyoruz.
                        DateTime yeni_son = son.AddMonths(1);
                        // yeni bilgilerimiz ile güncelliyoruz aynı zamanda emanet uzatma hakkının kullanımını da arttırıyoruz.
                        SqlCommand guncelle = new SqlCommand("UPDATE Emanetler SET emanet_say='" + (int.Parse(satir["emanet_say"].ToString()) + 1) + "', emanet_son='" + yeni_son.ToShortDateString() + "' WHERE emanet_id='" + satir["emanet_id"].ToString() + "'", Form_AnaEkran.baglanti);
                        guncelle.ExecuteNonQuery();
                        // Geçmişler tablosuna işlemi yazıyoruz.
                        SqlCommand ekle = new SqlCommand("INSERT INTO EmanetGecmisleri (gecmis_acıklama,gecmis_detay,gecmis_saat,gecmis_tarih)VALUES('Emanet süre uzatma işlemi.','" + satir["emanet_uye"].ToString() + " adlı kullanıcının, " + satir["emanet_kitap"].ToString() + " adlı kitabının süresini 1 ay uzatılmıştır.','" + DateTime.Now.ToShortTimeString() + "','" + DateTime.Now.ToShortDateString() + "')", Form_AnaEkran.baglanti);
                        ekle.ExecuteNonQuery();
                        Form_AnaEkran.baglantikapa();
                        MessageBox.Show("Emanet süresi uzatıldı.", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("Bir hata ile karşılaşıldı.\nHata:" + hata.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else { MessageBox.Show("Emanet süre uzatma hakkı kalmamıştır.", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            emanetlerTableAdapter.Fill(emanetlerDataSet.Emanetler);
        }

        private void emanetİptalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // seçili satırı alıyoruz.
            secilisatir = gridView1.FocusedRowHandle;
            // seçili satırın bilgilerini alıyoruz.
            satir = gridView1.GetDataRow(secilisatir);
            // iptal işlemi için onay pencersini gösteriyoruz.
            DialogResult cevap = MessageBox.Show(satir["emanet_id"].ToString() + " numaralı emaneti iptal etmek istediğinize emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            // onay alırsak iptal işlemine başlıyoruz.
            if (DialogResult.Yes == cevap)
            {
                try
                {
                    Form_AnaEkran.baglantiac();
                    // iptal işlemi için silme komutumuzu yazıyoruz.
                    SqlCommand iptal = new SqlCommand("DELETE FROM Emanetler WHERE emanet_id='" + satir["emanet_id"].ToString() + "'", Form_AnaEkran.baglanti);
                    iptal.ExecuteNonQuery();
                    // Geçmişlere tablosuna işlemi yazıyoruz.
                    SqlCommand ekle = new SqlCommand("INSERT INTO EmanetGecmisleri (gecmis_acıklama,gecmis_detay,gecmis_saat,gecmis_tarih)VALUES('Emanet iptal işlemi.','" + satir["emanet_uye"].ToString() + " adlı kullanıcının, " + satir["emanet_kitap"].ToString() + " adlı emanet kitabı iptal edilmiştir.','" + DateTime.Now.ToShortTimeString() + "','" + DateTime.Now.ToShortDateString() + "')", Form_AnaEkran.baglanti);
                    ekle.ExecuteNonQuery();
                    Form_AnaEkran.baglantikapa();
                    MessageBox.Show("Emanet iptal edildi.", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Bir hata ile karşılaşıldı.\nHata:" + hata.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            emanetlerTableAdapter.Fill(emanetlerDataSet.Emanetler);
        }

        private void emanetGeçmişleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmanetGecmisleri emanetGecmisleri = new EmanetGecmisleri();
            emanetGecmisleri.ShowDialog();
        }

        private void chk1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk1.Checked == true)
            {
                cmb1.Enabled = true;
                cmb1.Focus();
            }
            else if (chk1.Checked == false)
            {
                cmb1.Text = "";
                cmb1.Enabled = false;
            }
        }

        private void chk2_CheckedChanged(object sender, EventArgs e)
        {
            if (chk2.Checked == true)
            {
                txt2.Enabled = true;
                txt2.Focus();
            }
            else if (chk2.Checked == false)
            {
                txt2.Text = "";
                txt2.Enabled = false;
            }
        }

        private void chk3_CheckedChanged(object sender, EventArgs e)
        {
            if (chk3.Checked == true)
            {
                txt3.Enabled = true;
                txt3.Focus();
            }
            else if (chk3.Checked == false)
            {
                txt3.Text = "";
                txt3.Enabled = false;
            }
        }

        private void rad1_CheckedChanged(object sender, EventArgs e)
        {
            lblArananalan.Text = "Kitap Adı:";
            txtAranan.Focus();
            txtAranan.Text = "";
        }

        private void Rad2_CheckedChanged(object sender, EventArgs e)
        {
            lblArananalan.Text = "Üye TC No:";
            txtAranan.Focus();
            txtAranan.Text = "";
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            KayitAra();
        }

        private void txtAranan_TextChanged(object sender, EventArgs e)
        {
            HizliAra();
        }

        public void HizliAra()
        {
            try
            {
                Form_AnaEkran.baglantiac();
                DataSet ds = new DataSet();
                string SorguTumKayitlar = "select * from Emanetler";
                string Sorgu1baslayan = "Select * From Emanetler where emanet_kitap Like'" + txtAranan.Text + "%'";
                string Sorgu1biten = "Select * From Emanetler where emanet_kitap Like'%" + txtAranan.Text + "'";
                string Sorgu1iceren = "Select * From Emanetler where emanet_kitap Like'%" + txtAranan.Text + "%'";

                string Sorgu2baslayan = "Select * From Emanetler where emanet_uyetc Like'" + txtAranan.Text + "%'";
                string Sorgu2biten = "Select * From Emanetler where emanet_uyetc Like'%" + txtAranan.Text + "'";
                string Sorgu2ceren = "Select * From Emanetler where emanet_uyetc Like'%" + txtAranan.Text + "%'";


                if (cmbAramaTuru.Text == "İle Başlayan")
                {
                    if (rad1.Checked)
                        SorguTumKayitlar = Sorgu1baslayan;
                    else
                        SorguTumKayitlar = Sorgu2baslayan;
                }
                else if (cmbAramaTuru.Text == "İle Biten")
                {
                    if (rad1.Checked)
                        SorguTumKayitlar = Sorgu1biten;
                    else
                        SorguTumKayitlar = Sorgu2biten;
                }
                else if (cmbAramaTuru.Text == "İçeren")
                {
                    if (rad1.Checked)
                        SorguTumKayitlar = Sorgu1iceren;
                    else
                        SorguTumKayitlar = Sorgu2ceren;
                }

                SqlDataAdapter da = new SqlDataAdapter(SorguTumKayitlar, Form_AnaEkran.baglanti);
                da.Fill(ds, "Emanetler");
                gridControl1.DataSource = ds.Tables["Emanetler"];
                Form_AnaEkran.baglantikapa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata ile karşılaşıldı. Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void KayitAra()
        {
            try
            {
                Form_AnaEkran.baglantiac();
                DataSet ds = new DataSet();
                string SorguTumKayitlar = "select * from Emanetler";
                string Sorgu1 = "Select * From Emanetler where emanet_uye='" + cmb1.Text + "'";
                string Sorgu2 = "Select * From Emanetler where emanet_alım='" + txt2.Text + "'";
                string Sorgu3 = "select * from Emanetler where emanet_son='" + txt3.Text + "'";

                string Sorgu12 = "Select * From Emanetler where emanet_uye='" + cmb1.Text + "' And emanet_alım='" + txt2.Text + "'";
                string Sorgu13 = "Select * From Emanetler where emanet_uye='" + cmb1.Text + "' And emanet_son='" + txt3.Text + "'";
                string Sorgu23 = "Select * From Emanetler where emanet_alım='" + txt2.Text + "' And emanet_son='" + txt3.Text + "'";

                string Sorgu123 = "Select * From Emanetler where emanet_uye='" + cmb1.Text + "' And emanet_alım='" + txt2.Text + "' And emanet_son='" + txt3.Text + "'";

                if (chk1.Checked && chk2.Checked && chk3.Checked)
                    SorguTumKayitlar = Sorgu123;
                else if (chk2.Checked && chk3.Checked)
                    SorguTumKayitlar = Sorgu23;
                else if (chk1.Checked && chk3.Checked)
                    SorguTumKayitlar = Sorgu13;
                else if (chk1.Checked && chk2.Checked)
                    SorguTumKayitlar = Sorgu12;
                else if (chk1.Checked)
                    SorguTumKayitlar = Sorgu1;
                else if (chk2.Checked)
                    SorguTumKayitlar = Sorgu2;
                else if (chk3.Checked)
                    SorguTumKayitlar = Sorgu3;


                SqlDataAdapter da = new SqlDataAdapter(SorguTumKayitlar, Form_AnaEkran.baglanti);
                da.Fill(ds, "Emanetler");
                gridControl1.DataSource = ds.Tables["Emanetler"];
                Form_AnaEkran.baglantikapa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata ile karşılaşıldı. Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
