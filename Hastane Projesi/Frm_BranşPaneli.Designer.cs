namespace Hastane_Projesi
{
    partial class Frm_BranşPaneli
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
            this.btn_güncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_bransid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_bransad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_güncelle
            // 
            this.btn_güncelle.Location = new System.Drawing.Point(128, 175);
            this.btn_güncelle.Name = "btn_güncelle";
            this.btn_güncelle.Size = new System.Drawing.Size(149, 55);
            this.btn_güncelle.TabIndex = 34;
            this.btn_güncelle.Text = "Güncelle";
            this.btn_güncelle.UseVisualStyleBackColor = true;
            this.btn_güncelle.Click += new System.EventHandler(this.btn_güncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(203, 114);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(74, 55);
            this.btn_sil.TabIndex = 35;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(128, 114);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(74, 55);
            this.btn_ekle.TabIndex = 36;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(310, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(372, 206);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txt_bransid
            // 
            this.txt_bransid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_bransid.Location = new System.Drawing.Point(128, 24);
            this.txt_bransid.Name = "txt_bransid";
            this.txt_bransid.Size = new System.Drawing.Size(149, 30);
            this.txt_bransid.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(18, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 23);
            this.label6.TabIndex = 23;
            this.label6.Text = "Branş İd :";
            // 
            // txt_bransad
            // 
            this.txt_bransad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_bransad.Location = new System.Drawing.Point(128, 60);
            this.txt_bransad.Name = "txt_bransad";
            this.txt_bransad.Size = new System.Drawing.Size(149, 30);
            this.txt_bransad.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(18, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "Branş Adı :";
            // 
            // Frm_BranşPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(699, 253);
            this.Controls.Add(this.btn_güncelle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_bransid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_bransad);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_BranşPaneli";
            this.Text = "Frm_BranşPaneli";
            this.Load += new System.EventHandler(this.Frm_BranşPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_güncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_bransid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_bransad;
        private System.Windows.Forms.Label label5;
    }
}