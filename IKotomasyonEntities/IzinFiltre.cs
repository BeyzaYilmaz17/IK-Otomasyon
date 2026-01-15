using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKotomasyon.Entities
{
    public class IzinFiltre
    {
        public int? DepartmanId { get; set; }
        public string Durum { get; set; }
        public System.DateTime? Baslangic { get; set; }
        public System.DateTime? Bitis { get; set; }
    }
}
