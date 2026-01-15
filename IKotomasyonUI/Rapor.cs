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
    public partial class Rapor : Form
    {
        private readonly RaporService _raporService = new RaporService();
        
        public Rapor()
        {
            InitializeComponent();
            this.Load += Rapor_Load;
        }


        private RaporFiltre FiltreOlustur()
        {
            RaporFiltre filtre = new RaporFiltre();

            filtre.Durum = cmbDurum.SelectedItem == null
                ? "Tümü"
                : cmbDurum.SelectedItem.ToString();

            filtre.Baslangic = dtBaslangic.Value.Date;
            filtre.Bitis = dtBitis.Value.Date;

            return filtre;
        }

        private void RaporYukle()
        {
            RaporFiltre filtre = FiltreOlustur();
            string konu = cmbRaporKonusu.SelectedItem?.ToString();

            //ÜST KARTLAR (HER ZAMAN)
            RaporOzet ozet = _raporService.GetOzet(filtre);

            lblToplamPersonel.Text = ozet.ToplamPersonel.ToString();
            lblOrtalamaMaas.Text = ozet.OrtalamaMaas.ToString("N2");
            lblBuAyIzinli.Text = ozet.BuAyIzinli.ToString();

            //TEMİZLE
            chartDepartman.Series.Clear();
            chartDepartman.ChartAreas.Clear();

            chartAktifPasif.Series.Clear();
            chartAktifPasif.ChartAreas.Clear();

            dgvDepartmanPerformans.DataSource = null;


            // RAPOR KONUSU
            if (konu == "Performans")
            {
                //COLUMN CHART
                ChartArea area = new ChartArea("Default");
                area.AxisX.Interval = 1;
                area.AxisX.LabelStyle.Angle = -45;
                area.AxisY.Minimum = 0;
                chartDepartman.ChartAreas.Add(area);

                Series s = new Series("Ortalama Performans");
                s.ChartType = SeriesChartType.Column;
                s.IsValueShownAsLabel = true;
                chartDepartman.Series.Add(s);

                List<DepartmanPerformans> perf =
                    _raporService.GetDepartmanPerformans();

                foreach (DepartmanPerformans p in perf)
                {
                    s.Points.AddXY(p.DepartmanAdi, p.OrtalamaPuan);
                }

                dgvDepartmanPerformans.DataSource = perf;
            }
            else if (konu == "İzin")
            {
                //PIE CHART 
                chartAktifPasif.ChartAreas.Add(new ChartArea("PieArea"));

                Series pie = new Series("İzin Durumu");
                pie.ChartType = SeriesChartType.Pie;
                pie.IsValueShownAsLabel = true;
                chartAktifPasif.Series.Add(pie);

                List<DurumDagilim> durumlar =
                    _raporService.GetDurumDagilim(filtre);

                foreach (DurumDagilim d in durumlar)
                {
                    pie.Points.AddXY(d.Durum, d.Adet);
                }
            }
        }


        private void Rapor_Load(object sender, EventArgs e)
        {
            cmbRaporKonusu.Items.Clear();
            cmbRaporKonusu.Items.Add("Personel");
            cmbRaporKonusu.Items.Add("Maaş");
            cmbRaporKonusu.Items.Add("İzin");
            cmbRaporKonusu.Items.Add("Performans");

            cmbRaporKonusu.SelectedIndex = 3; 
            cmbDurum.Items.Clear();
            cmbDurum.Items.Add("Tümü");
            cmbDurum.Items.Add("Aktif");
            cmbDurum.Items.Add("Pasif");
            cmbDurum.SelectedIndex = 0;
            dtBaslangic.Value = DateTime.Now.AddMonths(-1);
            dtBitis.Value = DateTime.Now;
            GridHazirla();         
            RaporYukle();
            AktifPasifPieDoldur();
        }

        private void btnUygula_Click(object sender, EventArgs e)
        {
            RaporYukle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {

            cmbDurum.SelectedIndex = 0;
            dtBaslangic.Value = DateTime.Now.AddMonths(-1);
            dtBitis.Value = DateTime.Now;

            RaporYukle();
        }


        private void GridHazirla()
        {
            dgvDepartmanPerformans.AutoGenerateColumns = false;
            dgvDepartmanPerformans.Columns.Clear();
           
            DataGridViewTextBoxColumn colDept = new DataGridViewTextBoxColumn();
            colDept.DataPropertyName = "DepartmanAdi";
            colDept.HeaderText = "Departman";
            colDept.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewTextBoxColumn colPuan = new DataGridViewTextBoxColumn();
            colPuan.DataPropertyName = "OrtalamaPuan";
            colPuan.HeaderText = "Ortalama Performans";
            colPuan.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvDepartmanPerformans.Columns.Add(colDept);
            dgvDepartmanPerformans.Columns.Add(colPuan); ;
        }

        private void cmbRaporKonusu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AktifPasifPieDoldur()
        {
            chartAktifPasif.Visible = true;
            chartAktifPasif.Series.Clear();
            chartAktifPasif.ChartAreas.Clear();
            chartAktifPasif.Legends.Clear();

            ChartArea ca = new ChartArea("PieArea");
            chartAktifPasif.ChartAreas.Add(ca);

            Legend lg = new Legend();
            chartAktifPasif.Legends.Add(lg);

            Series s = new Series("Durum");
            s.ChartType = SeriesChartType.Pie;
            s.IsValueShownAsLabel = true;

            s.Points.AddXY("Aktif", 8);
            s.Points.AddXY("Pasif", 5);

            chartAktifPasif.Series.Add(s);

            chartAktifPasif.Dock = DockStyle.Fill;
            chartAktifPasif.BringToFront();
        }
    }
}
