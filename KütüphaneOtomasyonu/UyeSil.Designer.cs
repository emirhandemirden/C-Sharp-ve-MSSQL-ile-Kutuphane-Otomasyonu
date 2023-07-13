namespace KütüphaneOtomasyonu
{
    partial class UyeSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeSil));
            this.maskedTextBox_tcno = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_uyeadsoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_uyeno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maskedTextBox_tcno
            // 
            this.maskedTextBox_tcno.Enabled = false;
            this.maskedTextBox_tcno.Location = new System.Drawing.Point(156, 42);
            this.maskedTextBox_tcno.Mask = "00000000000";
            this.maskedTextBox_tcno.Name = "maskedTextBox_tcno";
            this.maskedTextBox_tcno.Size = new System.Drawing.Size(188, 27);
            this.maskedTextBox_tcno.TabIndex = 13;
            this.maskedTextBox_tcno.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 30);
            this.label5.TabIndex = 14;
            this.label5.Text = "Üye TC No:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_uyeadsoyad
            // 
            this.textBox_uyeadsoyad.Enabled = false;
            this.textBox_uyeadsoyad.Location = new System.Drawing.Point(156, 75);
            this.textBox_uyeadsoyad.Name = "textBox_uyeadsoyad";
            this.textBox_uyeadsoyad.Size = new System.Drawing.Size(188, 27);
            this.textBox_uyeadsoyad.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 30);
            this.label2.TabIndex = 12;
            this.label2.Text = "Üye Ad Soyad:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_uyeno
            // 
            this.label_uyeno.Location = new System.Drawing.Point(152, 9);
            this.label_uyeno.Name = "label_uyeno";
            this.label_uyeno.Size = new System.Drawing.Size(192, 30);
            this.label_uyeno.TabIndex = 11;
            this.label_uyeno.Text = "1";
            this.label_uyeno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Üye No:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_kaydet
            // 
            this.button_kaydet.Image = ((System.Drawing.Image)(resources.GetObject("button_kaydet.Image")));
            this.button_kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_kaydet.Location = new System.Drawing.Point(132, 114);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(93, 46);
            this.button_kaydet.TabIndex = 56;
            this.button_kaydet.Text = "Sil";
            this.button_kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_kaydet.UseVisualStyleBackColor = true;
            this.button_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // UyeSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 172);
            this.Controls.Add(this.button_kaydet);
            this.Controls.Add(this.maskedTextBox_tcno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_uyeadsoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_uyeno);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Montserrat", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "UyeSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Üye Sil";
            this.Load += new System.EventHandler(this.UyeSil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox_tcno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_uyeadsoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_uyeno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_kaydet;
    }
}