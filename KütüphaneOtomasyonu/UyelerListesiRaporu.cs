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
    public partial class UyelerListesiRaporu : Form
    {
        public UyelerListesiRaporu()
        {
            InitializeComponent();
        }

        private void UyelerListesiRaporu_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'uyelerDataSet.Uyeler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.uyelerTableAdapter.Fill(this.uyelerDataSet.Uyeler);

            this.reportViewer1.RefreshReport();
        }
    }
}
