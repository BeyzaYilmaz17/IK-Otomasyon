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
using System.Windows.Forms.DataVisualization.Charting;

namespace IKotomasyon.UI
{
    public partial class PerformansIK : Form
    {
        private readonly PerformansService _performansService = new PerformansService();
        private readonly DepartmanService _departmanService = new DepartmanService();
        private readonly PersonelService _personelService = new PersonelService();
        public PerformansIK()
        {
            InitializeComponent();
        }

        private void PerformansIK_Load(object sender, EventArgs e)
        {
            dgvPerformans.AutoGenerateColumns = true;

           
            dgvPerformans.DataSource =
                _performansService.GetIKPerformansListesi(null, null, null);

            DepartmanlariDoldur();
        }

      
        private void btnFiltrele_Click(object sender, EventArgs e)
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

        private void DepartmanlariDoldur()
        {
            var departmanlar = _departmanService.GetAll();

            cmbDepartman.DataSource = departmanlar;
            cmbDepartman.DisplayMember = "DepartmanAd";
            cmbDepartman.ValueMember = "DepartmanId";
            cmbDepartman.SelectedIndex = -1;
        }
    }
}
