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
    public partial class EmanetlerListesiRaporu : Form
    {
        public EmanetlerListesiRaporu()
        {
            InitializeComponent();
        }

        private void EmanetlerListesiRaporu_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'emanetlerDataSet.Emanetler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.emanetlerTableAdapter.Fill(this.emanetlerDataSet.Emanetler);

            this.reportViewer1.RefreshReport();
        }
    }
}
