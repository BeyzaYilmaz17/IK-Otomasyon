using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IKotomasyon.BLL;
using IKotomasyon.Entities;

namespace IKotomasyon.UI
{
    public partial class DepartmanYönetimi : Form
    {
        private readonly DepartmanService service = new DepartmanService();
        private int secilenId = 0;

        public DepartmanYönetimi()
        {
            InitializeComponent();
        }

        private void DepartmanYönetimi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {

            lstDepartmanlar.DataSource = null;
            lstDepartmanlar.DataSource = service.Listele();
            lstDepartmanlar.DisplayMember = "DepartmanAd";
            lstDepartmanlar.ValueMember = "DepartmanId";

            secilenId = 0;
        }

        private void Temizle()
        {
            secilenId = 0;
            txtDepartman.Clear();
            txtAciklama.Clear();
            lstDepartmanlar.ClearSelected();
        }

        private void eklebutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDepartman.Text))
            {
                MessageBox.Show("Departman adı boş olamaz");
                return;
            }

            service.Ekle(new Departman
            {
                DepartmanAd = txtDepartman.Text.Trim(),
                Aciklama = txtAciklama.Text.Trim()
            });

            Listele();
            Temizle();
        }

        private void Güncellebutton_Click(object sender, EventArgs e)
        {
            if (secilenId == 0)
            {
                MessageBox.Show("Güncellenecek departman seçin");
                return;
            }

            service.Guncelle(new Departman
            {
                DepartmanId = secilenId,
                DepartmanAd = txtDepartman.Text.Trim(),
                Aciklama = txtAciklama.Text.Trim()
            });

            Listele();
            Temizle();
        }

        private void Silbutton_Click(object sender, EventArgs e)
        {
            if (secilenId == 0)
            {
                MessageBox.Show("Silinecek departman seçin");
                return;
            }

            service.Sil(secilenId);
            Listele();
            Temizle();
        }

        private void lstDepartmanlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDepartmanlar.SelectedItem == null) return;

            var d = (Departman)lstDepartmanlar.SelectedItem;

            secilenId = d.DepartmanId;
            txtDepartman.Text = d.DepartmanAd;
            txtAciklama.Text = d.Aciklama;
        }

       
    }
}
