namespace KütüphaneOtomasyonu
{
    partial class Personeller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personeller));
            this.personellerDataSet = new KütüphaneOtomasyonu.PersonellerDataSet();
            this.personellerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personellerTableAdapter = new KütüphaneOtomasyonu.PersonellerDataSetTableAdapters.PersonellerTableAdapter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colpersonel_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpersonel_ad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpersonel_dogum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpersonel_telefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpersonel_yetki = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAranan = new System.Windows.Forms.TextBox();
            this.lblArananalan = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Rad2 = new System.Windows.Forms.RadioButton();
            this.rad1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAramaTuru = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt2 = new System.Windows.Forms.MaskedTextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.chk3 = new System.Windows.Forms.CheckBox();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.btnara = new System.Windows.Forms.Button();
            this.txt3 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.personellerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personellerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // personellerDataSet
            // 
            this.personellerDataSet.DataSetName = "PersonellerDataSet";
            this.personellerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personellerBindingSource
            // 
            this.personellerBindingSource.DataMember = "Personeller";
            this.personellerBindingSource.DataSource = this.personellerDataSet;
            // 
            // personellerTableAdapter
            // 
            this.personellerTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.personellerBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(784, 523);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colpersonel_id,
            this.colpersonel_ad,
            this.colpersonel_dogum,
            this.colpersonel_telefon,
            this.colpersonel_yetki});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Fast;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colpersonel_id
            // 
            this.colpersonel_id.Caption = "ID";
            this.colpersonel_id.FieldName = "personel_id";
            this.colpersonel_id.Name = "colpersonel_id";
            this.colpersonel_id.Visible = true;
            this.colpersonel_id.VisibleIndex = 0;
            this.colpersonel_id.Width = 64;
            // 
            // colpersonel_ad
            // 
            this.colpersonel_ad.Caption = "Ad Soyad";
            this.colpersonel_ad.FieldName = "personel_ad";
            this.colpersonel_ad.Name = "colpersonel_ad";
            this.colpersonel_ad.Visible = true;
            this.colpersonel_ad.VisibleIndex = 1;
            this.colpersonel_ad.Width = 177;
            // 
            // colpersonel_dogum
            // 
            this.colpersonel_dogum.Caption = "Doğum Tarihi";
            this.colpersonel_dogum.FieldName = "personel_dogum";
            this.colpersonel_dogum.Name = "colpersonel_dogum";
            this.colpersonel_dogum.Visible = true;
            this.colpersonel_dogum.VisibleIndex = 2;
            this.colpersonel_dogum.Width = 177;
            // 
            // colpersonel_telefon
            // 
            this.colpersonel_telefon.Caption = "Telefon Numarası";
            this.colpersonel_telefon.FieldName = "personel_telefon";
            this.colpersonel_telefon.Name = "colpersonel_telefon";
            this.colpersonel_telefon.Visible = true;
            this.colpersonel_telefon.VisibleIndex = 3;
            this.colpersonel_telefon.Width = 177;
            // 
            // colpersonel_yetki
            // 
            this.colpersonel_yetki.Caption = "Yetki";
            this.colpersonel_yetki.FieldName = "personel_yetki";
            this.colpersonel_yetki.Name = "colpersonel_yetki";
            this.colpersonel_yetki.Visible = true;
            this.colpersonel_yetki.VisibleIndex = 4;
            this.colpersonel_yetki.Width = 180;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1017, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(96, 22);
            this.toolStripButton1.Text = "Personel Ekle";
            this.toolStripButton1.Click += new System.EventHandler(this.personelEkleToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(87, 22);
            this.toolStripButton2.Text = "Personel Sil";
            this.toolStripButton2.Click += new System.EventHandler(this.personelSilToolStripMenuItem_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(121, 22);
            this.toolStripButton3.Text = "Personel Güncelle";
            this.toolStripButton3.Click += new System.EventHandler(this.personelGüncelleToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(161, 22);
            this.toolStripButton4.Text = "Personel İşlem Geçmişleri";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtAranan);
            this.groupBox2.Controls.Add(this.lblArananalan);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbAramaTuru);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(792, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 249);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hızlı Arama";
            // 
            // txtAranan
            // 
            this.txtAranan.Location = new System.Drawing.Point(2, 213);
            this.txtAranan.Name = "txtAranan";
            this.txtAranan.Size = new System.Drawing.Size(200, 26);
            this.txtAranan.TabIndex = 9;
            this.txtAranan.TextChanged += new System.EventHandler(this.txtAranan_TextChanged);
            // 
            // lblArananalan
            // 
            this.lblArananalan.AutoSize = true;
            this.lblArananalan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblArananalan.Location = new System.Drawing.Point(2, 190);
            this.lblArananalan.Name = "lblArananalan";
            this.lblArananalan.Size = new System.Drawing.Size(77, 20);
            this.lblArananalan.TabIndex = 8;
            this.lblArananalan.Text = "Açıklama:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Rad2);
            this.groupBox3.Controls.Add(this.rad1);
            this.groupBox3.Location = new System.Drawing.Point(6, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 105);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alan Seçimi";
            // 
            // Rad2
            // 
            this.Rad2.AutoSize = true;
            this.Rad2.Location = new System.Drawing.Point(19, 66);
            this.Rad2.Name = "Rad2";
            this.Rad2.Size = new System.Drawing.Size(151, 24);
            this.Rad2.TabIndex = 1;
            this.Rad2.Text = "Telefon Numarası";
            this.Rad2.UseVisualStyleBackColor = true;
            this.Rad2.CheckedChanged += new System.EventHandler(this.Rad2_CheckedChanged);
            // 
            // rad1
            // 
            this.rad1.AutoSize = true;
            this.rad1.Checked = true;
            this.rad1.Location = new System.Drawing.Point(19, 30);
            this.rad1.Name = "rad1";
            this.rad1.Size = new System.Drawing.Size(96, 24);
            this.rad1.TabIndex = 0;
            this.rad1.TabStop = true;
            this.rad1.Text = "Ad Soyad";
            this.rad1.UseVisualStyleBackColor = true;
            this.rad1.CheckedChanged += new System.EventHandler(this.rad1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Arama Türü";
            // 
            // cmbAramaTuru
            // 
            this.cmbAramaTuru.FormattingEnabled = true;
            this.cmbAramaTuru.Items.AddRange(new object[] {
            "İle Başlayan",
            "İle Biten",
            "İçeren"});
            this.cmbAramaTuru.Location = new System.Drawing.Point(6, 48);
            this.cmbAramaTuru.Name = "cmbAramaTuru";
            this.cmbAramaTuru.Size = new System.Drawing.Size(198, 28);
            this.cmbAramaTuru.TabIndex = 5;
            this.cmbAramaTuru.Text = "İle Başlayan";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txt2);
            this.groupBox1.Controls.Add(this.txt1);
            this.groupBox1.Controls.Add(this.chk3);
            this.groupBox1.Controls.Add(this.chk2);
            this.groupBox1.Controls.Add(this.chk1);
            this.groupBox1.Controls.Add(this.btnara);
            this.groupBox1.Controls.Add(this.txt3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(792, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 255);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Birebir Arama";
            // 
            // txt2
            // 
            this.txt2.Enabled = false;
            this.txt2.Location = new System.Drawing.Point(6, 119);
            this.txt2.Mask = "00000";
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(200, 26);
            this.txt2.TabIndex = 12;
            this.txt2.ValidatingType = typeof(int);
            // 
            // txt1
            // 
            this.txt1.Enabled = false;
            this.txt1.Location = new System.Drawing.Point(6, 59);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(200, 26);
            this.txt1.TabIndex = 11;
            // 
            // chk3
            // 
            this.chk3.AutoSize = true;
            this.chk3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chk3.Location = new System.Drawing.Point(9, 153);
            this.chk3.Name = "chk3";
            this.chk3.Size = new System.Drawing.Size(116, 22);
            this.chk3.TabIndex = 10;
            this.chk3.Text = "Doğum Tarihi";
            this.chk3.UseVisualStyleBackColor = true;
            this.chk3.CheckedChanged += new System.EventHandler(this.chk3_CheckedChanged);
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chk2.Location = new System.Drawing.Point(9, 91);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(59, 22);
            this.chk2.TabIndex = 9;
            this.chk2.Text = "Yetki";
            this.chk2.UseVisualStyleBackColor = true;
            this.chk2.CheckedChanged += new System.EventHandler(this.chk2_CheckedChanged);
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chk1.Location = new System.Drawing.Point(9, 31);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(90, 22);
            this.chk1.TabIndex = 8;
            this.chk1.Text = "Ad Soyad";
            this.chk1.UseVisualStyleBackColor = true;
            this.chk1.CheckedChanged += new System.EventHandler(this.chk1_CheckedChanged);
            // 
            // btnara
            // 
            this.btnara.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnara.Location = new System.Drawing.Point(6, 214);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(201, 35);
            this.btnara.TabIndex = 7;
            this.btnara.Text = "Ara";
            this.btnara.UseVisualStyleBackColor = true;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // txt3
            // 
            this.txt3.Enabled = false;
            this.txt3.Location = new System.Drawing.Point(6, 181);
            this.txt3.Mask = "00/00/0000";
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(201, 26);
            this.txt3.TabIndex = 6;
            this.txt3.ValidatingType = typeof(System.DateTime);
            // 
            // Personeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 523);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Personeller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Personeller";
            this.Load += new System.EventHandler(this.Personeller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personellerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personellerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PersonellerDataSet personellerDataSet;
        private System.Windows.Forms.BindingSource personellerBindingSource;
        private PersonellerDataSetTableAdapters.PersonellerTableAdapter personellerTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colpersonel_id;
        private DevExpress.XtraGrid.Columns.GridColumn colpersonel_ad;
        private DevExpress.XtraGrid.Columns.GridColumn colpersonel_dogum;
        private DevExpress.XtraGrid.Columns.GridColumn colpersonel_telefon;
        private DevExpress.XtraGrid.Columns.GridColumn colpersonel_yetki;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAranan;
        private System.Windows.Forms.Label lblArananalan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton Rad2;
        private System.Windows.Forms.RadioButton rad1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAramaTuru;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.CheckBox chk3;
        private System.Windows.Forms.CheckBox chk2;
        private System.Windows.Forms.CheckBox chk1;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.MaskedTextBox txt3;
    }
}