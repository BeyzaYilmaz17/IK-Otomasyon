using IKotomasyon.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKotomasyon.DAL
{
    public class PerformansRepository
    {
        public void Ekle(PerformansKaydi p)
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();

                string sql = @"INSERT INTO performans (personelId, departmanId, takim_calismasi, verimlilik, gelisim, aciklama, tarih)
                 VALUES (@personelId, @departmanId, @takim, @ver, @gel, @aciklama, NOW());";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@personelId", p.PersonelId);
                    cmd.Parameters.AddWithValue("@departmanId", p.DepartmanId);
                    cmd.Parameters.AddWithValue("@takim", p.TakimCalismasi);
                    cmd.Parameters.AddWithValue("@ver", p.Verimlilik);
                    cmd.Parameters.AddWithValue("@gel", p.Gelisim);
                    cmd.Parameters.AddWithValue("@aciklama", string.IsNullOrWhiteSpace(p.Aciklama) ? (object)DBNull.Value : p.Aciklama);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Guncelle(PerformansKaydi p)
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();

                string sql = @"UPDATE performans
                 SET takim_calismasi=@takim,
                 verimlilik=@ver,
                 gelisim=@gel,
                 aciklama=@aciklama
                 WHERE id=@id;";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", p.Id);
                    cmd.Parameters.AddWithValue("@takim", p.TakimCalismasi);
                    cmd.Parameters.AddWithValue("@ver", p.Verimlilik);
                    cmd.Parameters.AddWithValue("@gel", p.Gelisim);
                    cmd.Parameters.AddWithValue("@aciklama", string.IsNullOrWhiteSpace(p.Aciklama) ? (object)DBNull.Value : p.Aciklama);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Sil(int id)
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();

                string sql = "DELETE FROM performans WHERE id=@id;";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<PerformansKaydi> GetByPersonel(int personelId)
        {
            var list = new List<PerformansKaydi>();

            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();

                string sql = @"SELECT id, personelId, departmanId, takim_calismasi, verimlilik, gelisim, aciklama, tarih
                 FROM performans
                 WHERE personelId=@pid
                 ORDER BY tarih DESC;";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@pid", personelId);

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            list.Add(new PerformansKaydi
                            {
                                Id = dr.GetInt32("id"),
                                PersonelId = dr.GetInt32("personelId"),
                                DepartmanId = dr.GetInt32("departmanId"),
                                TakimCalismasi = dr.GetInt32("takim_calismasi"),
                                Verimlilik = dr.GetInt32("verimlilik"),
                                Gelisim = dr.GetInt32("gelisim"),
                                Aciklama = dr.IsDBNull(dr.GetOrdinal("aciklama")) ? "" : dr.GetString("aciklama"),
                                Tarih = dr.GetDateTime("tarih")
                            });
                        }
                    }
                }
            }

            return list;
        }

        public List<PerformansKaydi> GetIKFiltreli(
         int? departmanId,
         DateTime? tarih,
          string seviye)
        {
            var list = new List<PerformansKaydi>();

            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();

                string sql = @"SELECT id, personel_id, departman_id, degerlendirenRol, takim_calismasi, verimlilik, gelisim, aciklama, tarih
                  FROM performans WHERE 1=1 ";

                if (departmanId.HasValue)
                    sql += " AND departman_id = @departmanId";

                if (tarih.HasValue)
                    sql += " AND DATE(tarih) = DATE(@tarih)";

                
                if (!string.IsNullOrEmpty(seviye) && seviye != "Tümü")
                {
                    if (seviye == "Düşük")
                        sql += " AND (takim_calismasi = 'Düşük' OR verimlilik = 'Düşük' OR gelisim = 'Düşük')";
                    else if (seviye == "Orta")
                        sql += " AND (takim_calismasi = 'Orta' OR verimlilik = 'Orta' OR gelisim = 'Orta')";
                    else if (seviye == "Yüksek")
                        sql += " AND (takim_calismasi = 'İyi' OR verimlilik = 'İyi' OR gelisim = 'İyi')";
                }

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    if (departmanId.HasValue)
                        cmd.Parameters.AddWithValue("@departmanId", departmanId.Value);

                    if (tarih.HasValue)
                        cmd.Parameters.AddWithValue("@tarih", tarih.Value.Date);

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            list.Add(new PerformansKaydi
                            {
                                Id = dr.GetInt32("id"),
                                PersonelId = dr.GetInt32("personel_id"),
                                DepartmanId = dr.GetInt32("departman_id"),
                                DegerlendirenRol = dr.GetString("degerlendirenRol"),
                                TakimCalismasi = dr.GetInt32("takim_calismasi"),
                                Verimlilik = dr.GetInt32("verimlilik"),
                                Gelisim = dr.GetInt32("gelisim"),
                                Aciklama = dr.IsDBNull(dr.GetOrdinal("aciklama")) ? "" : dr.GetString("aciklama"),
                                Tarih = dr.GetDateTime("tarih")
                            });
                        }
                    }
                }
            }

            return list;
        }



        public List<DepartmanPerformansDto> GetDepartmanOrtalamalari()
        {
            var list = new List<DepartmanPerformansDto>();

            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string sql = @"SELECT 
                 d.departmanAd AS DepartmanAdi,
                 ROUND(AVG(
                  ( CASE p.takim_calismasi
                  WHEN 'Düşük' THEN 40
                  WHEN 'Orta'  THEN 70
                  ELSE 90
                  END +
                 CASE p.verimlilik
                  WHEN 'Düşük' THEN 40
                  WHEN 'Orta'  THEN 70
                  ELSE 90
                  END +
                 CASE p.gelisim
                 WHEN 'Düşük' THEN 40
                 WHEN 'Orta'  THEN 70
                 ELSE 90
                  END ) / 3  ), 1) AS OrtalamaPuan
                 FROM performans p
                 JOIN departman d ON d.departmanId = p.departmanId
                 GROUP BY d.departmanAd
                 ORDER BY OrtalamaPuan DESC;";
                using (var cmd = new MySqlCommand(sql, conn))
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        list.Add(new DepartmanPerformansDto
                        {
                            DepartmanAdi = dr.GetString("DepartmanAdi"),
                            OrtalamaPuan = Convert.ToDouble(dr["OrtalamaPuan"])
                        });
                    }
                }
            }

            return list;
        }

         public List<PerformansIKDto> GetIKPerformansListesi(
         int? departmanId,
         DateTime? tarih,
         string seviye)
         {
            var list = new List<PerformansIKDto>();

            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();

                string sql = @"SELECT
                 d.DepartmanAd AS DepartmanAdi,
                 CONCAT(pr.personelAd, ' ', pr.personelSoyad) AS PersonelAdSoyad,
                 p.takim_calismasi,
                 p.verimlilik,
                 p.gelisim,
                 p.tarih,
                 ROUND(
                 (CASE p.takim_calismasi WHEN 'Düşük' THEN 40 WHEN 'Orta' THEN 70 ELSE 90 END +
                 CASE p.verimlilik     WHEN 'Düşük' THEN 40 WHEN 'Orta' THEN 70 ELSE 90 END +
                 CASE p.gelisim        WHEN 'Düşük' THEN 40 WHEN 'Orta' THEN 70 ELSE 90 END) / 3 , 1) AS OrtalamaPuan
                 FROM performans p
                 JOIN departman d ON d.DepartmanId = p.departmanId
                 JOIN personel pr ON pr.PersonelId = p.personelId
                 WHERE 1=1";

                if (departmanId.HasValue)
                    sql += " AND d.DepartmanId = @departmanId";

                if (tarih.HasValue)
                    sql += " AND DATE(p.tarih) = DATE(@tarih)";

                if (seviye != "Tümü")
                {
                    if (seviye == "Düşük")
                        sql += " HAVING OrtalamaPuan < 50";
                    else if (seviye == "Orta")
                        sql += " HAVING OrtalamaPuan BETWEEN 50 AND 74";
                    else
                        sql += " HAVING OrtalamaPuan >= 75";
                }

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    if (departmanId.HasValue)
                        cmd.Parameters.AddWithValue("@departmanId", departmanId);

                    if (tarih.HasValue)
                        cmd.Parameters.AddWithValue("@tarih", tarih);

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            list.Add(new PerformansIKDto
                            {
                                DepartmanAdi = dr["DepartmanAdi"].ToString(),
                                PersonelAdSoyad = dr.GetString("PersonelAdSoyad"),
                                TakimCalismasi = dr.GetString("takim_calismasi"),
                                Verimlilik = dr.GetString("verimlilik"),
                                Gelisim = dr.GetString("gelisim"),
                                Tarih = dr.GetDateTime("tarih"),
                                OrtalamaPuan = Convert.ToDouble(dr["OrtalamaPuan"])
                            });
                        }
                    }
                }
            }
            return list;
        }



    }
}
