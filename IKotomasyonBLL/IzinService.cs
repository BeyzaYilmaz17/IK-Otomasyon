using IKotomasyon.DAL;
using IKotomasyon.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IKotomasyon.BLL
{


    public class IzinService
    {

        private readonly IzinRepository _repo = new IzinRepository();

        public void Ekle(Izin izin)
        {
            _repo.Add(izin);
        }

        public int GetKalanGun(int personelId)
        {
            return _repo.GetKalanGun(personelId);
        }

        public List<Izin> GetAll()
        {
            return _repo.GetAll();
        }

        public List<Izin> Listele()
        {
            return GetAll();
        }

        public Dictionary<string, int> GetAylikIzinTurDagilimi(int yil, int ay)
        {
            return _repo.GetAylikIzinTurDagilimi(yil, ay);
        }


        public void Onayla(int izinId)
        {
            _repo.UpdateDurum(izinId, "Onaylandı");
        }

        public void Reddet(int izinId)
        {
            _repo.UpdateDurum(izinId, "Reddedildi");
        }

        public int GetBekleyenIzinSayisi()
        {
            return _repo.GetBekleyenIzinSayisi();
        }
    }



}



