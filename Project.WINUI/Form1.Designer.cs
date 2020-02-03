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
            this.dgvKullanici = new System.Windows.Forms.DataGridView();
            this.txtkullaniciadi = new System.Windows.Forms.TextBox();
            this.txtkullanicisifresi = new System.Windows.Forms.TextBox();
            this.lblKullaniciadi = new System.Windows.Forms.Label();
            this.lblsifre = new System.Windows.Forms.Label();
            this.btnekle = new System.Windows.Forms.Button();
            this.btngec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKullanici
            // 
            this.dgvKullanici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullanici.Location = new System.Drawing.Point(28, 14);
            this.dgvKullanici.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKullanici.MultiSelect = false;
            this.dgvKullanici.Name = "dgvKullanici";
            this.dgvKullanici.RowHeadersWidth = 51;
            this.dgvKullanici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKullanici.Size = new System.Drawing.Size(992, 150);
            this.dgvKullanici.TabIndex = 0;
            this.dgvKullanici.Click += new System.EventHandler(this.dgvKullanici_Click);
            // 
            // txtkullaniciadi
            // 
            this.txtkullaniciadi.Location = new System.Drawing.Point(217, 198);
            this.txtkullaniciadi.Margin = new System.Windows.Forms.Padding(4);
            this.txtkullaniciadi.Multiline = true;
            this.txtkullaniciadi.Name = "txtkullaniciadi";
            this.txtkullaniciadi.Size = new System.Drawing.Size(340, 30);
            this.txtkullaniciadi.TabIndex = 1;
            // 
            // txtkullanicisifresi
            // 
            this.txtkullanicisifresi.Location = new System.Drawing.Point(217, 261);
            this.txtkullanicisifresi.Margin = new System.Windows.Forms.Padding(4);
            this.txtkullanicisifresi.Multiline = true;
            this.txtkullanicisifresi.Name = "txtkullanicisifresi";
            this.txtkullanicisifresi.Size = new System.Drawing.Size(340, 30);
            this.txtkullanicisifresi.TabIndex = 1;
            // 
            // lblKullaniciadi
            // 
            this.lblKullaniciadi.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblKullaniciadi.Location = new System.Drawing.Point(25, 198);
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
            this.lblsifre.Location = new System.Drawing.Point(25, 261);
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
            this.btnekle.Location = new System.Drawing.Point(99, 400);
            this.btnekle.Margin = new System.Windows.Forms.Padding(4);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(132, 40);
            this.btnekle.TabIndex = 3;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
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
            this.btngec.Click += new System.EventHandler(this.btngec_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(23, 317);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "EMAIL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(217, 315);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtMail.Multiline = true;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(340, 30);
            this.txtMail.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 466);
            this.Controls.Add(this.btngec);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.lblKullaniciadi);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtkullanicisifresi);
            this.Controls.Add(this.txtkullaniciadi);
            this.Controls.Add(this.dgvKullanici);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Kullanıcılar";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKullanici;
        private System.Windows.Forms.TextBox txtkullaniciadi;
        private System.Windows.Forms.TextBox txtkullanicisifresi;
        private System.Windows.Forms.Label lblKullaniciadi;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btngec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMail;
    }
}

