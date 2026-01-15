using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IKotomasyon.Entities;
using MySql.Data.MySqlClient;

namespace IKotomasyon.DAL
{
    public class IzinRepository
    {
        public List<Izin> GetAll()
        {
            List<Izin> list = new List<Izin>();

            using (MySqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                string sql = @"
        SELECT 
            i.id,
            i.personel_id,
            CONCAT(p.personelAd, ' ', p.personelSoyad) AS PersonelAdi,
            d.departmanAd AS Departman,
            i.IzinTuru,
            i.baslangic,
            i.bitis,
            i.gun_sayisi,
            i.durum,
            i.aciklama
        FROM izin i
        JOIN personel p ON p.personelId = i.personel_id
        JOIN departman d ON d.departmanId = p.departmanId
        ORDER BY i.id DESC";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                var dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    list.Add(new Izin
                    {
                        Id = Convert.ToInt32(dr["id"]),
                        Personel_id = Convert.ToInt32(dr["personel_id"]),
                        PersonelAdi = dr["PersonelAdi"].ToString(),
                        Departman = dr["Departman"].ToString(),
                        IzinTuru = dr["IzinTuru"].ToString(),
                        Baslangic = Convert.ToDateTime(dr["baslangic"]),
                        Bitis = Convert.ToDateTime(dr["bitis"]),
                        Gun_sayisi = Convert.ToInt32(dr["gun_sayisi"]),
                        Durum = dr["durum"].ToString(),
                        Aciklama = dr["aciklama"].ToString()
                    });
                }
            }
            return list;
        }

        public void Add(Izin izin)
        {
            using (MySqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                string sql = @"INSERT INTO izin
                 (personel_id, baslangic, bitis, gun_sayisi, durum, aciklama, IzinTuru)
                 VALUES(@pid, @bas, @bit, @gun, @durum, @ack, @tur)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@pid", izin.Personel_id);
                cmd.Parameters.AddWithValue("@bas", izin.Baslangic);
                cmd.Parameters.AddWithValue("@bit", izin.Bitis);
                cmd.Parameters.AddWithValue("@gun", izin.Gun_sayisi);
                cmd.Parameters.AddWithValue("@durum", izin.Durum);
                cmd.Parameters.AddWithValue("@ack", izin.Aciklama);
                cmd.Parameters.AddWithValue("@tur", izin.IzinTuru);

                cmd.ExecuteNonQuery();
            }

        }

        public void UpdateDurum(int izinId, string durum)
        {
            using (MySqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                string sql = "UPDATE izin SET durum = @durum WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@durum", durum);
                cmd.Parameters.AddWithValue("@id", izinId);

                cmd.ExecuteNonQuery();
            }
        }

        public int GetKalanGun(int personelId)
        {
            using (MySqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();
                string sql = @"SELECT 20 - IFNULL(SUM(gun_sayisi),0)
                               FROM izin
                               WHERE personel_id=@pid AND durum='Onaylandı'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@pid", personelId);
                return int.Parse(cmd.ExecuteScalar().ToString());
            }
        }

        public Dictionary<string, int> GetAylikIzinTurDagilimi(int yil, int ay)
        {
            var sonuc = new Dictionary<string, int>();

            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();

                string sql = @"
                 SELECT IzinTuru, COUNT(*) adet
                 FROM izin
                 WHERE YEAR(baslangic) = @yil
                 AND MONTH(baslangic) = @ay
                 AND durum = 'Onaylandı'
                 GROUP BY IzinTuru; ";

                using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@yil", yil);
                    cmd.Parameters.AddWithValue("@ay", ay);

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            string tur = dr["IzinTuru"].ToString();
                            int adet = Convert.ToInt32(dr["adet"]);
                            sonuc[tur] = adet;
                        }
                    }
                }
            }

            return sonuc;
        }

        public List<Izin> GetIzinler(IzinFiltre filtre)
        {
            List<Izin> list = new List<Izin>();

            using (MySqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                string sql = @"
                 SELECT i.*, p.personelAd, p.personelSoyad
                 FROM izin i
                 JOIN personel p ON p.personelId = i.personel_id
                 WHERE
                (@durum IS NULL OR i.durum = @durum)
                AND (@bas IS NULL OR i.baslangic >= @bas)
                AND (@bit IS NULL OR i.bitis <= @bit)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@durum",
                    filtre.Durum == "Tümü" ? null : filtre.Durum);
                cmd.Parameters.AddWithValue("@bas", filtre.Baslangic);
                cmd.Parameters.AddWithValue("@bit", filtre.Bitis);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        list.Add(new Izin
                        {
                            Id = Convert.ToInt32(dr["id"]),
                            Personel_id = Convert.ToInt32(dr["personel_id"]),
                            Baslangic = Convert.ToDateTime(dr["baslangic"]),
                            Bitis = Convert.ToDateTime(dr["bitis"]),
                            Gun_sayisi = Convert.ToInt32(dr["gun_sayisi"]),
                            Durum = dr["durum"].ToString(),
                            Aciklama = dr["aciklama"].ToString(),
                            IzinTuru = dr["IzinTuru"].ToString()
                        });
                    }
                }
            }

            return list;
        }

        public int GetBekleyenIzinSayisi()
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM izin WHERE durum = 'Beklemede'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

    }
}