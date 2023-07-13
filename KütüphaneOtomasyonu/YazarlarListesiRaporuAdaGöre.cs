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
    public partial class YazarlarListesiRaporuAdaGöre : Form
    {
        public YazarlarListesiRaporuAdaGöre()
        {
            InitializeComponent();
        }

        private void YazarlarListesiRaporuAdaGöre_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yazarlarDataSet.Yazarlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.yazarlarTableAdapter.Fill(this.yazarlarDataSet.Yazarlar);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yazarlarBindingSource.Filter = "gecmis_acıklama='" + textBox1.Text + "'";
            this.reportViewer1.RefreshReport();
        }
    }
}
