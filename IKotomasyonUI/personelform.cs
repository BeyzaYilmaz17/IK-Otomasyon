
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
    public partial class personelform : Form
    {
        private Kullanici _kullanici;
        private readonly DuyuruService _duyuruService = new DuyuruService();

        public personelform(Kullanici kullanici)
        {
            InitializeComponent();
            _kullanici = kullanici;
        }

        private void izinpanel_Click(object sender, EventArgs e)
        {
            İzinTalep frm = new İzinTalep();
            frm.Show();
        }

        private void İzinlabel_Click(object sender, EventArgs e)
        {
            İzinTalep frm = new İzinTalep();
            frm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            İzinTalep frm = new İzinTalep();
            frm.Show();
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
            dgvDuyurular.Columns["Icerik"].Visible = false;
            dgvDuyurular.Columns["Tarih"].Visible = false;
        }

        private void personelform_Load_1(object sender, EventArgs e)
        {
            DuyurulariYukle();
        }

        private void Duyurupanel_Click(object sender, EventArgs e)
        {

            DuyuruPersonel frm = new DuyuruPersonel();
            frm.Show();
        }

        private void duyurulabel_Click(object sender, EventArgs e)
        {
            DuyuruPersonel frm = new DuyuruPersonel();
            frm.Show();
        }

        private void Duyurupc_Click(object sender, EventArgs e)
        {
            DuyuruPersonel frm = new DuyuruPersonel();
            frm.Show();
        }
    }
}
