namespace KütüphaneOtomasyonu
{
    partial class EmanetVer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmanetVer));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_kitap = new System.Windows.Forms.ComboBox();
            this.kitaplarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitaplarDataSet = new KütüphaneOtomasyonu.KitaplarDataSet();
            this.button_temizle = new System.Windows.Forms.Button();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.kitaplarTableAdapter = new KütüphaneOtomasyonu.KitaplarDataSetTableAdapters.KitaplarTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.maskedTextBox_uyetc = new System.Windows.Forms.MaskedTextBox();
            this.textBox_uyead = new System.Windows.Forms.TextBox();
            this.maskedTextBox_alim = new System.Windows.Forms.TextBox();
            this.maskedTextBox_son = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 30);
            this.label2.TabIndex = 48;
            this.label2.Text = "Verilecek Kitap:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 30);
            this.label3.TabIndex = 49;
            this.label3.Text = "Üye Adı:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 30);
            this.label4.TabIndex = 50;
            this.label4.Text = "Alım Tarihi:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.Location = new System.Drawing.Point(12, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 30);
            this.label5.TabIndex = 51;
            this.label5.Text = "Son Tarih:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.Location = new System.Drawing.Point(12, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 30);
            this.label6.TabIndex = 52;
            this.label6.Text = "Uzatma Süresi:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.Location = new System.Drawing.Point(12, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 30);
            this.label7.TabIndex = 53;
            this.label7.Text = "Uzatma Hakkı:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.Location = new System.Drawing.Point(210, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 30);
            this.label8.TabIndex = 54;
            this.label8.Text = "3";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.Location = new System.Drawing.Point(210, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(192, 30);
            this.label9.TabIndex = 55;
            this.label9.Text = "30 Gün";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox_kitap
            // 
            this.comboBox_kitap.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBox_kitap.BackColor = System.Drawing.Color.White;
            this.comboBox_kitap.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.kitaplarBindingSource, "kitap_ad", true));
            this.comboBox_kitap.DataSource = this.kitaplarBindingSource;
            this.comboBox_kitap.DisplayMember = "kitap_ad";
            this.comboBox_kitap.FormattingEnabled = true;
            this.comboBox_kitap.Location = new System.Drawing.Point(214, 14);
            this.comboBox_kitap.Name = "comboBox_kitap";
            this.comboBox_kitap.Size = new System.Drawing.Size(188, 27);
            this.comboBox_kitap.TabIndex = 56;
            this.comboBox_kitap.ValueMember = "kitap_ad";
            // 
            // kitaplarBindingSource
            // 
            this.kitaplarBindingSource.DataMember = "Kitaplar";
            this.kitaplarBindingSource.DataSource = this.kitaplarDataSet;
            // 
            // kitaplarDataSet
            // 
            this.kitaplarDataSet.DataSetName = "KitaplarDataSet";
            this.kitaplarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button_temizle
            // 
            this.button_temizle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_temizle.Image = ((System.Drawing.Image)(resources.GetObject("button_temizle.Image")));
            this.button_temizle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_temizle.Location = new System.Drawing.Point(16, 251);
            this.button_temizle.Name = "button_temizle";
            this.button_temizle.Size = new System.Drawing.Size(128, 46);
            this.button_temizle.TabIndex = 61;
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
            this.button_kaydet.Location = new System.Drawing.Point(281, 251);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(121, 46);
            this.button_kaydet.TabIndex = 60;
            this.button_kaydet.Text = "Kaydet";
            this.button_kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_kaydet.UseVisualStyleBackColor = true;
            this.button_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // kitaplarTableAdapter
            // 
            this.kitaplarTableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label10.Location = new System.Drawing.Point(12, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(192, 30);
            this.label10.TabIndex = 62;
            this.label10.Text = "Üye TC:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maskedTextBox_uyetc
            // 
            this.maskedTextBox_uyetc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.maskedTextBox_uyetc.Location = new System.Drawing.Point(214, 47);
            this.maskedTextBox_uyetc.Mask = "00000000000";
            this.maskedTextBox_uyetc.Name = "maskedTextBox_uyetc";
            this.maskedTextBox_uyetc.Size = new System.Drawing.Size(188, 27);
            this.maskedTextBox_uyetc.TabIndex = 63;
            this.maskedTextBox_uyetc.ValidatingType = typeof(int);
            this.maskedTextBox_uyetc.TextChanged += new System.EventHandler(this.maskedTextBox_uyetc_TextChanged);
            // 
            // textBox_uyead
            // 
            this.textBox_uyead.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_uyead.Enabled = false;
            this.textBox_uyead.Location = new System.Drawing.Point(214, 80);
            this.textBox_uyead.Name = "textBox_uyead";
            this.textBox_uyead.Size = new System.Drawing.Size(188, 27);
            this.textBox_uyead.TabIndex = 64;
            // 
            // maskedTextBox_alim
            // 
            this.maskedTextBox_alim.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.maskedTextBox_alim.Enabled = false;
            this.maskedTextBox_alim.Location = new System.Drawing.Point(214, 113);
            this.maskedTextBox_alim.Name = "maskedTextBox_alim";
            this.maskedTextBox_alim.Size = new System.Drawing.Size(188, 27);
            this.maskedTextBox_alim.TabIndex = 65;
            // 
            // maskedTextBox_son
            // 
            this.maskedTextBox_son.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.maskedTextBox_son.Enabled = false;
            this.maskedTextBox_son.Location = new System.Drawing.Point(214, 146);
            this.maskedTextBox_son.Name = "maskedTextBox_son";
            this.maskedTextBox_son.Size = new System.Drawing.Size(188, 27);
            this.maskedTextBox_son.TabIndex = 66;
            // 
            // EmanetVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 309);
            this.Controls.Add(this.maskedTextBox_son);
            this.Controls.Add(this.maskedTextBox_alim);
            this.Controls.Add(this.textBox_uyead);
            this.Controls.Add(this.maskedTextBox_uyetc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button_temizle);
            this.Controls.Add(this.button_kaydet);
            this.Controls.Add(this.comboBox_kitap);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Montserrat", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "EmanetVer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Emanet Ver";
            this.Load += new System.EventHandler(this.EmanetVer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_kitap;
        private System.Windows.Forms.Button button_temizle;
        private System.Windows.Forms.Button button_kaydet;
        private KitaplarDataSet kitaplarDataSet;
        private System.Windows.Forms.BindingSource kitaplarBindingSource;
        private KitaplarDataSetTableAdapters.KitaplarTableAdapter kitaplarTableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_uyetc;
        private System.Windows.Forms.TextBox textBox_uyead;
        private System.Windows.Forms.TextBox maskedTextBox_alim;
        private System.Windows.Forms.TextBox maskedTextBox_son;
    }
}