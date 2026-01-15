using IKotomasyon.DAL;
using IKotomasyon.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKotomasyon.BLL
{
    public class DuyuruService
    {
        private readonly DuyuruRepository _repo = new DuyuruRepository();

        public void DuyuruEkle(DuyuruKayit d)
        {
            _repo.Ekle(d);
        }

        public List<DuyuruKayit> DuyurulariGetir()
        {
            return _repo.TumunuGetir();
        }

       
    }
}
