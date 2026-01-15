using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKotomasyon.Entities
{
    public class RaporFiltre
    {
        public DateTime? Baslangic { get; set; }
        public DateTime? Bitis { get; set; }
        public string Durum { get; set; }
    }
}
