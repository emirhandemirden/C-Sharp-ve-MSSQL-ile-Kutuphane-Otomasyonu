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
    public partial class Yazarlar : Form
    {
        public Yazarlar()
        {
            InitializeComponent();
        }
        int secilisatir = 0;
        public static DataRow satir;

        private void yazarEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YazarEkle yazarEkle = new YazarEkle();
            yazarEkle.ShowDialog();
            yazarlarTableAdapter.Fill(yazarlarDataSet.Yazarlar);
        }

        private void yazarSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            secilisatir = gridView1.FocusedRowHandle;
            satir = gridView1.GetDataRow(secilisatir);
            YazarSil yazarSil = new YazarSil();
            yazarSil.ShowDialog();
            yazarlarTableAdapter.Fill(yazarlarDataSet.Yazarlar);
        }

        private void yazarGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            secilisatir = gridView1.FocusedRowHandle;
            satir = gridView1.GetDataRow(secilisatir);
            YazarGuncelle yazarGuncelle = new YazarGuncelle();
            yazarGuncelle.ShowDialog();
            yazarlarTableAdapter.Fill(yazarlarDataSet.Yazarlar);
        }

        private void Yazarlar_Load(object sender, EventArgs e)
        {
            yazarlarTableAdapter.Fill(yazarlarDataSet.Yazarlar);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            YazarGecmisleri yazarGecmisleri = new YazarGecmisleri();
            yazarGecmisleri.ShowDialog();
        }

        private void chk1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk1.Checked == true)
            {
                txt1.Enabled = true;
                txt1.Focus();
            }
            else if (chk1.Checked == false)
            {
                txt1.Text = "";
                txt1.Enabled = false;
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
            lblArananalan.Text = "Ad Soyad:";
            txtAranan.Focus();
            txtAranan.Text = "";
        }

        private void Rad2_CheckedChanged(object sender, EventArgs e)
        {
            lblArananalan.Text = "Hakkında:";
            txtAranan.Focus();
            txtAranan.Text = "";
        }

        public void HizliAra()
        {
            try
            {
                Form_AnaEkran.baglantiac();
                DataSet ds = new DataSet();
                string SorguTumKayitlar = "select * from Yazarlar";
                string Sorgu1baslayan = "Select * From Yazarlar where yazar_ad Like'" + txtAranan.Text + "%'";
                string Sorgu1biten = "Select * From Yazarlar where yazar_ad Like'%" + txtAranan.Text + "'";
                string Sorgu1iceren = "Select * From Yazarlar where yazar_ad Like'%" + txtAranan.Text + "%'";

                string Sorgu2baslayan = "Select * From Yazarlar where yazar_hakkında Like'" + txtAranan.Text + "%'";
                string Sorgu2biten = "Select * From Yazarlar where yazar_hakkında Like'%" + txtAranan.Text + "'";
                string Sorgu2ceren = "Select * From Yazarlar where yazar_hakkında Like'%" + txtAranan.Text + "%'";


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
                da.Fill(ds, "Yazarlar");
                gridControl1.DataSource = ds.Tables["Yazarlar"];
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
                string SorguTumKayitlar = "select * from Yazarlar";
                string Sorgu1 = "Select * From Yazarlar where yazar_ad='" + txt1.Text + "'";
                string Sorgu2 = "Select * From Yazarlar where yazar_dogum='" + txt2.Text + "'";
                string Sorgu3 = "select * from Yazarlar where yazar_kitapsayısı='" + txt3.Text + "'";

                string Sorgu12 = "Select * From Yazarlar where yazar_ad='" + txt1.Text + "' And yazar_dogum='" + txt2.Text + "'";
                string Sorgu13 = "Select * From Yazarlar where yazar_ad='" + txt1.Text + "' And yazar_kitapsayısı='" + txt3.Text + "'";
                string Sorgu23 = "Select * From Yazarlar where yazar_dogum='" + txt2.Text + "' And yazar_kitapsayısı='" + txt3.Text + "'";

                string Sorgu123 = "Select * From Yazarlar where yazar_ad='" + txt1.Text + "' And yazar_dogum='" + txt2.Text + "' And yazar_kitapsayısı='" + txt3.Text + "'";

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
                da.Fill(ds, "Yazarlar");
                gridControl1.DataSource = ds.Tables["Yazarlar"];
                Form_AnaEkran.baglantikapa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata ile karşılaşıldı. Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            KayitAra();
        }

        private void txtAranan_TextChanged(object sender, EventArgs e)
        {
            HizliAra();
        }
    }
}
