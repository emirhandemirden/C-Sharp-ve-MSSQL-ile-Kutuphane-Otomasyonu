using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KütüphaneOtomasyonu
{
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KitaplarListesiRaporu kitaplarListesiRaporu = new KitaplarListesiRaporu();
            kitaplarListesiRaporu.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KitaplarListesiRaporuYazaraGore kitaplarListesiRaporuYazaraGore = new KitaplarListesiRaporuYazaraGore();
            kitaplarListesiRaporuYazaraGore.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UyelerListesiRaporu uyelerListesiRaporu = new UyelerListesiRaporu();
            uyelerListesiRaporu.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UyelerListesiRaporuTcyeGore uyelerListesiRaporuTcyeGore = new UyelerListesiRaporuTcyeGore();
            uyelerListesiRaporuTcyeGore.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            YazarlarListesiRaporu yazarlarListesiRaporu = new YazarlarListesiRaporu();
            yazarlarListesiRaporu.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            YazarlarListesiRaporuAdaGöre yazarlarListesiRaporuAdaGöre = new YazarlarListesiRaporuAdaGöre();
            yazarlarListesiRaporuAdaGöre.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EmanetlerListesiRaporu emanetlerListesiRaporu = new EmanetlerListesiRaporu();
            emanetlerListesiRaporu.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            EmanetListesiRaporuUyeyeGore emanetListesiRaporuUyeyeGore = new EmanetListesiRaporuUyeyeGore();
            emanetListesiRaporuUyeyeGore.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PersonellerListesiRaporu personellerListesiRaporu = new PersonellerListesiRaporu();
            personellerListesiRaporu.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PersonellerListesiRaporuAdaGore personellerListesiRaporuAdaGore = new PersonellerListesiRaporuAdaGore();
            personellerListesiRaporuAdaGore.ShowDialog();
        }
    }
}
