using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KütüphaneOtomasyonu
{
    public partial class Kitaplar : Form
    {
        public Kitaplar()
        {
            InitializeComponent();
        }

        int secilisatir = 0;
        public static DataRow satir;

        private void kitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapEkle kitapEkle = new KitapEkle();
            kitapEkle.ShowDialog();
            kitaplarTableAdapter.Fill(kitaplarDataSet.Kitaplar);
        }

        private void kitapSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            secilisatir = gridView1.FocusedRowHandle;
            satir = gridView1.GetDataRow(secilisatir);
            KitapSil kitapSil = new KitapSil();
            kitapSil.ShowDialog();
            kitaplarTableAdapter.Fill(kitaplarDataSet.Kitaplar);
        }

        private void kitapGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            secilisatir = gridView1.FocusedRowHandle;
            satir = gridView1.GetDataRow(secilisatir);
            KitapGuncelle kitapGuncelle = new KitapGuncelle();
            kitapGuncelle.ShowDialog();
            kitaplarTableAdapter.Fill(kitaplarDataSet.Kitaplar);
        }

        private void Kitaplar_Load(object sender, EventArgs e)
        {
            kitaplarTableAdapter.Fill(kitaplarDataSet.Kitaplar);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            KitapGecmisleri kitapGecmisleri = new KitapGecmisleri();
            kitapGecmisleri.ShowDialog();
        }

        private void button_birebirara_Click(object sender, EventArgs e)
        {
            KayitAra();
        }

        public void KayitAra()
        {
            try
            {
                Form_AnaEkran.baglantiac();
                DataSet ds = new DataSet();
                string SorguTumKayitlar = "select * from Kitaplar";
                string Sorgu1 = "Select * From Kitaplar where kitap_ad='" + txtkitapara.Text + "'";
                string Sorgu2 = "Select * From Kitaplar where kitap_yazar='" + txtyazarara.Text + "'";
                string Sorgu3 = "select * from Kitaplar where kitap_sayfasayısı='" + txtsayfasayisiara.Text + "'";

                string Sorgu12 = "Select * From Kitaplar where kitap_ad='" + txtkitapara.Text + "' And kitap_yazar='" + txtyazarara.Text + "'";
                string Sorgu13 = "Select * From Kitaplar where kitap_ad='" + txtkitapara.Text + "' And kitap_sayfasayısı='" + txtsayfasayisiara.Text + "'";
                string Sorgu23 = "Select * From Kitaplar where kitap_yazar='" + txtyazarara.Text + "' And kitap_sayfasayısı='" + txtsayfasayisiara.Text + "'";

                string Sorgu123 = "Select * From Kitaplar where kitap_ad='" + txtkitapara.Text + "' And kitap_yazar='" + txtyazarara.Text + "' And kitap_sayfasayısı='" + txtsayfasayisiara.Text + "'";

                if (chkKitap.Checked && chkYazar.Checked && chkSayfa.Checked)
                    SorguTumKayitlar = Sorgu123;
                else if (chkYazar.Checked && chkSayfa.Checked)
                    SorguTumKayitlar = Sorgu23;
                else if (chkKitap.Checked && chkSayfa.Checked)
                    SorguTumKayitlar = Sorgu13;
                else if (chkKitap.Checked && chkYazar.Checked)
                    SorguTumKayitlar = Sorgu12;
                else if (chkKitap.Checked)
                    SorguTumKayitlar = Sorgu1;
                else if (chkYazar.Checked)
                    SorguTumKayitlar = Sorgu2;
                else if (chkSayfa.Checked)
                    SorguTumKayitlar = Sorgu3;


                SqlDataAdapter da = new SqlDataAdapter(SorguTumKayitlar, Form_AnaEkran.baglanti);
                da.Fill(ds, "Kitaplar");
                gridControl1.DataSource = ds.Tables["Kitaplar"];
                Form_AnaEkran.baglantikapa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata ile karşılaşıldı. Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void chkKitap_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKitap.Checked == true)
            {
                txtkitapara.Enabled = true;
                txtkitapara.Focus();
            }
            else if (chkKitap.Checked == false)
            {
                txtkitapara.Text = "";
                txtkitapara.Enabled = false;
            }
        }

        private void chkYazar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkYazar.Checked == true)
            {
                txtyazarara.Enabled = true;
                txtyazarara.Focus();
            }
            else if (chkYazar.Checked == false)
            {
                txtyazarara.Text = "";
                txtyazarara.Enabled = false;
            }
        }

        private void chkSayfa_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSayfa.Checked == true)
            {
                txtsayfasayisiara.Enabled = true;
                txtsayfasayisiara.Focus();
            }
            else if (chkSayfa.Checked == false)
            {
                txtsayfasayisiara.Text = "";
                txtsayfasayisiara.Enabled = false;
            }
        }

        private void radKitap_CheckedChanged(object sender, EventArgs e)
        {
            lblArananalan.Text = "Kitap Adı:";
            txtAranan.Focus();
            txtAranan.Text = "";
        }

        private void RadBarkod_CheckedChanged(object sender, EventArgs e)
        {
            lblArananalan.Text = "Barkod Numarası";
            txtAranan.Focus();
            txtAranan.Text = "";
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
                string SorguTumKayitlar = "select * from Kitaplar";
                string Sorgu1baslayan = "Select * From Kitaplar where kitap_ad Like'" + txtAranan.Text + "%'";
                string Sorgu1biten = "Select * From Kitaplar where kitap_ad Like'%" + txtAranan.Text + "'";
                string Sorgu1iceren = "Select * From Kitaplar where kitap_ad Like'%" + txtAranan.Text + "%'";

                string Sorgu2baslayan = "Select * From Kitaplar where kitap_barkod Like'" + txtAranan.Text + "%'";
                string Sorgu2biten = "Select * From Kitaplar where kitap_barkod Like'%" + txtAranan.Text + "'";
                string Sorgu2ceren = "Select * From Kitaplar where kitap_barkod Like'%" + txtAranan.Text + "%'";


                if (cmbAramaTuru.Text == "İle Başlayan")
                {
                    if (radKitap.Checked)
                        SorguTumKayitlar = Sorgu1baslayan;
                    else
                        SorguTumKayitlar = Sorgu2baslayan;
                }
                else if (cmbAramaTuru.Text == "İle Biten")
                {
                    if (radKitap.Checked)
                        SorguTumKayitlar = Sorgu1biten;
                    else
                        SorguTumKayitlar = Sorgu2biten;
                }
                else if (cmbAramaTuru.Text == "İçeren")
                {
                    if (radKitap.Checked)
                        SorguTumKayitlar = Sorgu1iceren; 
                    else
                        SorguTumKayitlar = Sorgu2ceren;
                }

                SqlDataAdapter da = new SqlDataAdapter(SorguTumKayitlar, Form_AnaEkran.baglanti);
                da.Fill(ds, "Kitaplar");
                gridControl1.DataSource = ds.Tables["Kitaplar"];
                Form_AnaEkran.baglantikapa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata ile karşılaşıldı. Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
