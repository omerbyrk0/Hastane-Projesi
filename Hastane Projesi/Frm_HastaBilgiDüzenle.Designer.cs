namespace Hastane_Projesi
{
    partial class Frm_HastaBilgiDüzenle
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
            this.btn_kayıt = new System.Windows.Forms.Button();
            this.combocinsiyet = new System.Windows.Forms.ComboBox();
            this.msktel = new System.Windows.Forms.MaskedTextBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_kayıt
            // 
            this.btn_kayıt.BackColor = System.Drawing.Color.Lime;
            this.btn_kayıt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayıt.Location = new System.Drawing.Point(175, 268);
            this.btn_kayıt.Name = "btn_kayıt";
            this.btn_kayıt.Size = new System.Drawing.Size(148, 45);
            this.btn_kayıt.TabIndex = 6;
            this.btn_kayıt.Text = "GÜNCELLE";
            this.btn_kayıt.UseVisualStyleBackColor = false;
            this.btn_kayıt.Click += new System.EventHandler(this.btn_kayıt_Click);
            // 
            // combocinsiyet
            // 
            this.combocinsiyet.FormattingEnabled = true;
            this.combocinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.combocinsiyet.Location = new System.Drawing.Point(175, 228);
            this.combocinsiyet.Name = "combocinsiyet";
            this.combocinsiyet.Size = new System.Drawing.Size(148, 24);
            this.combocinsiyet.TabIndex = 5;
            // 
            // msktel
            // 
            this.msktel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktel.Location = new System.Drawing.Point(175, 156);
            this.msktel.Mask = "(999) 000-0000";
            this.msktel.Name = "msktel";
            this.msktel.Size = new System.Drawing.Size(148, 30);
            this.msktel.TabIndex = 3;
            // 
            // msktc
            // 
            this.msktc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktc.Location = new System.Drawing.Point(175, 120);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(148, 30);
            this.msktc.TabIndex = 2;
            this.msktc.ValidatingType = typeof(int);
            this.msktc.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.msktc_MaskInputRejected);
            // 
            // txt_ad
            // 
            this.txt_ad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ad.Location = new System.Drawing.Point(175, 48);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(148, 30);
            this.txt_ad.TabIndex = 0;
            this.txt_ad.TextChanged += new System.EventHandler(this.txt_ad_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(102, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Adı :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_soyad
            // 
            this.txt_soyad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_soyad.Location = new System.Drawing.Point(175, 84);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(148, 30);
            this.txt_soyad.TabIndex = 1;
            this.txt_soyad.TextChanged += new System.EventHandler(this.txt_soyad_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(75, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Soyadı :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_sifre
            // 
            this.txt_sifre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sifre.Location = new System.Drawing.Point(175, 192);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(148, 30);
            this.txt_sifre.TabIndex = 4;
            this.txt_sifre.TextChanged += new System.EventHandler(this.txt_sifre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(62, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cinsiyet :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(68, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Telefon :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(90, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Şifre :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "TC Kimlik No :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Frm_HastaBilgiDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(384, 376);
            this.Controls.Add(this.btn_kayıt);
            this.Controls.Add(this.combocinsiyet);
            this.Controls.Add(this.msktel);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_HastaBilgiDüzenle";
            this.Text = "Frm_HastaBilgiDüzenle";
            this.Load += new System.EventHandler(this.Frm_HastaBilgiDüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kayıt;
        private System.Windows.Forms.ComboBox combocinsiyet;
        private System.Windows.Forms.MaskedTextBox msktel;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}