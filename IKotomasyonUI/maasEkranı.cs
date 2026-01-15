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
    public partial class MaasEkranı : Form
    {
        private readonly MaasService _maasService = new MaasService();
        private readonly DepartmanService _departmanService = new DepartmanService();
        private readonly PersonelService _personelService = new PersonelService();

        public MaasEkranı()
        {
            InitializeComponent();
        }

        private void GridAyarla()
        {
            if (dgvMaas.DataSource == null || dgvMaas.Columns.Count == 0)
                return;

            dgvMaas.AutoGenerateColumns = true;

            dgvMaas.Columns["Id"].Visible = false;
            dgvMaas.Columns["PersonelId"].Visible = false;

            dgvMaas.Columns["PersonelAd"].Visible = false;
            dgvMaas.Columns["PersonelSoyad"].Visible = false;

            dgvMaas.Columns["PersonelAdSoyad"].HeaderText = "Personel";
            dgvMaas.Columns["Ay"].HeaderText = "Ay";
            dgvMaas.Columns["Yil"].HeaderText = "Yıl";
            dgvMaas.Columns["Brut_maas"].HeaderText = "Brüt Maaş";
            dgvMaas.Columns["Zam_orani"].HeaderText = "Zam (%)";
            dgvMaas.Columns["Zam_turu"].HeaderText = "Zam Türü";

            dgvMaas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void PersonelDoldur()
        {
            cmbPersonel.DataSource = _personelService.GetAll();
            cmbPersonel.DisplayMember = "AdSoyad";
            cmbPersonel.ValueMember = "PersonelId";
            cmbPersonel.SelectedIndex = -1;
        }

        private void DepartmanDoldur()
        {
            cmbDepartman.DataSource = _departmanService.GetAll();
            cmbDepartman.DisplayMember = "DepartmanAd";
            cmbDepartman.ValueMember = "DepartmanId";
            cmbDepartman.SelectedIndex = -1;
        }

        private void MaaslariYukle()
        {
            dgvMaas.DataSource = _maasService.GetAllWithPersonel();
            dgvMaas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

       
        private void MaasHesapla()
        {
            if (!decimal.TryParse(txtBrutMaas.Text, out decimal brut))
                return;

            decimal.TryParse(txtZamOrani.Text, out decimal zamOrani);
            decimal yeniMaas = brut;

            if (cmbZamTuru.SelectedItem.ToString() == "Yüzdelik Zam")
                yeniMaas = brut + (brut * zamOrani / 100);
            else if (cmbZamTuru.SelectedItem.ToString() == "Sabit Zam")
                yeniMaas = brut + zamOrani;

            decimal sgk = yeniMaas * 0.14m;
            decimal gelirVergisi = yeniMaas * 0.15m;
            decimal damgaVergisi = yeniMaas * 0.00759m;

            decimal toplamKesinti = sgk + gelirVergisi + damgaVergisi;
            decimal netMaas = yeniMaas - toplamKesinti;

            txtYeniMaas.Text = yeniMaas.ToString("0.00");
            txtsgk.Text = sgk.ToString("0.00");
            txtGelirVergisi.Text = gelirVergisi.ToString("0.00");
            txtDamgaVergisi.Text = damgaVergisi.ToString("0.00");
            txtToplamKesinti.Text = toplamKesinti.ToString("0.00");
            txtNetMaas.Text = netMaas.ToString("0.00");
        }

        private void txtZamOrani_TextChanged(object sender, EventArgs e)
        {
            MaasHesapla();
        }

        private void cmbPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbPersonel.SelectedItem == null) return;
            if (!(cmbPersonel.SelectedItem is Personel)) return;

            var secilen = (Personel)cmbPersonel.SelectedItem;

            txtPozisyon.Text = secilen.Pozisyon;
            cmbDepartman.SelectedValue = secilen.DepartmanId;

            int personelId = secilen.PersonelId;

            var sonMaas = _maasService.GetSonMaas(personelId);

            if (sonMaas == null)
            {
                // 🔹 İLK MAAŞ MODU
                txtBrutMaas.Text = "";
                txtZamOrani.Text = "";
                cmbZamTuru.SelectedIndex = -1;
                txtYeniMaas.Text = "";

                btnEkle.Enabled = true;
                btnZamYap.Enabled = false;
            }
            else
            {
                // 🔹 ZAM MODU
                txtBrutMaas.Text = sonMaas.Brut_maas.ToString("0.00");
                txtZamOrani.Text = "";
                cmbZamTuru.SelectedIndex = -1;
                txtYeniMaas.Text = "";

                btnEkle.Enabled = false;
                btnZamYap.Enabled = true;
            }
        }      

        private void MaasEkranı_Load(object sender, EventArgs e)
        {
            GridAyarla();
            MaaslariYukle();
            PersonelDoldur();
            DepartmanDoldur();
      
        }

        private void cmbZamTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaaslariYukle();
        }

        private void btnZamYap_Click(object sender, EventArgs e)
        {

            if (!decimal.TryParse(txtBrutMaas.Text, out decimal eskiBrut))
                return;

            if (!decimal.TryParse(txtZamOrani.Text, out decimal zamOrani))
            {
                MessageBox.Show("Geçerli zam oranı gir");
                return;
            }

            decimal yeniBrut = eskiBrut + (eskiBrut * zamOrani / 100);
            MaasDetaylariniHesapla(yeniBrut);

            var personel = (Personel)cmbPersonel.SelectedItem;

            Maas m = new Maas
            {
                Personel_id = personel.PersonelId,
                Brut_maas = yeniBrut,
                Zam_orani = zamOrani,
                Zam_turu = cmbZamTuru.SelectedItem.ToString(),
                Ay = DateTime.Now.Month,
                Yil = DateTime.Now.Year,
            };

            _maasService.Ekle(m);
            MaaslariYukle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvMaas.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvMaas.CurrentRow.Cells["Id"].Value);
            _maasService.Sil(id);
            MaaslariYukle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cmbPersonel.SelectedItem == null)
            {
                MessageBox.Show("Personel seç");
                return;
            }

            if (!decimal.TryParse(txtMaas.Text, out decimal brutMaas))
            {
                MessageBox.Show("Geçerli maaş gir");
                return;
            }

            MaasDetaylariniHesapla(brutMaas);

            var personel = (Personel)cmbPersonel.SelectedItem;

            Maas m = new Maas
            {
                Personel_id = personel.PersonelId,
                Brut_maas = brutMaas,
                Zam_orani = 0,
                Zam_turu = "İlk Maaş",
                Ay = DateTime.Now.Month,
                Yil = DateTime.Now.Year,
            };

            _maasService.Ekle(m);
            MaaslariYukle();
        }

        private void MaasDetaylariniHesapla(decimal brutMaas)
        {
            decimal sgk = brutMaas * 0.14m;
            decimal gelirVergisi = brutMaas * 0.15m;
            decimal damgaVergisi = brutMaas * 0.00759m;

            decimal toplamKesinti = sgk + gelirVergisi + damgaVergisi;
            decimal netMaas = brutMaas - toplamKesinti;

            txtBrutMaas.Text = brutMaas.ToString("0.00");
            txtsgk.Text = sgk.ToString("0.00");
            txtGelirVergisi.Text = gelirVergisi.ToString("0.00");
            txtDamgaVergisi.Text = damgaVergisi.ToString("0.00");
            txtToplamKesinti.Text = toplamKesinti.ToString("0.00");
            txtNetMaas.Text = netMaas.ToString("0.00");
        }

    }
}