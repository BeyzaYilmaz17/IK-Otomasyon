using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKotomasyon.Entities
{
   public class DepartmanPerformansDto
    {
        public int DepartmanId { get; set; }
        public string DepartmanAdi { get; set; }
        public double OrtalamaPuan { get; set; }
    }
}
