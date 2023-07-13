namespace KütüphaneOtomasyonu
{
    partial class PersonelEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelEkle));
            this.textBox_personeladsoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBox_personeldogum = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_personeltelefon = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_personelyetki = new System.Windows.Forms.MaskedTextBox();
            this.button_temizle = new System.Windows.Forms.Button();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_personeladsoyad
            // 
            this.textBox_personeladsoyad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_personeladsoyad.Location = new System.Drawing.Point(225, 15);
            this.textBox_personeladsoyad.Name = "textBox_personeladsoyad";
            this.textBox_personeladsoyad.Size = new System.Drawing.Size(188, 27);
            this.textBox_personeladsoyad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.Location = new System.Drawing.Point(23, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 30);
            this.label2.TabIndex = 34;
            this.label2.Text = "Personel Ad Soyad:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.Location = new System.Drawing.Point(23, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 30);
            this.label3.TabIndex = 35;
            this.label3.Text = "Personel Dogum Tarihi:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.Location = new System.Drawing.Point(23, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 30);
            this.label4.TabIndex = 36;
            this.label4.Text = "Personel Telefon:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.Location = new System.Drawing.Point(23, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 30);
            this.label5.TabIndex = 37;
            this.label5.Text = "Personel Yetki:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maskedTextBox_personeldogum
            // 
            this.maskedTextBox_personeldogum.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.maskedTextBox_personeldogum.Location = new System.Drawing.Point(225, 48);
            this.maskedTextBox_personeldogum.Mask = "00/00/0000";
            this.maskedTextBox_personeldogum.Name = "maskedTextBox_personeldogum";
            this.maskedTextBox_personeldogum.Size = new System.Drawing.Size(188, 27);
            this.maskedTextBox_personeldogum.TabIndex = 2;
            this.maskedTextBox_personeldogum.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox_personeltelefon
            // 
            this.maskedTextBox_personeltelefon.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.maskedTextBox_personeltelefon.Location = new System.Drawing.Point(225, 81);
            this.maskedTextBox_personeltelefon.Mask = "(999) 000-00 00";
            this.maskedTextBox_personeltelefon.Name = "maskedTextBox_personeltelefon";
            this.maskedTextBox_personeltelefon.Size = new System.Drawing.Size(188, 27);
            this.maskedTextBox_personeltelefon.TabIndex = 3;
            // 
            // maskedTextBox_personelyetki
            // 
            this.maskedTextBox_personelyetki.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.maskedTextBox_personelyetki.Location = new System.Drawing.Point(225, 114);
            this.maskedTextBox_personelyetki.Mask = "0";
            this.maskedTextBox_personelyetki.Name = "maskedTextBox_personelyetki";
            this.maskedTextBox_personelyetki.Size = new System.Drawing.Size(188, 27);
            this.maskedTextBox_personelyetki.TabIndex = 4;
            this.maskedTextBox_personelyetki.ValidatingType = typeof(int);
            // 
            // button_temizle
            // 
            this.button_temizle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_temizle.Image = ((System.Drawing.Image)(resources.GetObject("button_temizle.Image")));
            this.button_temizle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_temizle.Location = new System.Drawing.Point(22, 160);
            this.button_temizle.Name = "button_temizle";
            this.button_temizle.Size = new System.Drawing.Size(128, 46);
            this.button_temizle.TabIndex = 6;
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
            this.button_kaydet.Location = new System.Drawing.Point(292, 160);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(121, 46);
            this.button_kaydet.TabIndex = 5;
            this.button_kaydet.Text = "Kaydet";
            this.button_kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_kaydet.UseVisualStyleBackColor = true;
            this.button_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // PersonelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(428, 218);
            this.Controls.Add(this.button_temizle);
            this.Controls.Add(this.button_kaydet);
            this.Controls.Add(this.maskedTextBox_personelyetki);
            this.Controls.Add(this.maskedTextBox_personeltelefon);
            this.Controls.Add(this.maskedTextBox_personeldogum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_personeladsoyad);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Montserrat", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "PersonelEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Personel Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_personeladsoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_personeldogum;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_personeltelefon;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_personelyetki;
        private System.Windows.Forms.Button button_temizle;
        private System.Windows.Forms.Button button_kaydet;
    }
}