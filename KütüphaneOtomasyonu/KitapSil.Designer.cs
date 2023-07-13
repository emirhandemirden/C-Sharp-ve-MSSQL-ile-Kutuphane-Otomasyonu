namespace KütüphaneOtomasyonu
{
    partial class KitapSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapSil));
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_kitapad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_kitapno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.textBox_yazar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 30);
            this.label4.TabIndex = 53;
            this.label4.Text = "Kitap Yazarı:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_kitapad
            // 
            this.textBox_kitapad.Enabled = false;
            this.textBox_kitapad.Location = new System.Drawing.Point(143, 42);
            this.textBox_kitapad.Name = "textBox_kitapad";
            this.textBox_kitapad.Size = new System.Drawing.Size(188, 27);
            this.textBox_kitapad.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 30);
            this.label2.TabIndex = 52;
            this.label2.Text = "Kitap Ad:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_kitapno
            // 
            this.label_kitapno.Location = new System.Drawing.Point(139, 9);
            this.label_kitapno.Name = "label_kitapno";
            this.label_kitapno.Size = new System.Drawing.Size(192, 30);
            this.label_kitapno.TabIndex = 51;
            this.label_kitapno.Text = "1";
            this.label_kitapno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 30);
            this.label1.TabIndex = 50;
            this.label1.Text = "Kitap No:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_kaydet
            // 
            this.button_kaydet.Image = ((System.Drawing.Image)(resources.GetObject("button_kaydet.Image")));
            this.button_kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_kaydet.Location = new System.Drawing.Point(126, 122);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(93, 46);
            this.button_kaydet.TabIndex = 54;
            this.button_kaydet.Text = "Sil";
            this.button_kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_kaydet.UseVisualStyleBackColor = true;
            this.button_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // textBox_yazar
            // 
            this.textBox_yazar.Enabled = false;
            this.textBox_yazar.Location = new System.Drawing.Point(143, 75);
            this.textBox_yazar.Name = "textBox_yazar";
            this.textBox_yazar.Size = new System.Drawing.Size(188, 27);
            this.textBox_yazar.TabIndex = 56;
            // 
            // KitapSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 180);
            this.Controls.Add(this.textBox_yazar);
            this.Controls.Add(this.button_kaydet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_kitapad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_kitapno);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Montserrat", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "KitapSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kitap Sil";
            this.Load += new System.EventHandler(this.KitapSil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_kitapad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_kitapno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_kaydet;
        private System.Windows.Forms.TextBox textBox_yazar;
    }
}