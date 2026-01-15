using IKotomasyon.BLL;
using IKotomasyon.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IKotomasyon.UI
{
    public partial class PersonelListe : Form
    {
        private readonly DepartmanService _departmanService = new DepartmanService();
        private readonly PersonelService _personelService = new PersonelService();

        public PersonelListe()
        {
            InitializeComponent();
        }

        private void PersonelListe_Load(object sender, EventArgs e)
        {
            ComboboxDoldur();
            GridAyarla();
            PersonelGetir();
        }

        private void ComboboxDoldur()
        {
            var departmanlar = _departmanService.GetAll();

            departmanlar.Insert(0, new Departman { DepartmanId = 0, DepartmanAd = "Tümü" });

            cmbDepartman.DataSource = departmanlar;
            cmbDepartman.DisplayMember = "DepartmanAd";
            cmbDepartman.ValueMember = "DepartmanId";
            cmbDepartman.SelectedIndex = 0;

            cmbDurum.Items.Clear();
            cmbDurum.Items.Add("Tümü");
            cmbDurum.Items.Add("Aktif");
            cmbDurum.Items.Add("Pasif");
            cmbDurum.SelectedIndex = 0;
        }

        private void GridAyarla()
        {
            dgvPersoneller.AutoGenerateColumns = true;
            dgvPersoneller.ReadOnly = true;
            dgvPersoneller.MultiSelect = false;
            dgvPersoneller.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPersoneller.AllowUserToAddRows = false;
            dgvPersoneller.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void PersonelGetir()
        {
            int depId = Convert.ToInt32(cmbDepartman.SelectedValue);
            int? departmanId = depId == 0 ? (int?)null : depId;

            string durum = cmbDurum.SelectedItem?.ToString() ?? "Tümü";

            var liste = _personelService.GetPersonelListe(departmanId, durum);

            dgvPersoneller.DataSource = null;
            dgvPersoneller.DataSource = liste;

            if (dgvPersoneller.Columns["PersonelId"] != null)
                dgvPersoneller.Columns["PersonelId"].HeaderText = "ID";

            if (dgvPersoneller.Columns["AdSoyad"] != null)
                dgvPersoneller.Columns["AdSoyad"].HeaderText = "Ad Soyad";
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            PersonelGetir();
        }
    }
}
