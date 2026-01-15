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
using System.Windows.Forms.DataVisualization.Charting;

namespace IKotomasyon.UI
{
    public partial class Performans : Form
    {
        private readonly PerformansService _perfService = new PerformansService();
        private readonly DepartmanService _departmanService = new DepartmanService();
        private readonly PersonelService _personelService = new PersonelService();

        private int? _seciliPerformansId = null;

        public Performans()
        {
            InitializeComponent();
        }

        private void DepartmanlariDoldur()
        {
            var departmanlar = _departmanService.GetAll();
          
            cmbDepartman.DataSource = departmanlar;
            cmbDepartman.DisplayMember = "DepartmanAd";
            cmbDepartman.ValueMember = "DepartmanId";
            cmbDepartman.SelectedIndex = -1; 
        }

        private void PuanCombolariniDoldur()
        {
            cmbTakim.Items.Clear();
            cmbVerimlilik.Items.Clear();
            cmbGelisim.Items.Clear();

            for (int i = 1; i <= 5; i++)
            {
                cmbTakim.Items.Add(i);
                cmbVerimlilik.Items.Add(i);
                cmbGelisim.Items.Add(i);
            }

            cmbTakim.SelectedIndex = -1;
            cmbVerimlilik.SelectedIndex = -1;
            cmbGelisim.SelectedIndex = -1;
        }

              
        private void ChartHazirla()
        {
            chartDepartman.Series.Clear();
            chartDepartman.ChartAreas.Clear();
            chartDepartman.Legends.Clear();

            var area = new System.Windows.Forms.DataVisualization.Charting.ChartArea("A1");
            area.AxisX.Interval = 1;
            area.AxisX.Title = "Departman";
            area.AxisY.Title = "Ortalama Puan";
            chartDepartman.ChartAreas.Add(area);

            var s = new System.Windows.Forms.DataVisualization.Charting.Series("Performans");
            s.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            s.IsValueShownAsLabel = true;
            chartDepartman.Series.Add(s);

           
            chartDepartman.Legends.Add(new System.Windows.Forms.DataVisualization.Charting.Legend("L1") { Enabled = false });
        }
        

        private void ChartDoldur()
        {
            var data = _perfService.GetDepartmanOrtalamalari();
            var s = chartDepartman.Series["Performans"];

            s.Points.Clear();

            if (data.Count == 0)
            {
                s.Points.AddXY("Veri yok", 0);
                return;
            }

            foreach (var item in data)
            {
                s.Points.AddXY(item.DepartmanAdi, item.OrtalamaPuan);
            }
        }

       

        private void Temizle()
        {
            _seciliPerformansId = null;
            cmbTakim.SelectedIndex = -1;
            cmbVerimlilik.SelectedIndex = -1;
            cmbGelisim.SelectedIndex = -1;
            txtAciklama.Clear();
        }

        private void btnYenile_Click_1(object sender, EventArgs e)
        {
            PuanCombolariniDoldur();
            DepartmanlariDoldur();            
            ChartDoldur();
            Temizle();
        }

        private void Performans_Load_1(object sender, EventArgs e)
        {

            PuanCombolariniDoldur();
            DepartmanlariDoldur();         
            ChartHazirla();
            ChartDoldur();

        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (cmbDepartman.SelectedIndex == -1 || cmbPersonel.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen departman ve personel seçin.");
                return;
            }

            if (cmbTakim.SelectedIndex == -1 ||
                cmbVerimlilik.SelectedIndex == -1 ||
                cmbGelisim.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm performans puanlarını (1-5) seçin.");
                return;
            }

            int departmanId = Convert.ToInt32(cmbDepartman.SelectedValue);
            int personelId = Convert.ToInt32(cmbPersonel.SelectedValue);

            var kayit = new IKotomasyon.Entities.PerformansKaydi
            {
                PersonelId = personelId,
                DepartmanId = departmanId,
                TakimCalismasi = Convert.ToInt32(cmbTakim.SelectedItem),
                Verimlilik = Convert.ToInt32(cmbVerimlilik.SelectedItem),
                Gelisim = Convert.ToInt32(cmbGelisim.SelectedItem),
                Aciklama = txtAciklama.Text 
            };

            _perfService.Ekle(kayit);

            MessageBox.Show("Değerlendirme eklendi.");

            Temizle();
            ChartDoldur();
        }

        private void cmbPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }

        private void cmbDepartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDepartman.SelectedIndex == -1)
                return;

            var departman = (IKotomasyon.Entities.Departman)cmbDepartman.SelectedItem;
            int departmanId = departman.DepartmanId;

            var personeller = _personelService.GetByDepartman(departmanId);

            cmbPersonel.DataSource = null;
            cmbPersonel.DataSource = personeller;
            cmbPersonel.DisplayMember = "AdSoyad";
            cmbPersonel.ValueMember = "personelId";
            cmbPersonel.SelectedIndex = -1;
        }
    }


}
