using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IKotomasyon.DAL;
using IKotomasyon.Entities;

namespace IKotomasyon.BLL
{
    public class MaasService
    {
        private readonly MaasRepository _repo = new MaasRepository();

        public List<MaasListeDto> GetAllWithPersonel()
        {
            return _repo.GetAllWithPersonel();
        }

    
        public void Ekle(Maas maas)
        {
            _repo.Ekle(maas);
        }

        
        public void Guncelle(Maas maas)
        {
            _repo.Guncelle(maas);
        }

        
        public void Sil(int id)
        {
            _repo.Sil(id);
        }

        public Maas GetSonMaas(int personelId)
        {
            return _repo.GetSonMaasByPersonel(personelId);
        }

    }
}
