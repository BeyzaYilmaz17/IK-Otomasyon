using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKotomasyon.Entities
{
    public class RaporOzetDto
    {
        public int ToplamPersonel { get; set; }
        public int AktifPersonel { get; set; }
        public int BuAyIzinliPersonel { get; set; }
        public decimal OrtalamaMaas { get; set; }

       
        public string DepartmanAdi { get; set; }
        public int PersonelSayisi { get; set; }
    }
}
