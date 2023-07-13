namespace KütüphaneOtomasyonu
{
    partial class Emanetler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emanetler));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.emanetVerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtlıÜyeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniÜyeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emanetAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emanetİptalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.süresiniUzatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emanetGeçmişleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.emanetlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emanetlerDataSet = new KütüphaneOtomasyonu.EmanetlerDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colemanet_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemanet_kitap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemanet_uyetc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemanet_uye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemanet_alım = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemanet_son = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemanet_say = new DevExpress.XtraGrid.Columns.GridColumn();
            this.emanetlerTableAdapter = new KütüphaneOtomasyonu.EmanetlerDataSetTableAdapters.EmanetlerTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAranan = new System.Windows.Forms.TextBox();
            this.lblArananalan = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Rad2 = new System.Windows.Forms.RadioButton();
            this.rad1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAramaTuru = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.uyelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uyelerDataSet = new KütüphaneOtomasyonu.UyelerDataSet();
            this.txt2 = new System.Windows.Forms.MaskedTextBox();
            this.chk3 = new System.Windows.Forms.CheckBox();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.btnara = new System.Windows.Forms.Button();
            this.txt3 = new System.Windows.Forms.MaskedTextBox();
            this.uyelerTableAdapter = new KütüphaneOtomasyonu.UyelerDataSetTableAdapters.UyelerTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emanetlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emanetlerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uyelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyelerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emanetVerToolStripMenuItem,
            this.emanetAlToolStripMenuItem,
            this.emanetİptalToolStripMenuItem,
            this.süresiniUzatToolStripMenuItem,
            this.emanetGeçmişleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1020, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // emanetVerToolStripMenuItem
            // 
            this.emanetVerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtlıÜyeToolStripMenuItem,
            this.yeniÜyeToolStripMenuItem});
            this.emanetVerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("emanetVerToolStripMenuItem.Image")));
            this.emanetVerToolStripMenuItem.Name = "emanetVerToolStripMenuItem";
            this.emanetVerToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.emanetVerToolStripMenuItem.Text = "Emanet Ver";
            // 
            // kayıtlıÜyeToolStripMenuItem
            // 
            this.kayıtlıÜyeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kayıtlıÜyeToolStripMenuItem.Image")));
            this.kayıtlıÜyeToolStripMenuItem.Name = "kayıtlıÜyeToolStripMenuItem";
            this.kayıtlıÜyeToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.kayıtlıÜyeToolStripMenuItem.Text = "Kayıtlı Üye";
            this.kayıtlıÜyeToolStripMenuItem.Click += new System.EventHandler(this.kayıtlıÜyeToolStripMenuItem_Click);
            // 
            // yeniÜyeToolStripMenuItem
            // 
            this.yeniÜyeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yeniÜyeToolStripMenuItem.Image")));
            this.yeniÜyeToolStripMenuItem.Name = "yeniÜyeToolStripMenuItem";
            this.yeniÜyeToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.yeniÜyeToolStripMenuItem.Text = "Yeni Üye";
            this.yeniÜyeToolStripMenuItem.Click += new System.EventHandler(this.yeniÜyeToolStripMenuItem_Click);
            // 
            // emanetAlToolStripMenuItem
            // 
            this.emanetAlToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("emanetAlToolStripMenuItem.Image")));
            this.emanetAlToolStripMenuItem.Name = "emanetAlToolStripMenuItem";
            this.emanetAlToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.emanetAlToolStripMenuItem.Text = "Emanet Al";
            this.emanetAlToolStripMenuItem.Click += new System.EventHandler(this.emanetAlToolStripMenuItem_Click);
            // 
            // emanetİptalToolStripMenuItem
            // 
            this.emanetİptalToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("emanetİptalToolStripMenuItem.Image")));
            this.emanetİptalToolStripMenuItem.Name = "emanetİptalToolStripMenuItem";
            this.emanetİptalToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.emanetİptalToolStripMenuItem.Text = "Emanet İptal";
            this.emanetİptalToolStripMenuItem.Click += new System.EventHandler(this.emanetİptalToolStripMenuItem_Click);
            // 
            // süresiniUzatToolStripMenuItem
            // 
            this.süresiniUzatToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("süresiniUzatToolStripMenuItem.Image")));
            this.süresiniUzatToolStripMenuItem.Name = "süresiniUzatToolStripMenuItem";
            this.süresiniUzatToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.süresiniUzatToolStripMenuItem.Text = "Süresini Uzat";
            this.süresiniUzatToolStripMenuItem.Click += new System.EventHandler(this.süresiniUzatToolStripMenuItem_Click);
            // 
            // emanetGeçmişleriToolStripMenuItem
            // 
            this.emanetGeçmişleriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("emanetGeçmişleriToolStripMenuItem.Image")));
            this.emanetGeçmişleriToolStripMenuItem.Name = "emanetGeçmişleriToolStripMenuItem";
            this.emanetGeçmişleriToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.emanetGeçmişleriToolStripMenuItem.Text = "Emanet Geçmişleri";
            this.emanetGeçmişleriToolStripMenuItem.Click += new System.EventHandler(this.emanetGeçmişleriToolStripMenuItem_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.emanetlerBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 24);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(784, 513);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // emanetlerBindingSource
            // 
            this.emanetlerBindingSource.DataMember = "Emanetler";
            this.emanetlerBindingSource.DataSource = this.emanetlerDataSet;
            // 
            // emanetlerDataSet
            // 
            this.emanetlerDataSet.DataSetName = "EmanetlerDataSet";
            this.emanetlerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colemanet_id,
            this.colemanet_kitap,
            this.colemanet_uyetc,
            this.colemanet_uye,
            this.colemanet_alım,
            this.colemanet_son,
            this.colemanet_say});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colemanet_id
            // 
            this.colemanet_id.Caption = "ID";
            this.colemanet_id.FieldName = "emanet_id";
            this.colemanet_id.Name = "colemanet_id";
            this.colemanet_id.Visible = true;
            this.colemanet_id.VisibleIndex = 0;
            this.colemanet_id.Width = 67;
            // 
            // colemanet_kitap
            // 
            this.colemanet_kitap.Caption = "Kitap Adı";
            this.colemanet_kitap.FieldName = "emanet_kitap";
            this.colemanet_kitap.Name = "colemanet_kitap";
            this.colemanet_kitap.Visible = true;
            this.colemanet_kitap.VisibleIndex = 1;
            this.colemanet_kitap.Width = 100;
            // 
            // colemanet_uyetc
            // 
            this.colemanet_uyetc.Caption = "Üye TC No";
            this.colemanet_uyetc.FieldName = "emanet_uyetc";
            this.colemanet_uyetc.Name = "colemanet_uyetc";
            this.colemanet_uyetc.Visible = true;
            this.colemanet_uyetc.VisibleIndex = 2;
            this.colemanet_uyetc.Width = 100;
            // 
            // colemanet_uye
            // 
            this.colemanet_uye.Caption = "Üye Adı";
            this.colemanet_uye.FieldName = "emanet_uye";
            this.colemanet_uye.Name = "colemanet_uye";
            this.colemanet_uye.Visible = true;
            this.colemanet_uye.VisibleIndex = 3;
            this.colemanet_uye.Width = 100;
            // 
            // colemanet_alım
            // 
            this.colemanet_alım.Caption = "Alım Tarihi";
            this.colemanet_alım.FieldName = "emanet_alım";
            this.colemanet_alım.Name = "colemanet_alım";
            this.colemanet_alım.Visible = true;
            this.colemanet_alım.VisibleIndex = 4;
            this.colemanet_alım.Width = 100;
            // 
            // colemanet_son
            // 
            this.colemanet_son.Caption = "Son Teslim Tarihi";
            this.colemanet_son.FieldName = "emanet_son";
            this.colemanet_son.Name = "colemanet_son";
            this.colemanet_son.Visible = true;
            this.colemanet_son.VisibleIndex = 5;
            this.colemanet_son.Width = 100;
            // 
            // colemanet_say
            // 
            this.colemanet_say.Caption = "Uzatma Hakkı (defa)";
            this.colemanet_say.FieldName = "emanet_say";
            this.colemanet_say.Name = "colemanet_say";
            this.colemanet_say.Visible = true;
            this.colemanet_say.VisibleIndex = 6;
            this.colemanet_say.Width = 105;
            // 
            // emanetlerTableAdapter
            // 
            this.emanetlerTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtAranan);
            this.groupBox2.Controls.Add(this.lblArananalan);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbAramaTuru);
            this.groupBox2.Location = new System.Drawing.Point(795, 288);
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
            this.lblArananalan.Size = new System.Drawing.Size(76, 20);
            this.lblArananalan.TabIndex = 8;
            this.lblArananalan.Text = "Kitap Adı:";
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
            this.Rad2.Size = new System.Drawing.Size(103, 24);
            this.Rad2.TabIndex = 1;
            this.Rad2.Text = "Üye TC No";
            this.Rad2.UseVisualStyleBackColor = true;
            this.Rad2.CheckedChanged += new System.EventHandler(this.Rad2_CheckedChanged);
            // 
            // rad1
            // 
            this.rad1.AutoSize = true;
            this.rad1.Checked = true;
            this.rad1.Location = new System.Drawing.Point(19, 30);
            this.rad1.Name = "rad1";
            this.rad1.Size = new System.Drawing.Size(90, 24);
            this.rad1.TabIndex = 0;
            this.rad1.TabStop = true;
            this.rad1.Text = "Kitap Adı";
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
            this.groupBox1.Controls.Add(this.cmb1);
            this.groupBox1.Controls.Add(this.txt2);
            this.groupBox1.Controls.Add(this.chk3);
            this.groupBox1.Controls.Add(this.chk2);
            this.groupBox1.Controls.Add(this.chk1);
            this.groupBox1.Controls.Add(this.btnara);
            this.groupBox1.Controls.Add(this.txt3);
            this.groupBox1.Location = new System.Drawing.Point(795, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 255);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Birebir Arama";
            // 
            // cmb1
            // 
            this.cmb1.DataSource = this.uyelerBindingSource;
            this.cmb1.DisplayMember = "uye_ad";
            this.cmb1.Enabled = false;
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Location = new System.Drawing.Point(6, 59);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(200, 28);
            this.cmb1.TabIndex = 13;
            this.cmb1.ValueMember = "uye_id";
            // 
            // uyelerBindingSource
            // 
            this.uyelerBindingSource.DataMember = "Uyeler";
            this.uyelerBindingSource.DataSource = this.uyelerDataSet;
            // 
            // uyelerDataSet
            // 
            this.uyelerDataSet.DataSetName = "UyelerDataSet";
            this.uyelerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt2
            // 
            this.txt2.Enabled = false;
            this.txt2.Location = new System.Drawing.Point(6, 119);
            this.txt2.Mask = "00/00/0000";
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(200, 26);
            this.txt2.TabIndex = 12;
            this.txt2.ValidatingType = typeof(System.DateTime);
            // 
            // chk3
            // 
            this.chk3.AutoSize = true;
            this.chk3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chk3.Location = new System.Drawing.Point(9, 153);
            this.chk3.Name = "chk3";
            this.chk3.Size = new System.Drawing.Size(142, 22);
            this.chk3.TabIndex = 10;
            this.chk3.Text = "Son Teslim Tarihi";
            this.chk3.UseVisualStyleBackColor = true;
            this.chk3.CheckedChanged += new System.EventHandler(this.chk3_CheckedChanged);
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chk2.Location = new System.Drawing.Point(9, 91);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(95, 22);
            this.chk2.TabIndex = 9;
            this.chk2.Text = "Alım Tarihi";
            this.chk2.UseVisualStyleBackColor = true;
            this.chk2.CheckedChanged += new System.EventHandler(this.chk2_CheckedChanged);
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chk1.Location = new System.Drawing.Point(9, 31);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(77, 22);
            this.chk1.TabIndex = 8;
            this.chk1.Text = "Üye Adı";
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
            // uyelerTableAdapter
            // 
            this.uyelerTableAdapter.ClearBeforeFill = true;
            // 
            // Emanetler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 537);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Emanetler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Emanetler";
            this.Load += new System.EventHandler(this.Emanetler_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emanetlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emanetlerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uyelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyelerDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem emanetVerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtlıÜyeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniÜyeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emanetAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem süresiniUzatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emanetİptalToolStripMenuItem;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private EmanetlerDataSet emanetlerDataSet;
        private System.Windows.Forms.BindingSource emanetlerBindingSource;
        private EmanetlerDataSetTableAdapters.EmanetlerTableAdapter emanetlerTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colemanet_id;
        private DevExpress.XtraGrid.Columns.GridColumn colemanet_kitap;
        private DevExpress.XtraGrid.Columns.GridColumn colemanet_uyetc;
        private DevExpress.XtraGrid.Columns.GridColumn colemanet_uye;
        private DevExpress.XtraGrid.Columns.GridColumn colemanet_alım;
        private DevExpress.XtraGrid.Columns.GridColumn colemanet_son;
        private DevExpress.XtraGrid.Columns.GridColumn colemanet_say;
        private System.Windows.Forms.ToolStripMenuItem emanetGeçmişleriToolStripMenuItem;
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
        private System.Windows.Forms.CheckBox chk3;
        private System.Windows.Forms.CheckBox chk2;
        private System.Windows.Forms.CheckBox chk1;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.MaskedTextBox txt3;
        private System.Windows.Forms.ComboBox cmb1;
        private UyelerDataSet uyelerDataSet;
        private System.Windows.Forms.BindingSource uyelerBindingSource;
        private UyelerDataSetTableAdapters.UyelerTableAdapter uyelerTableAdapter;
    }
}