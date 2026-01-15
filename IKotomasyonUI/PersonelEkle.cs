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
    public partial class PersonelEkle : Form
    {
        PersonelService service = new PersonelService();

        private readonly DepartmanService _departmanService = new DepartmanService();


        public PersonelEkle()
        {
            InitializeComponent();
        }

        private void PersonelEkle_Load(object sender, EventArgs e)
        {
            Listele();

            cmbDurum.Items.Clear();
            cmbDurum.Items.Add("Aktif");
            cmbDurum.Items.Add("Pasif");
            cmbDurum.SelectedIndex = 0;

            cmbDepartman.DataSource = _departmanService.Listele();
            cmbDepartman.DisplayMember = "departmanAd";
            cmbDepartman.ValueMember = "departmanId";
        }

        private void Listele()
        {
            dtwPersonelTablo.DataSource = service.Listele();
            dtwPersonelTablo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dtwPersonelTablo.Columns.Contains("personelId"))
                dtwPersonelTablo.Columns["personelId"].Visible = false;

            if (dtwPersonelTablo.Columns.Contains("departmanId"))
                dtwPersonelTablo.Columns["departmanId"].Visible = false;
        }

        private void dtwPersonelTablo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dtwPersonelTablo.Rows[e.RowIndex];

            txtAd.Text = row.Cells["personelAd"].Value?.ToString();
            txtSoyad.Text = row.Cells["personelSoyad"].Value?.ToString();
            txtPozisyon.Text = row.Cells["pozisyon"].Value?.ToString();
            txtPosta.Text = row.Cells["Email"].Value?.ToString();
            txtTel.Text = row.Cells["Telefon"].Value?.ToString();
            cmbDepartman.SelectedValue = Convert.ToInt32(row.Cells["departmanId"].Value);
            cmbDurum.SelectedItem = row.Cells["durum"].Value?.ToString();

            dtBaslangic.Value = Convert.ToDateTime(row.Cells["iseGirisTarihi"].Value);
        }

        private void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtPozisyon.Clear();
            txtPosta.Clear();
            txtTel.Clear();
            cmbDurum.SelectedIndex = 0;
            dtBaslangic.Value = DateTime.Now;
        }

        private void btnekle_Click_1(object sender, EventArgs e)
        {
            Personel p = new Personel
            {
                PersonelAd = txtAd.Text,
                PersonelSoyad = txtSoyad.Text,
                Email = txtPosta.Text,
                Telefon = txtTel.Text,
                Pozisyon = txtPozisyon.Text,
                DepartmanId = Convert.ToInt32(cmbDepartman.SelectedValue),
                IseGirisTarihi = dtBaslangic.Value,
                Durum = cmbDurum.SelectedItem.ToString()
            };

            service.Ekle(p);
            Listele();
            Temizle();
        }

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            if (dtwPersonelTablo.CurrentRow == null) return;

            int id = Convert.ToInt32(dtwPersonelTablo.CurrentRow.Cells["personelId"].Value);

            Personel p = new Personel
            {
                PersonelId = id,
                PersonelAd = txtAd.Text,
                PersonelSoyad = txtSoyad.Text,
                Email = txtPosta.Text,
                Telefon = txtTel.Text,
                Pozisyon = txtPozisyon.Text,
                DepartmanId = Convert.ToInt32(cmbDepartman.SelectedValue),
                IseGirisTarihi = dtBaslangic.Value,
                Durum = cmbDurum.SelectedItem.ToString()
            };

            service.Guncelle(p);
            Listele();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            if (dtwPersonelTablo.CurrentRow == null) return;

            int id = Convert.ToInt32(dtwPersonelTablo.CurrentRow.Cells["personelId"].Value);
            service.Sil(id);
            Listele();
            Temizle();
        }
    }

}
