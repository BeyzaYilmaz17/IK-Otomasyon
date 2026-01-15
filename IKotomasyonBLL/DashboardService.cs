using IKotomasyon.DAL;
using IKotomasyon.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKotomasyon.BLL
{
    public class DashboardService
    {
        private readonly DashboardRepository _repo = new DashboardRepository();
        public DashboardOzetDto GetOzet() => _repo.GetOzet();

      
    }


}
