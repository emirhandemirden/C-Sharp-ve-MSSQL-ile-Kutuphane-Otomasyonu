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
    public partial class YazarlarListesiRaporu : Form
    {
        public YazarlarListesiRaporu()
        {
            InitializeComponent();
        }

        private void YazarlarListesiRaporu_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yazarlarDataSet.Yazarlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.yazarlarTableAdapter.Fill(this.yazarlarDataSet.Yazarlar);

            this.reportViewer1.RefreshReport();
        }
    }
}
