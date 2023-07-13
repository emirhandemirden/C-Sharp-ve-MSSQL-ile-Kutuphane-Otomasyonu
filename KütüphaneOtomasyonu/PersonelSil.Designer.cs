namespace KütüphaneOtomasyonu
{
    partial class PersonelSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelSil));
            this.textBox_personeladsoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_personelno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_personeladsoyad
            // 
            this.textBox_personeladsoyad.Enabled = false;
            this.textBox_personeladsoyad.Location = new System.Drawing.Point(214, 42);
            this.textBox_personeladsoyad.Name = "textBox_personeladsoyad";
            this.textBox_personeladsoyad.Size = new System.Drawing.Size(188, 27);
            this.textBox_personeladsoyad.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 30);
            this.label2.TabIndex = 38;
            this.label2.Text = "Personel Ad Soyad:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_personelno
            // 
            this.label_personelno.Location = new System.Drawing.Point(210, 9);
            this.label_personelno.Name = "label_personelno";
            this.label_personelno.Size = new System.Drawing.Size(192, 30);
            this.label_personelno.TabIndex = 37;
            this.label_personelno.Text = "1";
            this.label_personelno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 30);
            this.label1.TabIndex = 36;
            this.label1.Text = "Personel No:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_kaydet
            // 
            this.button_kaydet.Image = ((System.Drawing.Image)(resources.GetObject("button_kaydet.Image")));
            this.button_kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_kaydet.Location = new System.Drawing.Point(162, 84);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(93, 46);
            this.button_kaydet.TabIndex = 55;
            this.button_kaydet.Text = "Sil";
            this.button_kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_kaydet.UseVisualStyleBackColor = true;
            this.button_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // PersonelSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 142);
            this.Controls.Add(this.button_kaydet);
            this.Controls.Add(this.textBox_personeladsoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_personelno);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Montserrat", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "PersonelSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Personel Sil";
            this.Load += new System.EventHandler(this.PersonelSil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_personeladsoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_personelno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_kaydet;
    }
}