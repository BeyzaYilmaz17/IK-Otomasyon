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
using System.Windows.Forms.DataVisualization.Charting;


namespace IKotomasyon.UI
{
    public partial class Yoneticiform : Form
    {
        private readonly Kullanici _kullanici;
        private readonly DuyuruService _duyuruService = new DuyuruService();
        DashboardService _dashboardService = new DashboardService();

        public Yoneticiform(Kullanici kullanici)
        {
            InitializeComponent();
            _kullanici = kullanici;
        }

        private void personellabel_Click(object sender, EventArgs e)
        {
            PersonelListe frm = new PersonelListe();
            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PersonelListe frm = new PersonelListe();
            frm.Show();
        }

        private void personeleklepanel_Click(object sender, EventArgs e)
        {
            PersonelListe frm = new PersonelListe();
            frm.Show();
        }


        private void departmanpanel_Click(object sender, EventArgs e)
        {
            DepartmanYönetimi frm = new DepartmanYönetimi();
            frm.Show();
        }

        private void departmanlabel_Click(object sender, EventArgs e)
        {
            DepartmanYönetimi frm = new DepartmanYönetimi();
            frm.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DepartmanYönetimi frm = new DepartmanYönetimi();
            frm.Show();
        }


        private void IzinYönetimipanel_Click(object sender, EventArgs e)
        {
            YöneticiIzinform frm = new YöneticiIzinform();
            frm.Show();
        }

        private void IzinYönetimilabel_Click(object sender, EventArgs e)
        {
            YöneticiIzinform frm = new YöneticiIzinform();
            frm.Show();
        }

        private void IzinYönetimipb_Click(object sender, EventArgs e)
        {
            YöneticiIzinform frm = new YöneticiIzinform();
            frm.Show();
        }

        private void ChartAyarla()
        {
            chartIzin.Series.Clear();
            chartIzin.ChartAreas.Clear();
            chartIzin.Legends.Clear();

            var area = new ChartArea("A1");
            area.BackColor = Color.Transparent;
            chartIzin.ChartAreas.Add(area);

            var legend = new Legend("L1");
            legend.Docking = Docking.Right;
            chartIzin.Legends.Add(legend);

            var s = new Series("Izinler");
            s.ChartType = SeriesChartType.Pie;
            s.IsValueShownAsLabel = true;
            s.Label = "#VALX: #VAL";
            s.LegendText = "#VALX";
            s["PieLabelStyle"] = "Outside";
            s["PieLineColor"] = "Black";

            chartIzin.Series.Add(s);
        }


        private readonly IzinService _izinService = new IzinService();

        private void AylikIzinPastasiDoldur()
        {
            int yil = DateTime.Now.Year;
            int ay = DateTime.Now.Month;

            var data = _izinService.GetAylikIzinTurDagilimi(yil, ay);

            var s = chartIzin.Series["Izinler"];
            s.Points.Clear();

            if (data.Count == 0)
            {
                s.Points.AddXY("Veri yok", 1);
                return;
            }

            foreach (var item in data)
            {
                s.Points.AddXY(item.Key, item.Value);
            }
        }

        private void Yoneticiform_Load(object sender, EventArgs e)
        {

            ChartAyarla();
            AylikIzinPastasiDoldur();
            DuyurulariYukle();
            OzetleriYukle();
            BekleyenIzinYaz();
            DepartmanPerformansChartDoldur();
        }

        private void maaspanel_Click(object sender, EventArgs e)
        {
            MaasEkranı frm = new MaasEkranı();
            frm.Show();
        }

        private void maaslabel_Click(object sender, EventArgs e)
        {
            MaasEkranı frm = new MaasEkranı();
            frm.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MaasEkranı frm = new MaasEkranı();
            frm.Show();
        }


        private void performanspanel_Click(object sender, EventArgs e)
        {

            Performans frm = new Performans();
            frm.Show();
        }

        private void performanslabel_Click(object sender, EventArgs e)
        {
            Performans frm = new Performans();
            frm.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Performans frm = new Performans();
            frm.Show();
        }

        private void Duyurupanel_Click(object sender, EventArgs e)
        {
            Duyuru frm = new Duyuru();
            frm.Show();
        }

        private void duyurulabel_Click(object sender, EventArgs e)
        {
            Duyuru frm = new Duyuru();
            frm.Show();
        }

        private void Duyurupc_Click(object sender, EventArgs e)
        {
            Duyuru frm = new Duyuru();
            frm.Show();
        }

        private void dgvDuyurular_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }


        private void DuyurulariYukle()
        {
            dgvDuyurular.DataSource = null;

            dgvDuyurular.AutoGenerateColumns = true;

            dgvDuyurular.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDuyurular.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgvDuyurular.RowTemplate.Height = 45;
            dgvDuyurular.AllowUserToResizeRows = false;

            dgvDuyurular.DefaultCellStyle.Font =
                new Font("Segoe UI", 11, FontStyle.Regular);

            dgvDuyurular.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 12, FontStyle.Bold);

            dgvDuyurular.ColumnHeadersHeight = 40;

            dgvDuyurular.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDuyurular.MultiSelect = false;
            dgvDuyurular.ReadOnly = true;

            dgvDuyurular.DataSource = _duyuruService.DuyurulariGetir();

            dgvDuyurular.Columns["Id"].Visible = false;
        }

        private void raporpanel_Click(object sender, EventArgs e)
        {
            Rapor frm = new Rapor();
            frm.Show();
        }

        private void Raporlabel_Click(object sender, EventArgs e)
        {
            Rapor frm = new Rapor();
            frm.Show();
        }

        private void Raporpc_Click(object sender, EventArgs e)
        {
            Rapor frm = new Rapor();
            frm.Show();
        }

        private void OzetleriYukle()
        {
            var ozet = _dashboardService.GetOzet();
            if (ozet == null) return;

            lblToplamPersonel.Text = ozet.ToplamPersonel.ToString();
            lblYeniBasvuru.Text = ozet.YeniBasvurular.ToString();
            lblAktifPersonel.Text = ozet.AktifPersonel.ToString();
            lblOnayBekleyen.Text = ozet.OnayBekleyenIzin.ToString();
        }

        private void BekleyenIzinYaz()
        {
            int bekleyen = _izinService.GetBekleyenIzinSayisi();
            lblOnayBekleyen.Text = bekleyen.ToString();
        }

        private void DepartmanPerformansChartDoldur()
        {
            chartDepartman.Series.Clear();
            chartDepartman.ChartAreas.Clear();
            chartDepartman.Legends.Clear();

            chartDepartman.Dock = DockStyle.Fill;

            ChartArea ca = new ChartArea();
            ca.AxisX.Interval = 1;
            ca.AxisX.LabelStyle.Angle = -45;
            ca.AxisX.LabelStyle.Font = new Font("Segoe UI", 9);
            ca.AxisY.Minimum = 0;
            ca.AxisY.Maximum = 100;

            chartDepartman.ChartAreas.Add(ca);
            chartDepartman.Legends.Add(new Legend());

            Series s = new Series("Departman Performansı");
            s.ChartType = SeriesChartType.Column;
            s.IsValueShownAsLabel = true;
            s.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            s.Points.AddXY("Müşteri İlişkileri", 75);
            s.Points.AddXY("Creative", 82);
            s.Points.AddXY("Strateji Planlama", 68);
            s.Points.AddXY("Prodüksiyon", 80);
            s.Points.AddXY("Yazılım ve Teknoloji", 90);

            chartDepartman.Series.Add(s);
        }
    }

}

