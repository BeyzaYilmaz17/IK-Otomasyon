using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IKotomasyon.DAL;
using IKotomasyon.Entities;

namespace IKotomasyon.BLL
{
    public class KullaniciService
    {
        private KullaniciRepository _repo;

        public KullaniciService()
        {
            _repo = new KullaniciRepository();
        }

        public Kullanici Login(string ad, string sifre)
        {
            return _repo.Login(ad, sifre);
        }
    }
}
