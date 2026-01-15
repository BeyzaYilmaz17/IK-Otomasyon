
using IKotomasyon.Entities;
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

namespace IKotomasyon.UI
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void girisButton_Click(object sender, EventArgs e)
        {
            var service = new KullaniciService();
            var kullanici = service.Login(txtKullaniciAdi.Text, txtParola.Text);

            if (kullanici == null)
            {
                MessageBox.Show("Hatalı giriş");
                return;
            }

            this.Hide();

            if (kullanici.Rol == "Admin")
            {
                new Yoneticiform(kullanici).Show();
            }
            else if (kullanici.Rol == "IK")
            {
                new IKform(kullanici).Show();
            }
            else
            {
                new personelform(kullanici).Show();
            }
        }
    }
}
