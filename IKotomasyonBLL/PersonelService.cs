using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IKotomasyon.DAL;
using IKotomasyon.Entities;



namespace IKotomasyon.BLL
{
    public class PersonelService
    {
        private PersonelRepository repo = new PersonelRepository();

        public List<Personel> Listele()
        {
            return repo.GetAll();
        }

        public List<Personel> GetByDepartman(int depId)
        {
            return repo.GetByDepartman(depId);
        }

        public void Ekle(Personel p)
        {
            repo.Ekle(p);
        }

        public void Guncelle(Personel p)
        {
            repo.Guncelle(p);
        }

        public void Sil(int id)
        {
            repo.Sil(id);
        }

        public List<Personel> GetAll()
        {
            return repo.GetAll();
        }

        public List<PersonelListeDto> GetPersonelListe(int? departmanId, string durum)
        {
            return repo.GetPersonelListe(departmanId, durum);
        }
    }
}
