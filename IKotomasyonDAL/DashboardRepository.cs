using IKotomasyon.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKotomasyon.DAL
{
    public class DashboardRepository
    {
        public DashboardOzetDto GetOzet()
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();

                string sql = @"SELECT
                 (SELECT COUNT(*) FROM personel) AS ToplamPersonel,
                 (SELECT COUNT(*) FROM personel WHERE durum='Yeni') AS YeniBasvurular,
                 (SELECT COUNT(*) FROM personel WHERE durum='Aktif') AS AktifPersonel,
                 (SELECT COUNT(*) FROM izin WHERE durum='Beklemede') AS OnayBekleyenIzin"; 

                using (var cmd = new MySqlCommand(sql, conn))
                using (var dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        return new DashboardOzetDto
                        {
                            ToplamPersonel = Convert.ToInt32(dr["ToplamPersonel"]),
                            YeniBasvurular = Convert.ToInt32(dr["YeniBasvurular"]),
                            AktifPersonel = Convert.ToInt32(dr["AktifPersonel"]),
                            OnayBekleyenIzin = Convert.ToInt32(dr["OnayBekleyenIzin"])
                        };
                    }
                }
            }
            return null;
        }

        public List<AylikIzinDto> GetAylikIzinDagilimi()
        {
            var list = new List<AylikIzinDto>();

            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string sql = @"SELECT izinTuru, COUNT(*) adet
                 FROM izin
                 WHERE MONTH(baslangicTarihi)=MONTH(CURDATE())
                 GROUP BY izinTuru";

                using (var cmd = new MySqlCommand(sql, conn))
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        list.Add(new AylikIzinDto
                        {
                            IzinTuru = dr["izinTuru"].ToString(),
                            Adet = Convert.ToInt32(dr["adet"])
                        });
                    }
                }
            }
            return list;
        }

        
        
    }
}
