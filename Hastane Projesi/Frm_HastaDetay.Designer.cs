namespace Hastane_Projesi
{
    partial class Frm_HastaDetay
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lnk_bilgiduzenle = new System.Windows.Forms.LinkLabel();
            this.btn_randevual = new System.Windows.Forms.Button();
            this.richsıkayet = new System.Windows.Forms.RichTextBox();
            this.combodoktor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.combobrans = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_tc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_adsoyad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişi Bilgileri";
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Location = new System.Drawing.Point(147, 73);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(120, 23);
            this.lbl_tc.TabIndex = 0;
            this.lbl_tc.Text = "00000000000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "TC :";
            // 
            // lbl_adsoyad
            // 
            this.lbl_adsoyad.AutoSize = true;
            this.lbl_adsoyad.Location = new System.Drawing.Point(147, 40);
            this.lbl_adsoyad.Name = "lbl_adsoyad";
            this.lbl_adsoyad.Size = new System.Drawing.Size(83, 23);
            this.lbl_adsoyad.TabIndex = 0;
            this.lbl_adsoyad.Text = "Null Null";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADI SOYADI :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_id);
            this.groupBox2.Controls.Add(this.lnk_bilgiduzenle);
            this.groupBox2.Controls.Add(this.btn_randevual);
            this.groupBox2.Controls.Add(this.richsıkayet);
            this.groupBox2.Controls.Add(this.combodoktor);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.combobrans);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(13, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 423);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu İşlemleri";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(107, 35);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(142, 30);
            this.txt_id.TabIndex = 5;
            // 
            // lnk_bilgiduzenle
            // 
            this.lnk_bilgiduzenle.AutoSize = true;
            this.lnk_bilgiduzenle.Location = new System.Drawing.Point(16, 375);
            this.lnk_bilgiduzenle.Name = "lnk_bilgiduzenle";
            this.lnk_bilgiduzenle.Size = new System.Drawing.Size(157, 23);
            this.lnk_bilgiduzenle.TabIndex = 4;
            this.lnk_bilgiduzenle.TabStop = true;
            this.lnk_bilgiduzenle.Text = "Bilgileri Güncelle";
            this.lnk_bilgiduzenle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_bilgiduzenle_LinkClicked);
            // 
            // btn_randevual
            // 
            this.btn_randevual.Location = new System.Drawing.Point(107, 305);
            this.btn_randevual.Name = "btn_randevual";
            this.btn_randevual.Size = new System.Drawing.Size(142, 57);
            this.btn_randevual.TabIndex = 3;
            this.btn_randevual.Text = "Randevu Al";
            this.btn_randevual.UseVisualStyleBackColor = true;
            this.btn_randevual.Click += new System.EventHandler(this.btn_randevual_Click);
            // 
            // richsıkayet
            // 
            this.richsıkayet.Location = new System.Drawing.Point(107, 151);
            this.richsıkayet.Name = "richsıkayet";
            this.richsıkayet.Size = new System.Drawing.Size(142, 147);
            this.richsıkayet.TabIndex = 2;
            this.richsıkayet.Text = "";
            // 
            // combodoktor
            // 
            this.combodoktor.FormattingEnabled = true;
            this.combodoktor.Location = new System.Drawing.Point(107, 107);
            this.combodoktor.Name = "combodoktor";
            this.combodoktor.Size = new System.Drawing.Size(142, 31);
            this.combodoktor.TabIndex = 1;
            this.combodoktor.SelectedIndexChanged += new System.EventHandler(this.combodoktor_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Şikayet :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Doktor :";
            // 
            // combobrans
            // 
            this.combobrans.FormattingEnabled = true;
            this.combobrans.Location = new System.Drawing.Point(107, 70);
            this.combobrans.Name = "combobrans";
            this.combobrans.Size = new System.Drawing.Size(142, 31);
            this.combobrans.TabIndex = 1;
            this.combobrans.SelectedIndexChanged += new System.EventHandler(this.combobrans_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "İd :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Branş :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(331, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(683, 259);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Geçmişi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(677, 230);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(331, 297);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(674, 272);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Açık Randevular";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 26);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(668, 243);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // Frm_HastaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1026, 581);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_HastaDetay";
            this.Text = "Frm_HastaDetay";
            this.Load += new System.EventHandler(this.Frm_HastaDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_tc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_adsoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_randevual;
        private System.Windows.Forms.RichTextBox richsıkayet;
        private System.Windows.Forms.ComboBox combodoktor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combobrans;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.LinkLabel lnk_bilgiduzenle;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
    }
}