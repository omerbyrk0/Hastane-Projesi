namespace Hastane_Projesi
{
    partial class FrmGirisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            this.btn_hastagiriş = new System.Windows.Forms.Button();
            this.btn_doktorgiriş = new System.Windows.Forms.Button();
            this.btn_sekretergiriş = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_hastagiriş
            // 
            this.btn_hastagiriş.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_hastagiriş.BackgroundImage")));
            this.btn_hastagiriş.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_hastagiriş.Location = new System.Drawing.Point(61, 185);
            this.btn_hastagiriş.Name = "btn_hastagiriş";
            this.btn_hastagiriş.Size = new System.Drawing.Size(173, 162);
            this.btn_hastagiriş.TabIndex = 0;
            this.btn_hastagiriş.UseVisualStyleBackColor = true;
            this.btn_hastagiriş.Click += new System.EventHandler(this.btn_hastagiriş_Click);
            // 
            // btn_doktorgiriş
            // 
            this.btn_doktorgiriş.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_doktorgiriş.BackgroundImage")));
            this.btn_doktorgiriş.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_doktorgiriş.Location = new System.Drawing.Point(274, 185);
            this.btn_doktorgiriş.Name = "btn_doktorgiriş";
            this.btn_doktorgiriş.Size = new System.Drawing.Size(173, 162);
            this.btn_doktorgiriş.TabIndex = 0;
            this.btn_doktorgiriş.UseVisualStyleBackColor = true;
            this.btn_doktorgiriş.Click += new System.EventHandler(this.btn_doktorgiriş_Click);
            // 
            // btn_sekretergiriş
            // 
            this.btn_sekretergiriş.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sekretergiriş.BackgroundImage")));
            this.btn_sekretergiriş.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sekretergiriş.Location = new System.Drawing.Point(489, 185);
            this.btn_sekretergiriş.Name = "btn_sekretergiriş";
            this.btn_sekretergiriş.Size = new System.Drawing.Size(173, 162);
            this.btn_sekretergiriş.TabIndex = 0;
            this.btn_sekretergiriş.UseVisualStyleBackColor = true;
            this.btn_sekretergiriş.Click += new System.EventHandler(this.btn_sekretergiriş_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "HASTA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "DOKTOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "SEKRETER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(489, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(32, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(436, 55);
            this.label4.TabIndex = 3;
            this.label4.Text = "SEA GREEN HOSPİTAL";
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(706, 429);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sekretergiriş);
            this.Controls.Add(this.btn_doktorgiriş);
            this.Controls.Add(this.btn_hastagiriş);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmGirisler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sea Green Hospital Giriş";
            this.Load += new System.EventHandler(this.FrmGirisler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_hastagiriş;
        private System.Windows.Forms.Button btn_doktorgiriş;
        private System.Windows.Forms.Button btn_sekretergiriş;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

