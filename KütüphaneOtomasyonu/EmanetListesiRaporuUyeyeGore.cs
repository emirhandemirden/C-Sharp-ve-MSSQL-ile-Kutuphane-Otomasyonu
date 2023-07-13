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
    public partial class EmanetListesiRaporuUyeyeGore : Form
    {
        public EmanetListesiRaporuUyeyeGore()
        {
            InitializeComponent();
        }

        private void EmanetListesiRaporuUyeyeGore_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'emanetlerDataSet.Emanetler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.emanetlerTableAdapter.Fill(this.emanetlerDataSet.Emanetler);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            emanetlerBindingSource.Filter = "emanet_uye='" + textBox1.Text + "'";
            this.reportViewer1.RefreshReport();
        }
    }
}
