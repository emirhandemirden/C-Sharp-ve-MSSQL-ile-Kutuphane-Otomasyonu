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
    public partial class KitaplarListesiRaporuYazaraGore : Form
    {
        public KitaplarListesiRaporuYazaraGore()
        {
            InitializeComponent();
        }

        private void KitaplarListesiRaporuYazaraGore_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kitaplarDataSet.Kitaplar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kitaplarTableAdapter.Fill(this.kitaplarDataSet.Kitaplar);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kitaplarBindingSource.Filter = "kitap_yazar='" + textBox1.Text + "'";
            this.reportViewer1.RefreshReport();
        }
    }
}
