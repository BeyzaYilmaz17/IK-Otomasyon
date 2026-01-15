using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IKotomasyon.DAL;
using IKotomasyon.Entities;


namespace IKotomasyon.BLL
{
    public class DepartmanService
    {
        private readonly DepartmanRepository repo = new DepartmanRepository();

        public List<Departman> Listele() => repo.Listele();
        public void Ekle(Departman d) => repo.Ekle(d);
        public void Guncelle(Departman d) => repo.Guncelle(d);
        public void Sil(int id) => repo.Sil(id);

        public List<Departman> GetAll()
        {
            return repo.GetAll();
        }
    }
}
