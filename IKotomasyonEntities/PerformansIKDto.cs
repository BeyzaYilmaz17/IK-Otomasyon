using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKotomasyon.Entities
{
    public class PerformansIKDto
    {
        public int DepartmanId { get; set; }
        public int PersonelId { get; set; }

        public string DepartmanAdi { get; set; }
        public string PersonelAdSoyad { get; set; }

        public string TakimCalismasi { get; set; }
        public string Verimlilik { get; set; }
        public string Gelisim { get; set; }

        public DateTime Tarih { get; set; }
        public double OrtalamaPuan { get; set; }
    }
}
