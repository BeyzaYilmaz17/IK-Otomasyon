using IKotomasyon.Entities; 
using IKotomasyon.BLL;
using IKotomasyonEntities;
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
    public partial class YöneticiIzinform : Form
    {
        private readonly IzinService _izinService = new IzinService();
        private int _secilenIzinId = 0;
        public YöneticiIzinform()
        {
            InitializeComponent();
        }

        private void YöneticiIzinform_Load(object sender, EventArgs e)
        {
            DetayTemizle();
            GridDoldur();
        }

        private void GridDoldur()
        {
            dgvIzinler.DataSource = null;

            var liste = _izinService.GetAll();
            dgvIzinler.DataSource = liste;


            if (dgvIzinler.Columns["Id"] != null) dgvIzinler.Columns["Id"].Visible = false;
            if (dgvIzinler.Columns["Personel_id"] != null) dgvIzinler.Columns["Personel_id"].Visible = false;
            if (dgvIzinler.Columns["PersonelAdi"] != null) dgvIzinler.Columns["PersonelAdi"].HeaderText = "Personel";
            if (dgvIzinler.Columns["Gun_sayisi"] != null) dgvIzinler.Columns["Gun_sayisi"].HeaderText = "Gün";
            if (dgvIzinler.Columns["IzinTuru"] != null) dgvIzinler.Columns["IzinTuru"].HeaderText = "İzin Türü";


            foreach (DataGridViewRow row in dgvIzinler.Rows)
            {
                if (row.Cells["Durum"]?.Value == null) continue;

                string durum = row.Cells["Durum"].Value.ToString();

                if (durum == "Beklemede")
                    row.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                else if (durum == "Onaylandı")
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                else if (durum == "Reddedildi")
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
            }
        }




        private void onaylabutton_Click(object sender, EventArgs e)
        {

            if (_secilenIzinId == 0)
            {
                MessageBox.Show("Lütfen bir izin seçin.");
                return;
            }

            _izinService.Onayla(_secilenIzinId);

            // Yenile
            DetayTemizle();
            GridDoldur();

            MessageBox.Show("İzin ONAYLANDI.");
        }

        private void reddetbutton_Click(object sender, EventArgs e)
        {
            if (_secilenIzinId == 0)
            {
                MessageBox.Show("Lütfen bir izin seçin.");
                return;
            }

            _izinService.Reddet(_secilenIzinId);

            // Yenile
            DetayTemizle();
            GridDoldur();

            MessageBox.Show("İzin REDDEDİLDİ.");
        }

        private void dgvIzinler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvIzinler.Rows[e.RowIndex];

            // 💎 ASIL OLAY
            Izin izin = row.DataBoundItem as Izin;
            if (izin == null) return;

            _secilenIzinId = izin.Id;

            txtPersonelAdi.Text = izin.PersonelAdi;
            txtGunSayisi.Text = izin.Gun_sayisi.ToString();
            rtbAciklama.Text = izin.Aciklama;

            SetComboText(cmbDepartman, izin.Departman);
            SetComboText(cmbIzinTuru, izin.IzinTuru);

            dtBaslangic.Value = izin.Baslangic;
            dtBitis.Value = izin.Bitis;

            bool beklemedeMi = izin.Durum == "Beklemede";
            btnOnayla.Enabled = beklemedeMi;
            btnReddet.Enabled = beklemedeMi;
        }

        private void SetComboText(ComboBox cmb, string text)
        {
            if (cmb == null) return;

            cmb.Items.Clear();

            if (!string.IsNullOrWhiteSpace(text))
            {
                cmb.Items.Add(text);
                cmb.SelectedIndex = 0;
            }
        }

        private void DetayTemizle()
        {
            _secilenIzinId = 0;

            txtPersonelAdi.Text = "";
            txtGunSayisi.Text = "";
            rtbAciklama.Text = "";

            cmbDepartman.Items.Clear();
            cmbIzinTuru.Items.Clear();

            dtBaslangic.Value = DateTime.Today;
            dtBitis.Value = DateTime.Today;

            btnOnayla.Enabled = false;
            btnReddet.Enabled = false;
        }
    }
}
