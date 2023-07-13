namespace KütüphaneOtomasyonu
{
    partial class YazarEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YazarEkle));
            this.button_temizle = new System.Windows.Forms.Button();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.textBox_yazaradsoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox_yazarhakkında = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.maskedTextBox_dogum = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_olum = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_kitapsayisi = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // button_temizle
            // 
            this.button_temizle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_temizle.Image = ((System.Drawing.Image)(resources.GetObject("button_temizle.Image")));
            this.button_temizle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_temizle.Location = new System.Drawing.Point(19, 411);
            this.button_temizle.Name = "button_temizle";
            this.button_temizle.Size = new System.Drawing.Size(128, 46);
            this.button_temizle.TabIndex = 8;
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
            this.button_kaydet.Location = new System.Drawing.Point(289, 411);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(121, 46);
            this.button_kaydet.TabIndex = 7;
            this.button_kaydet.Text = "Kaydet";
            this.button_kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_kaydet.UseVisualStyleBackColor = true;
            this.button_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // textBox_yazaradsoyad
            // 
            this.textBox_yazaradsoyad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_yazaradsoyad.Location = new System.Drawing.Point(222, 15);
            this.textBox_yazaradsoyad.Name = "textBox_yazaradsoyad";
            this.textBox_yazaradsoyad.Size = new System.Drawing.Size(188, 27);
            this.textBox_yazaradsoyad.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.Location = new System.Drawing.Point(20, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 30);
            this.label3.TabIndex = 13;
            this.label3.Text = "Yazar Hakkında:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.Location = new System.Drawing.Point(20, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "Yazar Ad Soyad:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // richTextBox_yazarhakkında
            // 
            this.richTextBox_yazarhakkında.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.richTextBox_yazarhakkında.Location = new System.Drawing.Point(222, 48);
            this.richTextBox_yazarhakkında.Name = "richTextBox_yazarhakkında";
            this.richTextBox_yazarhakkında.Size = new System.Drawing.Size(188, 203);
            this.richTextBox_yazarhakkında.TabIndex = 2;
            this.richTextBox_yazarhakkında.Text = "";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.Location = new System.Drawing.Point(20, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 30);
            this.label4.TabIndex = 18;
            this.label4.Text = "Dogum Tarihi:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.Location = new System.Drawing.Point(20, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 30);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ölüm Tarihi";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.Location = new System.Drawing.Point(20, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 30);
            this.label6.TabIndex = 22;
            this.label6.Text = "Kitap Sayısı:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(273, 327);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(90, 23);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Hayatta";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // maskedTextBox_dogum
            // 
            this.maskedTextBox_dogum.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.maskedTextBox_dogum.Location = new System.Drawing.Point(222, 257);
            this.maskedTextBox_dogum.Mask = "00/00/0000";
            this.maskedTextBox_dogum.Name = "maskedTextBox_dogum";
            this.maskedTextBox_dogum.Size = new System.Drawing.Size(188, 27);
            this.maskedTextBox_dogum.TabIndex = 3;
            this.maskedTextBox_dogum.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox_olum
            // 
            this.maskedTextBox_olum.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.maskedTextBox_olum.Enabled = false;
            this.maskedTextBox_olum.Location = new System.Drawing.Point(222, 290);
            this.maskedTextBox_olum.Mask = "00/00/0000";
            this.maskedTextBox_olum.Name = "maskedTextBox_olum";
            this.maskedTextBox_olum.Size = new System.Drawing.Size(188, 27);
            this.maskedTextBox_olum.TabIndex = 4;
            this.maskedTextBox_olum.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox_kitapsayisi
            // 
            this.maskedTextBox_kitapsayisi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.maskedTextBox_kitapsayisi.Location = new System.Drawing.Point(222, 360);
            this.maskedTextBox_kitapsayisi.Mask = "00000";
            this.maskedTextBox_kitapsayisi.Name = "maskedTextBox_kitapsayisi";
            this.maskedTextBox_kitapsayisi.Size = new System.Drawing.Size(188, 27);
            this.maskedTextBox_kitapsayisi.TabIndex = 6;
            this.maskedTextBox_kitapsayisi.ValidatingType = typeof(int);
            // 
            // YazarEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 470);
            this.Controls.Add(this.maskedTextBox_kitapsayisi);
            this.Controls.Add(this.maskedTextBox_olum);
            this.Controls.Add(this.maskedTextBox_dogum);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox_yazarhakkında);
            this.Controls.Add(this.button_temizle);
            this.Controls.Add(this.button_kaydet);
            this.Controls.Add(this.textBox_yazaradsoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Montserrat", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "YazarEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yazar Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_temizle;
        private System.Windows.Forms.Button button_kaydet;
        private System.Windows.Forms.TextBox textBox_yazaradsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox_yazarhakkında;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_dogum;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_olum;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_kitapsayisi;
    }
}