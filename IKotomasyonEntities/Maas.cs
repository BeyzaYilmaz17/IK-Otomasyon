using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKotomasyon.Entities
{
    public class Maas
    {

        public int Id { get; set; }
        public int Personel_id { get; set; }

        
        public string PersonelAdSoyad { get; set; } = "";

        public string DepartmanAd { get; set; }
        public int Ay { get; set; }
        public int Yil { get; set; }

        public decimal Brut_maas { get; set; }
        public string Zam_turu { get; set; } = "";
        public decimal Zam_orani { get; set; }  
        
        public decimal YeniMaas => Brut_maas + (Brut_maas * (Zam_orani / 100m));
    }
}
