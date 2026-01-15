using IKotomasyon.DAL;
using IKotomasyon.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKotomasyon.BLL
{
    public class PerformansService
    {
        private readonly PerformansRepository _repo = new PerformansRepository();

        public void Ekle(PerformansKaydi p) => _repo.Ekle(p);
        public void Guncelle(PerformansKaydi p) => _repo.Guncelle(p);
        public void Sil(int id) => _repo.Sil(id);

        public List<PerformansKaydi> GetByPersonel(int personelId) => _repo.GetByPersonel(personelId);

        public List<DepartmanPerformansDto> GetDepartmanOrtalamalari() => _repo.GetDepartmanOrtalamalari();

        public List<PerformansKaydi> IKFiltreliGetir(int? departmanId, DateTime? tarih, string seviye)
        {
            return _repo.GetIKFiltreli(departmanId, tarih, seviye);
        }

        public List<PerformansIKDto> GetIKPerformansListesi(int? departmanId, DateTime? tarih, string seviye)
        {
            return _repo.GetIKPerformansListesi(departmanId, tarih, seviye);
        }

    }




}
