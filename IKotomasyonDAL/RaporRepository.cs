using IKotomasyon.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKotomasyon.DAL
{
   public class RaporRepository
    {
        public RaporOzet GetOzet(RaporFiltre filtre)
        {
            RaporOzet ozet = new RaporOzet();

            using (MySqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                string sql = @"SELECT
                 COUNT(DISTINCT pr.personelId) AS ToplamPersonel,
                 IFNULL(AVG(m.brut_maas),0) AS OrtalamaMaas,
                 (SELECT COUNT(*)
                 FROM izin i
                 WHERE MONTH(i.baslangic) = MONTH(CURDATE())
                 AND YEAR(i.baslangic) = YEAR(CURDATE())
                 AND (@durum IS NULL OR @durum = 'Tümü' OR i.durum = @durum)) AS BuAyIzinli
                 FROM personel pr
                 LEFT JOIN maas m ON m.personel_id = pr.personelId
                 WHERE 1=1";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@durum", filtre.Durum);

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            ozet.ToplamPersonel = Convert.ToInt32(dr["ToplamPersonel"]);
                            ozet.OrtalamaMaas = Convert.ToDecimal(dr["OrtalamaMaas"]);
                            ozet.BuAyIzinli = Convert.ToInt32(dr["BuAyIzinli"]);
                        }
                    }
                }
            }

            return ozet;
        }

        public List<DurumDagilim> GetDurumDagilim(RaporFiltre filtre)
        {
            List<DurumDagilim> list = new List<DurumDagilim>();

            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();

                string sql = @"
            SELECT durum, COUNT(*) AS adet
            FROM izin
            WHERE 1=1
        ";

                if (!string.IsNullOrEmpty(filtre.Durum) && filtre.Durum != "Tümü")
                    sql += " AND durum = @durum ";

                if (filtre.Baslangic.HasValue)
                    sql += " AND baslangic >= @baslangic ";

                if (filtre.Bitis.HasValue)
                    sql += " AND bitis <= @bitis ";

                sql += " GROUP BY durum";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    if (!string.IsNullOrEmpty(filtre.Durum) && filtre.Durum != "Tümü")
                        cmd.Parameters.AddWithValue("@durum", filtre.Durum);

                    if (filtre.Baslangic.HasValue)
                        cmd.Parameters.AddWithValue("@baslangic", filtre.Baslangic.Value);

                    if (filtre.Bitis.HasValue)
                        cmd.Parameters.AddWithValue("@bitis", filtre.Bitis.Value);

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            list.Add(new DurumDagilim
                            {
                                Durum = dr["durum"].ToString(),
                                Adet = Convert.ToInt32(dr["adet"])
                            });
                        }
                    }
                }
            }

            return list;
        }

        public List<DepartmanPerformans> GetDepartmanPerformans()
        {
            List<DepartmanPerformans> list = new List<DepartmanPerformans>();

            using (MySqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                string sql = @"SELECT
                 d.departmanAd,
                 AVG(p.puan) AS OrtalamaPuan
                 FROM performans p
                 JOIN departman d ON d.departmanId = p.departmanId
                 GROUP BY d.departmanAd ";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        DepartmanPerformans dp = new DepartmanPerformans();
                        dp.DepartmanAdi = dr["departmanAd"].ToString();
                        dp.OrtalamaPuan = dr["OrtalamaPuan"] == DBNull.Value
                            ? 0
                            : Convert.ToDecimal(dr["OrtalamaPuan"]);

                        list.Add(dp);
                    }
                }
            }

            return list;
        }

    }

}

