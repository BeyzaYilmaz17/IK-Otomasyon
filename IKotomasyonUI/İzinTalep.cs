


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
    public partial class İzinTalep : Form
    {
        private readonly IzinService _izinService = new IzinService();
        private int _personelId = 1;

        public İzinTalep()
        {
            InitializeComponent();
        }

        private void IzinYonetimi_Load(object sender, EventArgs e)
        {
            //??
        }

        private void İzinTalep_Load(object sender, EventArgs e)
        {
            dtwIzinler.AutoGenerateColumns = false;
            GridAyarla();
            Listele();
            GunHesapla();
            KalanGunYaz();

            cmbIzinTuru.Items.Clear();
            cmbIzinTuru.Items.Add("Yıllık İzin");
            cmbIzinTuru.Items.Add("Mazeret İzni");
            cmbIzinTuru.Items.Add("Hastalık İzni");
            cmbIzinTuru.Items.Add("Ücretsiz İzin");

            cmbIzinTuru.SelectedIndex = 0;
        }

        private void GridAyarla()
        {
            dtwIzinler.Columns.Clear();

            dtwIzinler.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dtwIzinler.DefaultCellStyle.Font =
                new Font("Segoe UI", 9);

            dtwIzinler.RowTemplate.Height = 32;
            dtwIzinler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtwIzinler.MultiSelect = false;
            dtwIzinler.ReadOnly = true;
            dtwIzinler.AllowUserToAddRows = false;
            dtwIzinler.AllowUserToResizeRows = false;
            dtwIzinler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtwIzinler.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "IzinId",
                Visible = false
            });

            dtwIzinler.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PersonelAdSoyad",
                HeaderText = "Personel",
                FillWeight = 20
            });

            dtwIzinler.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Baslangic",
                HeaderText = "Başlangıç",
                DefaultCellStyle = { Format = "dd.MM.yyyy" },
                FillWeight = 15
            });

            dtwIzinler.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Bitis",
                HeaderText = "Bitiş",
                DefaultCellStyle = { Format = "dd.MM.yyyy" },
                FillWeight = 15
            });

            dtwIzinler.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Gun_sayisi",
                HeaderText = "Gün",
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter },
                FillWeight = 8
            });

            dtwIzinler.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Durum",
                HeaderText = "Durum",
                FillWeight = 12
            });

            dtwIzinler.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Aciklama",
                HeaderText = "Açıklama",
                FillWeight = 30
            });

            dtwIzinler.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "IzinTuru",
                HeaderText = "İzin Türü",
                FillWeight = 15
            });
        }

        private void Listele()
        {
            dtwIzinler.DataSource = _izinService.Listele();
        }

        private void GunHesapla()
        {
            int gun = (dtBitis.Value.Date - dtBaslangic.Value.Date).Days + 1;
            if (gun < 0) gun = 0;
            txtGunSayisi.Text = gun.ToString();
        }

        private void Baslangic_ValueChanged(object sender, EventArgs e)
        {
            GunHesapla();
        }

        private void dtBitis_ValueChanged(object sender, EventArgs e)
        {
            GunHesapla();
        }

        private void KalanGunYaz()
        {
            int kalan = _izinService.GetKalanGun(_personelId);
            lblKalanGun.Text = kalan.ToString();
        }

        private void btnTalepOlustur_Click(object sender, EventArgs e)
        {
            if (cmbIzinTuru.SelectedIndex == -1)
            {
                MessageBox.Show("İzin türü seçiniz.");
                return;
            }

            if (dtBitis.Value.Date < dtBaslangic.Value.Date)
            {
                MessageBox.Show("Bitiş tarihi başlangıçtan küçük olamaz.");
                return;
            }

            int gunSayisi = (dtBitis.Value.Date - dtBaslangic.Value.Date).Days + 1;

            var izin = new Izin
            {
                Personel_id = _personelId,
                Baslangic = dtBaslangic.Value.Date,
                Bitis = dtBitis.Value.Date,
                Gun_sayisi = gunSayisi,
                Durum = "Beklemede",
                Aciklama = "",
                IzinTuru = cmbIzinTuru.SelectedItem.ToString()
            };

            _izinService.Ekle(izin);

            MessageBox.Show("İzin talebi oluşturuldu (Beklemede)");

            Listele();
            KalanGunYaz();
        }
    }
    
}
