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
            this.btngec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdkukkanici)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrdkukkanici
            // 
            this.dtgrdkukkanici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdkukkanici.Location = new System.Drawing.Point(28, 14);
            this.dtgrdkukkanici.Margin = new System.Windows.Forms.Padding(4);
            this.dtgrdkukkanici.Name = "dtgrdkukkanici";
            this.dtgrdkukkanici.RowHeadersWidth = 51;
            this.dtgrdkukkanici.Size = new System.Drawing.Size(529, 150);
            this.dtgrdkukkanici.TabIndex = 0;
            // 
            // txtkullaniciadi
            // 
            this.txtkullaniciadi.Location = new System.Drawing.Point(220, 235);
            this.txtkullaniciadi.Margin = new System.Windows.Forms.Padding(4);
            this.txtkullaniciadi.Multiline = true;
            this.txtkullaniciadi.Name = "txtkullaniciadi";
            this.txtkullaniciadi.Size = new System.Drawing.Size(340, 30);
            this.txtkullaniciadi.TabIndex = 1;
            // 
            // txtkullanicisifresi
            // 
            this.txtkullanicisifresi.Location = new System.Drawing.Point(220, 298);
            this.txtkullanicisifresi.Margin = new System.Windows.Forms.Padding(4);
            this.txtkullanicisifresi.Multiline = true;
            this.txtkullanicisifresi.Name = "txtkullanicisifresi";
            this.txtkullanicisifresi.Size = new System.Drawing.Size(340, 30);
            this.txtkullanicisifresi.TabIndex = 1;
            // 
            // lblKullaniciadi
            // 
            this.lblKullaniciadi.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblKullaniciadi.Location = new System.Drawing.Point(28, 235);
            this.lblKullaniciadi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKullaniciadi.Name = "lblKullaniciadi";
            this.lblKullaniciadi.Size = new System.Drawing.Size(157, 31);
            this.lblKullaniciadi.TabIndex = 2;
            this.lblKullaniciadi.Text = "KULLANICI ADI";
            this.lblKullaniciadi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblsifre
            // 
            this.lblsifre.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblsifre.Location = new System.Drawing.Point(28, 298);
            this.lblsifre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(157, 31);
            this.lblsifre.TabIndex = 2;
            this.lblsifre.Text = "ŞİFRE";
            this.lblsifre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnekle.Location = new System.Drawing.Point(334, 352);
            this.btnekle.Margin = new System.Windows.Forms.Padding(4);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(132, 40);
            this.btnekle.TabIndex = 3;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = false;
            // 
            // btngec
            // 
            this.btngec.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btngec.Location = new System.Drawing.Point(282, 400);
            this.btngec.Margin = new System.Windows.Forms.Padding(4);
            this.btngec.Name = "btngec";
            this.btngec.Size = new System.Drawing.Size(234, 40);
            this.btngec.TabIndex = 3;
            this.btngec.Text = "DİĞER FORMA GEÇ";
            this.btngec.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 466);
            this.Controls.Add(this.btngec);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.lblKullaniciadi);
            this.Controls.Add(this.txtkullanicisifresi);
            this.Controls.Add(this.txtkullaniciadi);
            this.Controls.Add(this.dtgrdkukkanici);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Kullanıcılar";
            this.Load += new System.EventHandler(this.Form1_Load_1);
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
        private System.Windows.Forms.Button btngec;
    }
}

