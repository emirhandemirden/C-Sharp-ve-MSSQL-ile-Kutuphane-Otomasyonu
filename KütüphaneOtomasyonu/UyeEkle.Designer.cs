﻿namespace KütüphaneOtomasyonu
{
    partial class UyeEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeEkle));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_uyeadsoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBox_telefon = new System.Windows.Forms.MaskedTextBox();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.button_temizle = new System.Windows.Forms.Button();
            this.maskedTextBox_dogum = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_tcno = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Üye Ad Soyad:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.Location = new System.Drawing.Point(13, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Üye Dogum Tarihi:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_uyeadsoyad
            // 
            this.textBox_uyeadsoyad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_uyeadsoyad.Location = new System.Drawing.Point(215, 46);
            this.textBox_uyeadsoyad.Name = "textBox_uyeadsoyad";
            this.textBox_uyeadsoyad.Size = new System.Drawing.Size(188, 27);
            this.textBox_uyeadsoyad.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.Location = new System.Drawing.Point(13, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Üye Telefon Numarası:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maskedTextBox_telefon
            // 
            this.maskedTextBox_telefon.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.maskedTextBox_telefon.Location = new System.Drawing.Point(215, 109);
            this.maskedTextBox_telefon.Mask = "(999) 000-00 00";
            this.maskedTextBox_telefon.Name = "maskedTextBox_telefon";
            this.maskedTextBox_telefon.Size = new System.Drawing.Size(188, 27);
            this.maskedTextBox_telefon.TabIndex = 3;
            // 
            // button_kaydet
            // 
            this.button_kaydet.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_kaydet.Image = ((System.Drawing.Image)(resources.GetObject("button_kaydet.Image")));
            this.button_kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_kaydet.Location = new System.Drawing.Point(282, 153);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(121, 46);
            this.button_kaydet.TabIndex = 4;
            this.button_kaydet.Text = "Kaydet";
            this.button_kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_kaydet.UseVisualStyleBackColor = true;
            this.button_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // button_temizle
            // 
            this.button_temizle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_temizle.Image = ((System.Drawing.Image)(resources.GetObject("button_temizle.Image")));
            this.button_temizle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_temizle.Location = new System.Drawing.Point(12, 153);
            this.button_temizle.Name = "button_temizle";
            this.button_temizle.Size = new System.Drawing.Size(128, 46);
            this.button_temizle.TabIndex = 5;
            this.button_temizle.Text = "Temizle";
            this.button_temizle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_temizle.UseVisualStyleBackColor = true;
            this.button_temizle.Click += new System.EventHandler(this.button_temizle_Click);
            // 
            // maskedTextBox_dogum
            // 
            this.maskedTextBox_dogum.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.maskedTextBox_dogum.Location = new System.Drawing.Point(215, 79);
            this.maskedTextBox_dogum.Mask = "00/00/0000";
            this.maskedTextBox_dogum.Name = "maskedTextBox_dogum";
            this.maskedTextBox_dogum.Size = new System.Drawing.Size(188, 27);
            this.maskedTextBox_dogum.TabIndex = 2;
            this.maskedTextBox_dogum.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox_tcno
            // 
            this.maskedTextBox_tcno.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.maskedTextBox_tcno.Location = new System.Drawing.Point(215, 13);
            this.maskedTextBox_tcno.Mask = "00000000000";
            this.maskedTextBox_tcno.Name = "maskedTextBox_tcno";
            this.maskedTextBox_tcno.Size = new System.Drawing.Size(188, 27);
            this.maskedTextBox_tcno.TabIndex = 7;
            this.maskedTextBox_tcno.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.Location = new System.Drawing.Point(13, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Üye TC No:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UyeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 212);
            this.Controls.Add(this.maskedTextBox_tcno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTextBox_dogum);
            this.Controls.Add(this.button_temizle);
            this.Controls.Add(this.button_kaydet);
            this.Controls.Add(this.maskedTextBox_telefon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_uyeadsoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Montserrat", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "UyeEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Üye Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_uyeadsoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_telefon;
        private System.Windows.Forms.Button button_kaydet;
        private System.Windows.Forms.Button button_temizle;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_dogum;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_tcno;
        private System.Windows.Forms.Label label5;
    }
}