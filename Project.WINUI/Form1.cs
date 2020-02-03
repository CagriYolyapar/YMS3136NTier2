using Project.BLL.DesignPatterns.GenericRepositoryPattern.ConcRep;
using Project.BLL.DesignPatterns.SingeltonPattern;
using Project.DAL.Context;
using Project.MODEL.Entities;
using Project.WINUI.CustomTools;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            userRep = new AppUserRepository();
        }
        AppUserRepository userRep;
        AppUser user;

        public void Temizle()
        {
            txtkullaniciadi.Text = txtkullanicisifresi.Text = txtMail.Text = string.Empty;
        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            if (!TextKontrol()) return;
            userRep.Add( new AppUser(txtkullaniciadi.Text,Crypto.Sifrele(txtkullanicisifresi.Text),txtMail.Text));
            KullaniciListele();
            Temizle();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            KullaniciListele();
        }
        public bool TextKontrol()
        {
            if (txtkullaniciadi.Text.Trim() == string.Empty && txtkullanicisifresi.Text.Trim() == string.Empty && txtMail.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Lütfen Boşluk bırakmayınız");
                return false;
            }
            return true;
        }
        private void KullaniciListele()
        {
            dgvKullanici.DataSource = userRep.GetAll();
            dgvKullanici.ClearSelection();
        }

        private void dgvKullanici_Click(object sender, EventArgs e)
        {
            if (dgvKullanici.SelectedRows.Count>0)
            {
                int id = Convert.ToInt32(dgvKullanici.SelectedRows[0].Cells["ID"].Value);
                user = userRep.Find(id);
                txtkullaniciadi.Text = user.UserName;
                txtkullanicisifresi.Text = Crypto.SifreCoz(user.Password);
                txtMail.Text = user.Email;
            }
        }

        private void btngec_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}