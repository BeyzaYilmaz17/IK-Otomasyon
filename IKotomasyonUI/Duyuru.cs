
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
    public partial class Duyuru : Form
    {
        private readonly DuyuruService _service = new DuyuruService();
        public Duyuru()
        {
            InitializeComponent();
        }

        private void Duyuru_Load(object sender, EventArgs e)
        {
            GridAyarla();
            DuyurulariYukle();
        }

        private void GridAyarla()
        {
            dgvDuyurular.AutoGenerateColumns = true;
            dgvDuyurular.ReadOnly = true;
            dgvDuyurular.AllowUserToAddRows = false;
            dgvDuyurular.AllowUserToDeleteRows = false;
            dgvDuyurular.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void DuyurulariYukle()
        {
            dgvDuyurular.DataSource = _service.DuyurulariGetir();

            dgvDuyurular.Dock = DockStyle.Fill;
            dgvDuyurular.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvDuyurular.DefaultCellStyle.Font =
                new Font("Segoe UI", 11);

            dgvDuyurular.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 12, FontStyle.Bold);

            dgvDuyurular.RowTemplate.Height = 35;

            dgvDuyurular.EnableHeadersVisualStyles = false;
            dgvDuyurular.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            dgvDuyurular.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvDuyurular.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(240, 240, 240);

            dgvDuyurular.Columns["Id"].Visible = false;
        }

        private void Temizle()
        {
            txtBaslik.Clear();
            txtIcerik.Clear();
            dtTarih.Value = DateTime.Now;
            dtSaat.Value = DateTime.Now;
        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtBaslik.Text) ||
                string.IsNullOrWhiteSpace(txtIcerik.Text))
            {
                MessageBox.Show("Başlık ve duyuru açıklaması boş olamaz.");
                return;
            }

            DateTime tarihSaat =
                dtTarih.Value.Date + dtSaat.Value.TimeOfDay;

            var duyuru = new DuyuruKayit
            {
                Baslik = txtBaslik.Text.Trim(),
                Icerik = txtIcerik.Text.Trim(),
                Tarih = tarihSaat
            };

            _service.DuyuruEkle(duyuru);

            MessageBox.Show("Duyuru eklendi.");

            Temizle();
            DuyurulariYukle();
        }
    }
}
