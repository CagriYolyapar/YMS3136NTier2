namespace Project.WINUI
{
    partial class Form2
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
            this.btnYokEt = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnSilinenler = new System.Windows.Forms.Button();
            this.btnGuncellenenler = new System.Windows.Forms.Button();
            this.btnAktifler = new System.Windows.Forms.Button();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.btnKategoriEkle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.dgvKategoriler = new System.Windows.Forms.DataGridView();
            this.lblisim = new System.Windows.Forms.Label();
            this.lblaciklama = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoriler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYokEt
            // 
            this.btnYokEt.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnYokEt.Location = new System.Drawing.Point(435, 533);
            this.btnYokEt.Name = "btnYokEt";
            this.btnYokEt.Size = new System.Drawing.Size(197, 61);
            this.btnYokEt.TabIndex = 13;
            this.btnYokEt.Text = "YOK ET";
            this.btnYokEt.UseVisualStyleBackColor = false;
            this.btnYokEt.Click += new System.EventHandler(this.btnYokEt_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnGuncelle.Location = new System.Drawing.Point(228, 533);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(197, 61);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnSil.Location = new System.Drawing.Point(14, 533);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(197, 61);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnSilinenler
            // 
            this.btnSilinenler.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnSilinenler.Location = new System.Drawing.Point(1202, 526);
            this.btnSilinenler.Name = "btnSilinenler";
            this.btnSilinenler.Size = new System.Drawing.Size(242, 68);
            this.btnSilinenler.TabIndex = 10;
            this.btnSilinenler.Text = "SİLİNENLERİ LİSTELE";
            this.btnSilinenler.UseVisualStyleBackColor = false;
            this.btnSilinenler.Click += new System.EventHandler(this.btnSilinenler_Click);
            // 
            // btnGuncellenenler
            // 
            this.btnGuncellenenler.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnGuncellenenler.Location = new System.Drawing.Point(1202, 442);
            this.btnGuncellenenler.Name = "btnGuncellenenler";
            this.btnGuncellenenler.Size = new System.Drawing.Size(242, 68);
            this.btnGuncellenenler.TabIndex = 11;
            this.btnGuncellenenler.Text = "GÜNCELLENENLERİ LİSTELE";
            this.btnGuncellenenler.UseVisualStyleBackColor = false;
            this.btnGuncellenenler.Click += new System.EventHandler(this.btnGuncellenenler_Click);
            // 
            // btnAktifler
            // 
            this.btnAktifler.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnAktifler.Location = new System.Drawing.Point(1202, 359);
            this.btnAktifler.Name = "btnAktifler";
            this.btnAktifler.Size = new System.Drawing.Size(242, 68);
            this.btnAktifler.TabIndex = 12;
            this.btnAktifler.Text = "AKTİFLERİ LİSTELE";
            this.btnAktifler.UseVisualStyleBackColor = false;
            this.btnAktifler.Click += new System.EventHandler(this.btnAktifler_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(1202, 124);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(242, 34);
            this.txtAciklama.TabIndex = 8;
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(1202, 42);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(242, 34);
            this.txtIsim.TabIndex = 9;
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnKategoriEkle.Location = new System.Drawing.Point(1202, 184);
            this.btnKategoriEkle.Margin = new System.Windows.Forms.Padding(6);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.Size = new System.Drawing.Size(242, 68);
            this.btnKategoriEkle.TabIndex = 6;
            this.btnKategoriEkle.Text = "KATEGORİ EKLE";
            this.btnKategoriEkle.UseVisualStyleBackColor = false;
            this.btnKategoriEkle.Click += new System.EventHandler(this.btnKategoriEkle_Click);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnListele.Location = new System.Drawing.Point(1202, 264);
            this.btnListele.Margin = new System.Windows.Forms.Padding(6);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(242, 68);
            this.btnListele.TabIndex = 7;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // dgvKategoriler
            // 
            this.dgvKategoriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKategoriler.Location = new System.Drawing.Point(15, 15);
            this.dgvKategoriler.Margin = new System.Windows.Forms.Padding(6);
            this.dgvKategoriler.MultiSelect = false;
            this.dgvKategoriler.Name = "dgvKategoriler";
            this.dgvKategoriler.RowHeadersWidth = 51;
            this.dgvKategoriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKategoriler.Size = new System.Drawing.Size(1174, 495);
            this.dgvKategoriler.TabIndex = 5;
            this.dgvKategoriler.Click += new System.EventHandler(this.dgvKategoriler_Click);
            // 
            // lblisim
            // 
            this.lblisim.AutoSize = true;
            this.lblisim.Location = new System.Drawing.Point(1297, 15);
            this.lblisim.Name = "lblisim";
            this.lblisim.Size = new System.Drawing.Size(61, 29);
            this.lblisim.TabIndex = 16;
            this.lblisim.Text = "İSİM";
            // 
            // lblaciklama
            // 
            this.lblaciklama.AutoSize = true;
            this.lblaciklama.Location = new System.Drawing.Point(1267, 97);
            this.lblaciklama.Name = "lblaciklama";
            this.lblaciklama.Size = new System.Drawing.Size(130, 29);
            this.lblaciklama.TabIndex = 16;
            this.lblaciklama.Text = "AÇIKLAMA";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1472, 620);
            this.Controls.Add(this.lblaciklama);
            this.Controls.Add(this.lblisim);
            this.Controls.Add(this.btnYokEt);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnSilinenler);
            this.Controls.Add(this.btnGuncellenenler);
            this.Controls.Add(this.btnAktifler);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.btnKategoriEkle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dgvKategoriler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoriler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYokEt;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnSilinenler;
        private System.Windows.Forms.Button btnGuncellenenler;
        private System.Windows.Forms.Button btnAktifler;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Button btnKategoriEkle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.DataGridView dgvKategoriler;
        private System.Windows.Forms.Label lblisim;
        private System.Windows.Forms.Label lblaciklama;
    }
}