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
    public partial class UyelerListesiRaporuTcyeGore : Form
    {
        public UyelerListesiRaporuTcyeGore()
        {
            InitializeComponent();
        }

        private void UyelerListesiRaporuTcyeGore_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'uyelerDataSet.Uyeler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.uyelerTableAdapter.Fill(this.uyelerDataSet.Uyeler);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uyelerBindingSource.Filter = "gecmis_acıklama='" + textBox1.Text + "'";
            this.reportViewer1.RefreshReport();
        }
    }
}
