using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKotomasyon.Entities
{
    public class PerformansKaydi
    {
        public int Id { get; set; }
        public int PersonelId { get; set; }
        public int DepartmanId { get; set; }

        public string DegerlendirenRol { get; set; }
        public int TakimCalismasi { get; set; }
        public int Verimlilik { get; set; }
        public int Gelisim { get; set; }

        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }

       

    }
}
