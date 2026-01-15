using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKotomasyon.Entities
{
    public class DashboardOzetDto
    {
        public int ToplamPersonel { get; set; }
        public int YeniBasvurular { get; set; }
        public int AktifPersonel { get; set; }
        public int OnayBekleyenIzin { get; set; }
    }
}
