namespace Project.WINUI
{
    partial class Form1
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
            this.dtgrdkukkanici = new System.Windows.Forms.DataGridView();
            this.txtkullaniciadi = new System.Windows.Forms.TextBox();
            this.txtkullanicisifresi = new System.Windows.Forms.TextBox();
            this.lblKullaniciadi = new System.Windows.Forms.Label();
            this.lblsifre = new System.Windows.Forms.Label();
            this.btnekle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdkukkanici)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrdkukkanici
            // 
            this.dtgrdkukkanici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdkukkanici.Location = new System.Drawing.Point(23, 12);
            this.dtgrdkukkanici.Name = "dtgrdkukkanici";
            this.dtgrdkukkanici.RowHeadersWidth = 51;
            this.dtgrdkukkanici.Size = new System.Drawing.Size(529, 150);
            this.dtgrdkukkanici.TabIndex = 0;
            // 
            // txtkullaniciadi
            // 
            this.txtkullaniciadi.Location = new System.Drawing.Point(180, 196);
            this.txtkullaniciadi.Name = "txtkullaniciadi";
            this.txtkullaniciadi.Size = new System.Drawing.Size(340, 30);
            this.txtkullaniciadi.TabIndex = 1;
            // 
            // txtkullanicisifresi
            // 
            this.txtkullanicisifresi.Location = new System.Drawing.Point(180, 248);
            this.txtkullanicisifresi.Name = "txtkullanicisifresi";
            this.txtkullanicisifresi.Size = new System.Drawing.Size(340, 30);
            this.txtkullanicisifresi.TabIndex = 1;
            // 
            // lblKullaniciadi
            // 
            this.lblKullaniciadi.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblKullaniciadi.Location = new System.Drawing.Point(23, 196);
            this.lblKullaniciadi.Name = "lblKullaniciadi";
            this.lblKullaniciadi.Size = new System.Drawing.Size(112, 26);
            this.lblKullaniciadi.TabIndex = 2;
            this.lblKullaniciadi.Text = "Kullanıcı Adı";
            // 
            // lblsifre
            // 
            this.lblsifre.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblsifre.Location = new System.Drawing.Point(23, 248);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(112, 26);
            this.lblsifre.TabIndex = 2;
            this.lblsifre.Text = "Şifre";
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(273, 293);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(108, 33);
            this.btnekle.TabIndex = 3;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 413);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.lblKullaniciadi);
            this.Controls.Add(this.txtkullanicisifresi);
            this.Controls.Add(this.txtkullaniciadi);
            this.Controls.Add(this.dtgrdkukkanici);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Kullanıcılar";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdkukkanici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrdkukkanici;
        private System.Windows.Forms.TextBox txtkullaniciadi;
        private System.Windows.Forms.TextBox txtkullanicisifresi;
        private System.Windows.Forms.Label lblKullaniciadi;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.Button btnekle;
    }
}

