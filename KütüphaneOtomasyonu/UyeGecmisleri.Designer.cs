namespace KütüphaneOtomasyonu
{
    partial class UyeGecmisleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeGecmisleri));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.uyeGecmisleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uyeGecmisleriDataSet = new KütüphaneOtomasyonu.UyeGecmisleriDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colgecmis_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgecmis_acıklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgecmis_detay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgecmis_saat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgecmis_tarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.uyeGecmisleriTableAdapter = new KütüphaneOtomasyonu.UyeGecmisleriDataSetTableAdapters.UyeGecmisleriTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeGecmisleriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeGecmisleriDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.gridControl1.DataSource = this.uyeGecmisleriBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(784, 513);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // uyeGecmisleriBindingSource
            // 
            this.uyeGecmisleriBindingSource.DataMember = "UyeGecmisleri";
            this.uyeGecmisleriBindingSource.DataSource = this.uyeGecmisleriDataSet;
            // 
            // uyeGecmisleriDataSet
            // 
            this.uyeGecmisleriDataSet.DataSetName = "UyeGecmisleriDataSet";
            this.uyeGecmisleriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colgecmis_id,
            this.colgecmis_acıklama,
            this.colgecmis_detay,
            this.colgecmis_saat,
            this.colgecmis_tarih});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colgecmis_id
            // 
            this.colgecmis_id.Caption = "ID";
            this.colgecmis_id.FieldName = "gecmis_id";
            this.colgecmis_id.Name = "colgecmis_id";
            this.colgecmis_id.Visible = true;
            this.colgecmis_id.VisibleIndex = 0;
            this.colgecmis_id.Width = 59;
            // 
            // colgecmis_acıklama
            // 
            this.colgecmis_acıklama.Caption = "Açıklama";
            this.colgecmis_acıklama.FieldName = "gecmis_acıklama";
            this.colgecmis_acıklama.Name = "colgecmis_acıklama";
            this.colgecmis_acıklama.Visible = true;
            this.colgecmis_acıklama.VisibleIndex = 1;
            this.colgecmis_acıklama.Width = 173;
            // 
            // colgecmis_detay
            // 
            this.colgecmis_detay.Caption = "Detay";
            this.colgecmis_detay.FieldName = "gecmis_detay";
            this.colgecmis_detay.Name = "colgecmis_detay";
            this.colgecmis_detay.Visible = true;
            this.colgecmis_detay.VisibleIndex = 2;
            this.colgecmis_detay.Width = 173;
            // 
            // colgecmis_saat
            // 
            this.colgecmis_saat.Caption = "Saat";
            this.colgecmis_saat.FieldName = "gecmis_saat";
            this.colgecmis_saat.Name = "colgecmis_saat";
            this.colgecmis_saat.Visible = true;
            this.colgecmis_saat.VisibleIndex = 3;
            this.colgecmis_saat.Width = 173;
            // 
            // colgecmis_tarih
            // 
            this.colgecmis_tarih.Caption = "Tarih";
            this.colgecmis_tarih.FieldName = "gecmis_tarih";
            this.colgecmis_tarih.Name = "colgecmis_tarih";
            this.colgecmis_tarih.Visible = true;
            this.colgecmis_tarih.VisibleIndex = 4;
            this.colgecmis_tarih.Width = 181;
            // 
            // uyeGecmisleriTableAdapter
            // 
            this.uyeGecmisleriTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtAranan);
            this.groupBox2.Controls.Add(this.lblArananalan);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbAramaTuru);
            this.groupBox2.Location = new System.Drawing.Point(794, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 249);
            this.groupBox2.TabIndex = 14;
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
            this.Rad2.Size = new System.Drawing.Size(69, 24);
            this.Rad2.TabIndex = 1;
            this.Rad2.Text = "Detay";
            this.Rad2.UseVisualStyleBackColor = true;
            this.Rad2.CheckedChanged += new System.EventHandler(this.Rad2_CheckedChanged);
            // 
            // rad1
            // 
            this.rad1.AutoSize = true;
            this.rad1.Checked = true;
            this.rad1.Location = new System.Drawing.Point(19, 30);
            this.rad1.Name = "rad1";
            this.rad1.Size = new System.Drawing.Size(91, 24);
            this.rad1.TabIndex = 0;
            this.rad1.TabStop = true;
            this.rad1.Text = "Açıklama";
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
            this.groupBox1.Location = new System.Drawing.Point(794, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 255);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Birebir Arama";
            // 
            // txt2
            // 
            this.txt2.Enabled = false;
            this.txt2.Location = new System.Drawing.Point(6, 119);
            this.txt2.Mask = "00:00";
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(200, 26);
            this.txt2.TabIndex = 12;
            this.txt2.ValidatingType = typeof(System.DateTime);
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
            this.chk3.Size = new System.Drawing.Size(60, 22);
            this.chk3.TabIndex = 10;
            this.chk3.Text = "Tarih";
            this.chk3.UseVisualStyleBackColor = true;
            this.chk3.CheckedChanged += new System.EventHandler(this.chk3_CheckedChanged);
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chk2.Location = new System.Drawing.Point(9, 91);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(57, 22);
            this.chk2.TabIndex = 9;
            this.chk2.Text = "Saat";
            this.chk2.UseVisualStyleBackColor = true;
            this.chk2.CheckedChanged += new System.EventHandler(this.chk2_CheckedChanged);
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chk1.Location = new System.Drawing.Point(9, 31);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(87, 22);
            this.chk1.TabIndex = 8;
            this.chk1.Text = "Açıklama";
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
            // UyeGecmisleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 513);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "UyeGecmisleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Üye İşlem Geçmişleri";
            this.Load += new System.EventHandler(this.UyeGecmisleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeGecmisleriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeGecmisleriDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private UyeGecmisleriDataSet uyeGecmisleriDataSet;
        private System.Windows.Forms.BindingSource uyeGecmisleriBindingSource;
        private UyeGecmisleriDataSetTableAdapters.UyeGecmisleriTableAdapter uyeGecmisleriTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colgecmis_id;
        private DevExpress.XtraGrid.Columns.GridColumn colgecmis_acıklama;
        private DevExpress.XtraGrid.Columns.GridColumn colgecmis_detay;
        private DevExpress.XtraGrid.Columns.GridColumn colgecmis_saat;
        private DevExpress.XtraGrid.Columns.GridColumn colgecmis_tarih;
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