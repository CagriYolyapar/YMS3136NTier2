using Project.BLL.DesignPatterns.GenericRepositoryPattern.ConcRep;
using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.WINUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            cat = new CategoryRepository();
        }
        CategoryRepository cat;
        Category modify;

        public bool TextKontrol()
        {
            if (txtIsim.Text.Trim() == string.Empty && txtAciklama.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Alanları boş bırakmayınız");
                return false;
            }
            return true;
        }
        public void Listele()
        {
            dgvKategoriler.DataSource = cat.GetAll();
            txtIsim.Text = txtAciklama.Text = string.Empty;
            dgvKategoriler.ClearSelection();
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            if (!TextKontrol()) return;
            cat.Add(new Category(txtIsim.Text, txtAciklama.Text));
            Listele();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnAktifler_Click(object sender, EventArgs e)
        {
            dgvKategoriler.DataSource = cat.GetActives();
        }

        private void btnSilinenler_Click(object sender, EventArgs e)
        {
            dgvKategoriler.DataSource = cat.GetPassive();
        }

        private void btnGuncellenenler_Click(object sender, EventArgs e)
        {
            dgvKategoriler.DataSource = cat.GetUpdateds();
        }

        

        private void dgvKategoriler_Click(object sender, EventArgs e)
        {
            if (dgvKategoriler.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvKategoriler.SelectedRows[0].Cells["ID"].Value);
                modify = cat.Find(id);
                txtIsim.Text = modify.CategoryName;
                txtAciklama.Text = modify.Description;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (modify == null)
            {
                MessageBox.Show("Lütfen silinecek veriyi seçiniz");
                return;
            }
            cat.Delete(modify);
            modify = null;
            Listele();
        }

        private void btnYokEt_Click(object sender, EventArgs e)
        {
            if (modify is null)
            {
                MessageBox.Show("Lütfen kaldırılacak veriyi seçin");
                return;
            }
            cat.Destroy(modify);
            modify = null;
            Listele();
            
           
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (modify is null)
            {
                MessageBox.Show("Lütfen güncellenecek veriyi seçiniz.");
                return;
            }
            modify.CategoryName = txtIsim.Text;
            modify.Description = txtAciklama.Text;
            cat.Updated(modify);
            modify = null;
            Listele();
        }
    }
}
