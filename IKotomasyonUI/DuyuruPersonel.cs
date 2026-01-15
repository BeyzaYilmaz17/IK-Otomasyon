using IKotomasyon.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IKotomasyon.Entities;

namespace IKotomasyon.UI
{
    public partial class DuyuruPersonel : Form
    {
        private readonly DuyuruService _service = new DuyuruService();
        public DuyuruPersonel()
        {
            InitializeComponent();
        }

        private void DuyuruPersonel_Load(object sender, EventArgs e)
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

    }
}
