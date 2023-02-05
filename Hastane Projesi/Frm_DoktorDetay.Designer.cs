namespace Hastane_Projesi
{
    partial class Frm_DoktorDetay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_tc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_adsoyad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richsikayet = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bt_cıkıs = new System.Windows.Forms.Button();
            this.btn_duyurular = new System.Windows.Forms.Button();
            this.btn_bilgiguncelle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_tc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_adsoyad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(336, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgileri";
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_tc.Location = new System.Drawing.Point(126, 69);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(108, 19);
            this.lbl_tc.TabIndex = 0;
            this.lbl_tc.Text = "00000000000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(8, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "TC :";
            // 
            // lbl_adsoyad
            // 
            this.lbl_adsoyad.AutoSize = true;
            this.lbl_adsoyad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_adsoyad.Location = new System.Drawing.Point(126, 37);
            this.lbl_adsoyad.Name = "lbl_adsoyad";
            this.lbl_adsoyad.Size = new System.Drawing.Size(79, 19);
            this.lbl_adsoyad.TabIndex = 0;
            this.lbl_adsoyad.Text = "Null Null";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(8, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADI SOYADI :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richsikayet);
            this.groupBox2.Location = new System.Drawing.Point(16, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 206);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Detay";
            // 
            // richsikayet
            // 
            this.richsikayet.Location = new System.Drawing.Point(12, 26);
            this.richsikayet.Name = "richsikayet";
            this.richsikayet.Size = new System.Drawing.Size(318, 160);
            this.richsikayet.TabIndex = 0;
            this.richsikayet.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(370, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(618, 507);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(612, 481);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bt_cıkıs);
            this.groupBox4.Controls.Add(this.btn_duyurular);
            this.groupBox4.Controls.Add(this.btn_bilgiguncelle);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(16, 384);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(336, 138);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hızlı Erişim";
            // 
            // bt_cıkıs
            // 
            this.bt_cıkıs.Location = new System.Drawing.Point(27, 70);
            this.bt_cıkıs.Name = "bt_cıkıs";
            this.bt_cıkıs.Size = new System.Drawing.Size(275, 50);
            this.bt_cıkıs.TabIndex = 0;
            this.bt_cıkıs.Text = "Çıkış";
            this.bt_cıkıs.UseVisualStyleBackColor = true;
            this.bt_cıkıs.Click += new System.EventHandler(this.bt_cıkıs_Click);
            // 
            // btn_duyurular
            // 
            this.btn_duyurular.Location = new System.Drawing.Point(175, 26);
            this.btn_duyurular.Name = "btn_duyurular";
            this.btn_duyurular.Size = new System.Drawing.Size(127, 38);
            this.btn_duyurular.TabIndex = 0;
            this.btn_duyurular.Text = "Duyurular";
            this.btn_duyurular.UseVisualStyleBackColor = true;
            this.btn_duyurular.Click += new System.EventHandler(this.btn_duyurular_Click);
            // 
            // btn_bilgiguncelle
            // 
            this.btn_bilgiguncelle.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_bilgiguncelle.Location = new System.Drawing.Point(27, 26);
            this.btn_bilgiguncelle.Name = "btn_bilgiguncelle";
            this.btn_bilgiguncelle.Size = new System.Drawing.Size(127, 38);
            this.btn_bilgiguncelle.TabIndex = 0;
            this.btn_bilgiguncelle.Text = "Bilgileri Düzenle";
            this.btn_bilgiguncelle.UseVisualStyleBackColor = true;
            this.btn_bilgiguncelle.Click += new System.EventHandler(this.btn_bilgiguncelle_Click);
            // 
            // Frm_DoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1000, 534);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_DoktorDetay";
            this.Text = "Frm_DoktorDetay";
            this.Load += new System.EventHandler(this.Frm_DoktorDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_tc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_adsoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richsikayet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bt_cıkıs;
        private System.Windows.Forms.Button btn_duyurular;
        private System.Windows.Forms.Button btn_bilgiguncelle;
    }
}