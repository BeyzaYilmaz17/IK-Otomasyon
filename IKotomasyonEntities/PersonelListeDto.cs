using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKotomasyon.Entities
{
    public class PersonelListeDto
    {
        public int PersonelId { get; set; }
        public string AdSoyad { get; set; }
        public string Departman { get; set; }
        public string Durum { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }

    }
}
