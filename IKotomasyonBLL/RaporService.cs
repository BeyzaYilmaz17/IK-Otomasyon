using IKotomasyon.DAL;
using IKotomasyon.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKotomasyon.BLL
{
    public class RaporService
    {
        private readonly RaporRepository _repo = new RaporRepository();

        public RaporOzet GetOzet(RaporFiltre filtre)
        {
            return _repo.GetOzet(filtre);
        }

        public List<DurumDagilim> GetDurumDagilim(RaporFiltre filtre)
        {
            return _repo.GetDurumDagilim(filtre);
        }

        public List<DepartmanPerformans> GetDepartmanPerformans()
        {
            return _repo.GetDepartmanPerformans();
        }
    }
}
