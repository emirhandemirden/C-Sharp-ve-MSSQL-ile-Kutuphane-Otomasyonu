namespace KütüphaneOtomasyonu
{
    partial class Form_AnaEkran
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AnaEkran));
            this.button_kitap = new System.Windows.Forms.Button();
            this.button_uye = new System.Windows.Forms.Button();
            this.button_yazar = new System.Windows.Forms.Button();
            this.button_personel = new System.Windows.Forms.Button();
            this.button_rapor = new System.Windows.Forms.Button();
            this.button_emanet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblZaman = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTarih = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_kitap
            // 
            this.button_kitap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_kitap.Image = ((System.Drawing.Image)(resources.GetObject("button_kitap.Image")));
            this.button_kitap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_kitap.Location = new System.Drawing.Point(190, 104);
            this.button_kitap.Name = "button_kitap";
            this.button_kitap.Size = new System.Drawing.Size(118, 98);
            this.button_kitap.TabIndex = 0;
            this.button_kitap.Text = "Kitap Islemleri";
            this.button_kitap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_kitap.UseVisualStyleBackColor = true;
            this.button_kitap.Click += new System.EventHandler(this.button_kitap_Click);
            // 
            // button_uye
            // 
            this.button_uye.Image = ((System.Drawing.Image)(resources.GetObject("button_uye.Image")));
            this.button_uye.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_uye.Location = new System.Drawing.Point(333, 104);
            this.button_uye.Name = "button_uye";
            this.button_uye.Size = new System.Drawing.Size(118, 98);
            this.button_uye.TabIndex = 1;
            this.button_uye.Text = "Üye Islemleri";
            this.button_uye.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_uye.UseVisualStyleBackColor = true;
            this.button_uye.Click += new System.EventHandler(this.button_uye_Click);
            // 
            // button_yazar
            // 
            this.button_yazar.Image = ((System.Drawing.Image)(resources.GetObject("button_yazar.Image")));
            this.button_yazar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_yazar.Location = new System.Drawing.Point(476, 104);
            this.button_yazar.Name = "button_yazar";
            this.button_yazar.Size = new System.Drawing.Size(118, 98);
            this.button_yazar.TabIndex = 2;
            this.button_yazar.Text = "Yazar Islemleri";
            this.button_yazar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_yazar.UseVisualStyleBackColor = true;
            this.button_yazar.Click += new System.EventHandler(this.button_yazar_Click);
            // 
            // button_personel
            // 
            this.button_personel.Image = ((System.Drawing.Image)(resources.GetObject("button_personel.Image")));
            this.button_personel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_personel.Location = new System.Drawing.Point(333, 227);
            this.button_personel.Name = "button_personel";
            this.button_personel.Size = new System.Drawing.Size(118, 98);
            this.button_personel.TabIndex = 4;
            this.button_personel.Text = "Personel Islemleri";
            this.button_personel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_personel.UseVisualStyleBackColor = true;
            this.button_personel.Click += new System.EventHandler(this.button_personel_Click);
            // 
            // button_rapor
            // 
            this.button_rapor.Image = ((System.Drawing.Image)(resources.GetObject("button_rapor.Image")));
            this.button_rapor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_rapor.Location = new System.Drawing.Point(476, 227);
            this.button_rapor.Name = "button_rapor";
            this.button_rapor.Size = new System.Drawing.Size(118, 98);
            this.button_rapor.TabIndex = 5;
            this.button_rapor.Text = "Rapor Islemleri";
            this.button_rapor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_rapor.UseVisualStyleBackColor = true;
            this.button_rapor.Click += new System.EventHandler(this.button_rapor_Click);
            // 
            // button_emanet
            // 
            this.button_emanet.Image = ((System.Drawing.Image)(resources.GetObject("button_emanet.Image")));
            this.button_emanet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_emanet.Location = new System.Drawing.Point(190, 227);
            this.button_emanet.Name = "button_emanet";
            this.button_emanet.Size = new System.Drawing.Size(118, 98);
            this.button_emanet.TabIndex = 3;
            this.button_emanet.Text = "Emanet Islemleri";
            this.button_emanet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_emanet.UseVisualStyleBackColor = true;
            this.button_emanet.Click += new System.EventHandler(this.button_emanet_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 70);
            this.label1.TabIndex = 6;
            this.label1.Text = "Anasayfa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblZaman,
            this.lblTarih});
            this.statusStrip1.Location = new System.Drawing.Point(242, 372);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(300, 30);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblZaman
            // 
            this.lblZaman.Image = ((System.Drawing.Image)(resources.GetObject("lblZaman.Image")));
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(117, 25);
            this.lblZaman.Text = "Saat: 00.00";
            // 
            // lblTarih
            // 
            this.lblTarih.Image = ((System.Drawing.Image)(resources.GetObject("lblTarih.Image")));
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(166, 25);
            this.lblTarih.Text = "Tarih: 00.00.0000";
            // 
            // Form_AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_emanet);
            this.Controls.Add(this.button_rapor);
            this.Controls.Add(this.button_personel);
            this.Controls.Add(this.button_yazar);
            this.Controls.Add(this.button_uye);
            this.Controls.Add(this.button_kitap);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "Form_AnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Ekran";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_AnaEkran_FormClosed);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_kitap;
        private System.Windows.Forms.Button button_uye;
        private System.Windows.Forms.Button button_yazar;
        private System.Windows.Forms.Button button_personel;
        private System.Windows.Forms.Button button_rapor;
        private System.Windows.Forms.Button button_emanet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblZaman;
        private System.Windows.Forms.ToolStripStatusLabel lblTarih;
    }
}

