using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKotomasyon.Entities
{
    public class Izin
    {
        public int Id { get; set; }
        public int Personel_id { get; set; }

        public string PersonelAdi { get; set; }
        public string Departman { get; set; }

        public string IzinTuru { get; set; }
        public DateTime Baslangic { get; set; }
        public DateTime Bitis { get; set; }
        public int Gun_sayisi { get; set; }

        public string Durum { get; set; }   
        public string Aciklama { get; set; }
    }

}
