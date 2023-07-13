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
    public partial class PersonellerListesiRaporu : Form
    {
        public PersonellerListesiRaporu()
        {
            InitializeComponent();
        }

        private void PersonellerListesiRaporu_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personellerDataSet.Personeller' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personellerTableAdapter.Fill(this.personellerDataSet.Personeller);

            this.reportViewer1.RefreshReport();
        }
    }
}
