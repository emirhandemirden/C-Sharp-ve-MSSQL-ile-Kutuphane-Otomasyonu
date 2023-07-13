namespace KütüphaneOtomasyonu
{
    partial class Kitaplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kitaplar));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.kitaplarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitaplarDataSet = new KütüphaneOtomasyonu.KitaplarDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colkitap_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkitap_ad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkitap_yazar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkitap_yayıntarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkitap_sayfasayısı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkitap_barkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkitap_rafno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkitap_dolapno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kitaplarTableAdapter = new KütüphaneOtomasyonu.KitaplarDataSetTableAdapters.KitaplarTableAdapter();
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
            this.RadBarkod = new System.Windows.Forms.RadioButton();
            this.radKitap = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAramaTuru = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkSayfa = new System.Windows.Forms.CheckBox();
            this.chkYazar = new System.Windows.Forms.CheckBox();
            this.chkKitap = new System.Windows.Forms.CheckBox();
            this.btnara = new System.Windows.Forms.Button();
            this.txtsayfasayisiara = new System.Windows.Forms.MaskedTextBox();
            this.txtkitapara = new System.Windows.Forms.TextBox();
            this.txtyazarara = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.kitaplarBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(784, 524);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colkitap_id,
            this.colkitap_ad,
            this.colkitap_yazar,
            this.colkitap_yayıntarihi,
            this.colkitap_sayfasayısı,
            this.colkitap_barkod,
            this.colkitap_rafno,
            this.colkitap_dolapno});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Fast;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colkitap_id
            // 
            this.colkitap_id.Caption = "ID";
            this.colkitap_id.FieldName = "kitap_id";
            this.colkitap_id.Name = "colkitap_id";
            this.colkitap_id.Visible = true;
            this.colkitap_id.VisibleIndex = 0;
            this.colkitap_id.Width = 56;
            // 
            // colkitap_ad
            // 
            this.colkitap_ad.Caption = "Ad";
            this.colkitap_ad.FieldName = "kitap_ad";
            this.colkitap_ad.Name = "colkitap_ad";
            this.colkitap_ad.Visible = true;
            this.colkitap_ad.VisibleIndex = 1;
            this.colkitap_ad.Width = 99;
            // 
            // colkitap_yazar
            // 
            this.colkitap_yazar.Caption = "Yazar";
            this.colkitap_yazar.FieldName = "kitap_yazar";
            this.colkitap_yazar.Name = "colkitap_yazar";
            this.colkitap_yazar.Visible = true;
            this.colkitap_yazar.VisibleIndex = 2;
            this.colkitap_yazar.Width = 99;
            // 
            // colkitap_yayıntarihi
            // 
            this.colkitap_yayıntarihi.Caption = "Yayın Tarihi";
            this.colkitap_yayıntarihi.FieldName = "kitap_yayıntarihi";
            this.colkitap_yayıntarihi.Name = "colkitap_yayıntarihi";
            this.colkitap_yayıntarihi.Visible = true;
            this.colkitap_yayıntarihi.VisibleIndex = 3;
            this.colkitap_yayıntarihi.Width = 99;
            // 
            // colkitap_sayfasayısı
            // 
            this.colkitap_sayfasayısı.Caption = "Sayfa Sayısı";
            this.colkitap_sayfasayısı.FieldName = "kitap_sayfasayısı";
            this.colkitap_sayfasayısı.Name = "colkitap_sayfasayısı";
            this.colkitap_sayfasayısı.Visible = true;
            this.colkitap_sayfasayısı.VisibleIndex = 4;
            this.colkitap_sayfasayısı.Width = 99;
            // 
            // colkitap_barkod
            // 
            this.colkitap_barkod.Caption = "Barkod";
            this.colkitap_barkod.FieldName = "kitap_barkod";
            this.colkitap_barkod.Name = "colkitap_barkod";
            this.colkitap_barkod.Visible = true;
            this.colkitap_barkod.VisibleIndex = 5;
            this.colkitap_barkod.Width = 100;
            // 
            // colkitap_rafno
            // 
            this.colkitap_rafno.Caption = "Raf No";
            this.colkitap_rafno.FieldName = "kitap_rafno";
            this.colkitap_rafno.Name = "colkitap_rafno";
            this.colkitap_rafno.Visible = true;
            this.colkitap_rafno.VisibleIndex = 6;
            this.colkitap_rafno.Width = 98;
            // 
            // colkitap_dolapno
            // 
            this.colkitap_dolapno.Caption = "Dolap No";
            this.colkitap_dolapno.FieldName = "kitap_dolapno";
            this.colkitap_dolapno.Name = "colkitap_dolapno";
            this.colkitap_dolapno.Visible = true;
            this.colkitap_dolapno.VisibleIndex = 7;
            this.colkitap_dolapno.Width = 109;
            // 
            // kitaplarTableAdapter
            // 
            this.kitaplarTableAdapter.ClearBeforeFill = true;
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
            this.toolStrip1.Size = new System.Drawing.Size(1022, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(78, 22);
            this.toolStripButton1.Text = "Kitap Ekle";
            this.toolStripButton1.Click += new System.EventHandler(this.kitapEkleToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(69, 22);
            this.toolStripButton2.Text = "Kitap Sil";
            this.toolStripButton2.Click += new System.EventHandler(this.kitapSilToolStripMenuItem_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(103, 22);
            this.toolStripButton3.Text = "Kitap Güncelle";
            this.toolStripButton3.Click += new System.EventHandler(this.kitapGüncelleToolStripMenuItem_Click);
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
            this.toolStripButton4.Size = new System.Drawing.Size(143, 22);
            this.toolStripButton4.Text = "Kitap İşlem Geçmişleri";
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
            this.groupBox2.Location = new System.Drawing.Point(797, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 249);
            this.groupBox2.TabIndex = 10;
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
            this.lblArananalan.Size = new System.Drawing.Size(76, 20);
            this.lblArananalan.TabIndex = 8;
            this.lblArananalan.Text = "Kitap Adı:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RadBarkod);
            this.groupBox3.Controls.Add(this.radKitap);
            this.groupBox3.Location = new System.Drawing.Point(6, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 105);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alan Seçimi";
            // 
            // RadBarkod
            // 
            this.RadBarkod.AutoSize = true;
            this.RadBarkod.Location = new System.Drawing.Point(19, 66);
            this.RadBarkod.Name = "RadBarkod";
            this.RadBarkod.Size = new System.Drawing.Size(149, 24);
            this.RadBarkod.TabIndex = 1;
            this.RadBarkod.Text = "Barkod Numarası";
            this.RadBarkod.UseVisualStyleBackColor = true;
            this.RadBarkod.CheckedChanged += new System.EventHandler(this.RadBarkod_CheckedChanged);
            // 
            // radKitap
            // 
            this.radKitap.AutoSize = true;
            this.radKitap.Checked = true;
            this.radKitap.Location = new System.Drawing.Point(19, 30);
            this.radKitap.Name = "radKitap";
            this.radKitap.Size = new System.Drawing.Size(90, 24);
            this.radKitap.TabIndex = 0;
            this.radKitap.TabStop = true;
            this.radKitap.Text = "Kitap Adı";
            this.radKitap.UseVisualStyleBackColor = true;
            this.radKitap.CheckedChanged += new System.EventHandler(this.radKitap_CheckedChanged);
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
            this.groupBox1.Controls.Add(this.txtyazarara);
            this.groupBox1.Controls.Add(this.txtkitapara);
            this.groupBox1.Controls.Add(this.chkSayfa);
            this.groupBox1.Controls.Add(this.chkYazar);
            this.groupBox1.Controls.Add(this.chkKitap);
            this.groupBox1.Controls.Add(this.btnara);
            this.groupBox1.Controls.Add(this.txtsayfasayisiara);
            this.groupBox1.Location = new System.Drawing.Point(797, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 255);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Birebir Arama";
            // 
            // chkSayfa
            // 
            this.chkSayfa.AutoSize = true;
            this.chkSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chkSayfa.Location = new System.Drawing.Point(9, 153);
            this.chkSayfa.Name = "chkSayfa";
            this.chkSayfa.Size = new System.Drawing.Size(107, 22);
            this.chkSayfa.TabIndex = 10;
            this.chkSayfa.Text = "Sayfa Sayısı";
            this.chkSayfa.UseVisualStyleBackColor = true;
            this.chkSayfa.CheckedChanged += new System.EventHandler(this.chkSayfa_CheckedChanged);
            // 
            // chkYazar
            // 
            this.chkYazar.AutoSize = true;
            this.chkYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chkYazar.Location = new System.Drawing.Point(9, 91);
            this.chkYazar.Name = "chkYazar";
            this.chkYazar.Size = new System.Drawing.Size(89, 22);
            this.chkYazar.TabIndex = 9;
            this.chkYazar.Text = "Yazar Adı";
            this.chkYazar.UseVisualStyleBackColor = true;
            this.chkYazar.CheckedChanged += new System.EventHandler(this.chkYazar_CheckedChanged);
            // 
            // chkKitap
            // 
            this.chkKitap.AutoSize = true;
            this.chkKitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chkKitap.Location = new System.Drawing.Point(9, 31);
            this.chkKitap.Name = "chkKitap";
            this.chkKitap.Size = new System.Drawing.Size(84, 22);
            this.chkKitap.TabIndex = 8;
            this.chkKitap.Text = "Kitap Adı";
            this.chkKitap.UseVisualStyleBackColor = true;
            this.chkKitap.CheckedChanged += new System.EventHandler(this.chkKitap_CheckedChanged);
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
            this.btnara.Click += new System.EventHandler(this.button_birebirara_Click);
            // 
            // txtsayfasayisiara
            // 
            this.txtsayfasayisiara.Enabled = false;
            this.txtsayfasayisiara.Location = new System.Drawing.Point(6, 181);
            this.txtsayfasayisiara.Mask = "00000";
            this.txtsayfasayisiara.Name = "txtsayfasayisiara";
            this.txtsayfasayisiara.Size = new System.Drawing.Size(201, 26);
            this.txtsayfasayisiara.TabIndex = 6;
            this.txtsayfasayisiara.ValidatingType = typeof(int);
            // 
            // txtkitapara
            // 
            this.txtkitapara.Enabled = false;
            this.txtkitapara.Location = new System.Drawing.Point(6, 59);
            this.txtkitapara.Name = "txtkitapara";
            this.txtkitapara.Size = new System.Drawing.Size(200, 26);
            this.txtkitapara.TabIndex = 11;
            // 
            // txtyazarara
            // 
            this.txtyazarara.Enabled = false;
            this.txtyazarara.Location = new System.Drawing.Point(6, 119);
            this.txtyazarara.Name = "txtyazarara";
            this.txtyazarara.Size = new System.Drawing.Size(201, 26);
            this.txtyazarara.TabIndex = 12;
            // 
            // Kitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 524);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gridControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Kitaplar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kitaplar";
            this.Load += new System.EventHandler(this.Kitaplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarDataSet)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private KitaplarDataSet kitaplarDataSet;
        private System.Windows.Forms.BindingSource kitaplarBindingSource;
        private KitaplarDataSetTableAdapters.KitaplarTableAdapter kitaplarTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colkitap_id;
        private DevExpress.XtraGrid.Columns.GridColumn colkitap_ad;
        private DevExpress.XtraGrid.Columns.GridColumn colkitap_yazar;
        private DevExpress.XtraGrid.Columns.GridColumn colkitap_yayıntarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colkitap_sayfasayısı;
        private DevExpress.XtraGrid.Columns.GridColumn colkitap_barkod;
        private DevExpress.XtraGrid.Columns.GridColumn colkitap_rafno;
        private DevExpress.XtraGrid.Columns.GridColumn colkitap_dolapno;
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
        private System.Windows.Forms.RadioButton RadBarkod;
        private System.Windows.Forms.RadioButton radKitap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAramaTuru;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkSayfa;
        private System.Windows.Forms.CheckBox chkYazar;
        private System.Windows.Forms.CheckBox chkKitap;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.MaskedTextBox txtsayfasayisiara;
        private System.Windows.Forms.TextBox txtyazarara;
        private System.Windows.Forms.TextBox txtkitapara;
    }
}