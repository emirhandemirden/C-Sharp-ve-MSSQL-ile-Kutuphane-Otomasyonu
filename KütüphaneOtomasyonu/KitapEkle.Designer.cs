namespace KütüphaneOtomasyonu
{
    partial class KitapEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapEkle));
            this.button_temizle = new System.Windows.Forms.Button();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.maskedTextBox_yayıntarihi = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_kitapad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextBox_sayfasayisi = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_barkod = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_rafno = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_dolapno = new System.Windows.Forms.MaskedTextBox();
            this.textBox_yazar = new System.Windows.Forms.ComboBox();
            this.yazarlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yazarlarDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yazarlarDataSet = new KütüphaneOtomasyonu.YazarlarDataSet();
            this.yazarlarTableAdapter = new KütüphaneOtomasyonu.YazarlarDataSetTableAdapters.YazarlarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.yazarlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazarlarDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazarlarDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button_temizle
            // 
            this.button_temizle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_temizle.Image = ((System.Drawing.Image)(resources.GetObject("button_temizle.Image")));
            this.button_temizle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_temizle.Location = new System.Drawing.Point(16, 254);
            this.button_temizle.Name = "button_temizle";
            this.button_temizle.Size = new System.Drawing.Size(128, 46);
            this.button_temizle.TabIndex = 9;
            this.button_temizle.Text = "Temizle";
            this.button_temizle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_temizle.UseVisualStyleBackColor = true;
            this.button_temizle.Click += new System.EventHandler(this.button_temizle_Click);
            // 
            // button_kaydet
            // 
            this.button_kaydet.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_kaydet.Image = ((System.Drawing.Image)(resources.GetObject("button_kaydet.Image")));
            this.button_kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_kaydet.Location = new System.Drawing.Point(281, 254);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(121, 46);
            this.button_kaydet.TabIndex = 8;
            this.button_kaydet.Text = "Kaydet";
            this.button_kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_kaydet.UseVisualStyleBackColor = true;
            this.button_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // maskedTextBox_yayıntarihi
            // 
            this.maskedTextBox_yayıntarihi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.maskedTextBox_yayıntarihi.Location = new System.Drawing.Point(214, 45);
            this.maskedTextBox_yayıntarihi.Mask = "00/00/0000";
            this.maskedTextBox_yayıntarihi.Name = "maskedTextBox_yayıntarihi";
            this.maskedTextBox_yayıntarihi.Size = new System.Drawing.Size(188, 27);
            this.maskedTextBox_yayıntarihi.TabIndex = 2;
            this.maskedTextBox_yayıntarihi.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.Location = new System.Drawing.Point(12, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 30);
            this.label5.TabIndex = 49;
            this.label5.Text = "Kitap Sayfa Sayısı:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.Location = new System.Drawing.Point(12, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 30);
            this.label4.TabIndex = 48;
            this.label4.Text = "Kitap Yazarı:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 30);
            this.label3.TabIndex = 47;
            this.label3.Text = "Kitap Yayın Tarihi:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_kitapad
            // 
            this.textBox_kitapad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_kitapad.Location = new System.Drawing.Point(214, 12);
            this.textBox_kitapad.Name = "textBox_kitapad";
            this.textBox_kitapad.Size = new System.Drawing.Size(188, 27);
            this.textBox_kitapad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 30);
            this.label2.TabIndex = 46;
            this.label2.Text = "Kitap Ad:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.Location = new System.Drawing.Point(12, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 30);
            this.label6.TabIndex = 51;
            this.label6.Text = "Kitap Barkod:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.Location = new System.Drawing.Point(12, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 30);
            this.label7.TabIndex = 53;
            this.label7.Text = "Kitap Raf No:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.Location = new System.Drawing.Point(12, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 30);
            this.label8.TabIndex = 55;
            this.label8.Text = "Kitap Dolap No:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maskedTextBox_sayfasayisi
            // 
            this.maskedTextBox_sayfasayisi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.maskedTextBox_sayfasayisi.Location = new System.Drawing.Point(214, 111);
            this.maskedTextBox_sayfasayisi.Mask = "00000";
            this.maskedTextBox_sayfasayisi.Name = "maskedTextBox_sayfasayisi";
            this.maskedTextBox_sayfasayisi.Size = new System.Drawing.Size(188, 27);
            this.maskedTextBox_sayfasayisi.TabIndex = 4;
            this.maskedTextBox_sayfasayisi.ValidatingType = typeof(int);
            // 
            // maskedTextBox_barkod
            // 
            this.maskedTextBox_barkod.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.maskedTextBox_barkod.Location = new System.Drawing.Point(214, 144);
            this.maskedTextBox_barkod.Mask = "0000000000000";
            this.maskedTextBox_barkod.Name = "maskedTextBox_barkod";
            this.maskedTextBox_barkod.Size = new System.Drawing.Size(188, 27);
            this.maskedTextBox_barkod.TabIndex = 5;
            this.maskedTextBox_barkod.ValidatingType = typeof(int);
            // 
            // maskedTextBox_rafno
            // 
            this.maskedTextBox_rafno.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.maskedTextBox_rafno.Location = new System.Drawing.Point(214, 177);
            this.maskedTextBox_rafno.Mask = "00000";
            this.maskedTextBox_rafno.Name = "maskedTextBox_rafno";
            this.maskedTextBox_rafno.Size = new System.Drawing.Size(188, 27);
            this.maskedTextBox_rafno.TabIndex = 6;
            this.maskedTextBox_rafno.ValidatingType = typeof(int);
            // 
            // maskedTextBox_dolapno
            // 
            this.maskedTextBox_dolapno.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.maskedTextBox_dolapno.Location = new System.Drawing.Point(214, 210);
            this.maskedTextBox_dolapno.Mask = "00000";
            this.maskedTextBox_dolapno.Name = "maskedTextBox_dolapno";
            this.maskedTextBox_dolapno.Size = new System.Drawing.Size(188, 27);
            this.maskedTextBox_dolapno.TabIndex = 7;
            this.maskedTextBox_dolapno.ValidatingType = typeof(int);
            // 
            // textBox_yazar
            // 
            this.textBox_yazar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_yazar.DataSource = this.yazarlarBindingSource;
            this.textBox_yazar.DisplayMember = "yazar_ad";
            this.textBox_yazar.FormattingEnabled = true;
            this.textBox_yazar.Location = new System.Drawing.Point(214, 78);
            this.textBox_yazar.Name = "textBox_yazar";
            this.textBox_yazar.Size = new System.Drawing.Size(188, 27);
            this.textBox_yazar.TabIndex = 3;
            this.textBox_yazar.ValueMember = "yazar_ad";
            // 
            // yazarlarBindingSource
            // 
            this.yazarlarBindingSource.DataMember = "Yazarlar";
            this.yazarlarBindingSource.DataSource = this.yazarlarDataSetBindingSource;
            // 
            // yazarlarDataSetBindingSource
            // 
            this.yazarlarDataSetBindingSource.DataSource = this.yazarlarDataSet;
            this.yazarlarDataSetBindingSource.Position = 0;
            // 
            // yazarlarDataSet
            // 
            this.yazarlarDataSet.DataSetName = "YazarlarDataSet";
            this.yazarlarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yazarlarTableAdapter
            // 
            this.yazarlarTableAdapter.ClearBeforeFill = true;
            // 
            // KitapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 312);
            this.Controls.Add(this.textBox_yazar);
            this.Controls.Add(this.maskedTextBox_dolapno);
            this.Controls.Add(this.maskedTextBox_rafno);
            this.Controls.Add(this.maskedTextBox_barkod);
            this.Controls.Add(this.maskedTextBox_sayfasayisi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_temizle);
            this.Controls.Add(this.button_kaydet);
            this.Controls.Add(this.maskedTextBox_yayıntarihi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_kitapad);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Montserrat", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "KitapEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kitap Ekle";
            this.Load += new System.EventHandler(this.KitapEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yazarlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazarlarDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazarlarDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_temizle;
        private System.Windows.Forms.Button button_kaydet;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_yayıntarihi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_kitapad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_sayfasayisi;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_barkod;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_rafno;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_dolapno;
        private System.Windows.Forms.ComboBox textBox_yazar;
        private System.Windows.Forms.BindingSource yazarlarDataSetBindingSource;
        private YazarlarDataSet yazarlarDataSet;
        private System.Windows.Forms.BindingSource yazarlarBindingSource;
        private YazarlarDataSetTableAdapters.YazarlarTableAdapter yazarlarTableAdapter;
    }
}