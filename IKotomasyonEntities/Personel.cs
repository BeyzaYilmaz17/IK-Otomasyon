using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKotomasyon.Entities
{
    public class Personel
    {
        public int PersonelId { get; set; }

        public string PersonelAd { get; set; }

        public string PersonelSoyad { get; set; }

        public int DepartmanId { get; set; }

        public string Pozisyon { get; set; }

        public DateTime IseGirisTarihi { get; set; }

        public string Durum { get; set; }

        public int KalanIzin { get; set; }

        public string Email { get; set; }

        public string Telefon { get; set; }

        public string AdSoyad
        {
            get { return PersonelAd + " " + PersonelSoyad; }
        }

    }
}
