using IKotomasyon.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKotomasyon.DAL
{
    public class MaasRepository
    {
        public List<MaasListeDto> GetAllWithPersonel()
        {
            var list = new List<MaasListeDto>();

            using (MySqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                string sql = @"SELECT 
                    m.id,
                    m.personel_id,
                    CONCAT(p.personelAd, ' ', p.personelSoyad) AS PersonelAdSoyad,
                    d.departmanAd,
                    m.ay,
                    m.yil,
                    m.brut_maas,
                    m.zam_orani,
                    m.zam_turu,
                    m.olusturma_tarihi
                    FROM maas m
                    JOIN personel p ON p.personelId = m.personel_id
                    JOIN departman d ON d.departmanId = p.departmanId
                    ORDER BY m.id DESC";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        list.Add(new MaasListeDto
                        {
                            Id = Convert.ToInt32(dr["id"]),
                            PersonelId = Convert.ToInt32(dr["personel_id"]),
                            PersonelAdSoyad = dr["PersonelAdSoyad"].ToString(),
                            DepartmanAd = dr["DepartmanAd"].ToString(),
                            Ay = Convert.ToInt32(dr["ay"]),
                            Yil = Convert.ToInt32(dr["yil"]),
                            Brut_maas = Convert.ToDecimal(dr["brut_maas"]),
                            Zam_orani = Convert.ToDecimal(dr["zam_orani"]),
                            Zam_turu = dr["zam_turu"].ToString(),
                            OlusturmaTarihi = Convert.ToDateTime(dr["olusturma_tarihi"])
                        });
                    }
                }
            }

            return list;
        }

        public void Ekle(Maas maas)
        {
            using (MySqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                string sql = @"INSERT INTO maas
                (personel_id, ay, yil, brut_maas, zam_orani, zam_turu, olusturma_tarihi)
                VALUES
                (@personelId, @ay, @yil, @brutMaas, @zamOrani, @zamTuru, NOW())";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@personelId", maas.Personel_id);
                    cmd.Parameters.AddWithValue("@ay", maas.Ay);
                    cmd.Parameters.AddWithValue("@yil", maas.Yil);
                    cmd.Parameters.AddWithValue("@brutMaas", maas.Brut_maas);
                    cmd.Parameters.AddWithValue("@zamOrani", maas.Zam_orani);
                    cmd.Parameters.AddWithValue("@zamTuru", maas.Zam_turu);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        
        public void Guncelle(Maas maas)
        {
            using (MySqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                string sql = @"
                UPDATE maas SET
                    brut_maas = @brutMaas,
                    zam_orani = @zamOrani,
                    zam_turu = @zamTuru,
                WHERE id = @id";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", maas.Id);
                    cmd.Parameters.AddWithValue("@brutMaas", maas.Brut_maas);
                    cmd.Parameters.AddWithValue("@zamOrani", maas.Zam_orani);
                    cmd.Parameters.AddWithValue("@zamTuru", maas.Zam_turu);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        
        public void Sil(int id)
        {
            using (MySqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                string sql = "DELETE FROM maas WHERE id = @id";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Maas GetSonMaasByPersonel(int personelId)
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();

                string sql = @" SELECT *
                   FROM maas
                   WHERE personel_id = @pid
                   ORDER BY yil DESC, ay DESC, id DESC
                   LIMIT 1";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@pid", personelId);

                    using (var dr = cmd.ExecuteReader())
                    {
                        if (!dr.Read()) return null;

                        return new Maas
                        {
                            Id = Convert.ToInt32(dr["id"]),
                            Personel_id = personelId,
                            Brut_maas = Convert.ToDecimal(dr["brut_maas"]),
                            Zam_orani = Convert.ToDecimal(dr["zam_orani"]),
                            Zam_turu = dr["zam_turu"].ToString(),
                            Ay = Convert.ToInt32(dr["ay"]),
                            Yil = Convert.ToInt32(dr["yil"]),
                        };
                    }
                }
            }
        }
    }
}
