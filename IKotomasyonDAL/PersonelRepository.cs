using IKotomasyon.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKotomasyon.DAL
{
    public class PersonelRepository
    {

        public List<PersonelListeDto> GetPersonelListe(int? departmanId, string durum)
        {
            var list = new List<PersonelListeDto>();

            using (MySqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                string sql = @"SELECT 
                 p.personelId AS PersonelId,
                 CONCAT(p.personelAd, ' ', p.personelSoyad) AS AdSoyad,
                 d.departmanAd AS Departman,
                 p.durum AS Durum,
                 p.email AS Email,
                 p.telefon AS Telefon
                 FROM personel p
                 LEFT JOIN departman d ON d.departmanId = p.departmanId
                 WHERE
                 (@depId IS NULL OR p.departmanId = @depId)
                 AND (@durum = 'Tümü' OR p.durum = @durum)
                 ORDER BY p.personelAd, p.personelSoyad;";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@depId",
                    departmanId.HasValue ? (object)departmanId.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@durum", durum);

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            list.Add(new PersonelListeDto
                            {
                                PersonelId = dr.GetInt32("PersonelId"),
                                AdSoyad = dr.GetString("AdSoyad"),
                                Departman = dr.IsDBNull(dr.GetOrdinal("Departman")) ? "" : dr.GetString("Departman"),
                                Durum = dr.GetString("Durum"),
                                Email = dr.IsDBNull(dr.GetOrdinal("Email")) ? "" : dr.GetString("Email"),
                                Telefon = dr.IsDBNull(dr.GetOrdinal("Telefon")) ? "" : dr.GetString("Telefon")
                            });
                        }
                    }
                }
            }

            return list;
        }

        public List<Personel> GetAll()
        {
            var list = new List<Personel>();

            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string sql = @"SELECT p.*, d.departmanAd
                       FROM personel p
                       LEFT JOIN departman d ON d.departmanId = p.departmanId";

                using (var cmd = new MySqlCommand(sql, conn))
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        list.Add(new Personel
                        {
                            PersonelId = dr.GetInt32("personelId"),
                            PersonelAd = dr.GetString("personelAd"),
                            PersonelSoyad = dr.GetString("personelSoyad"),
                            DepartmanId = dr.GetInt32("departmanId"),
                            Pozisyon = dr["pozisyon"] == DBNull.Value ? "" : dr.GetString("pozisyon"),
                            IseGirisTarihi = dr.GetDateTime("IseGirisTarihi"),
                            Durum = dr["durum"] == DBNull.Value ? "" : dr.GetString("durum"),
                            KalanIzin = dr.GetInt32("kalan_izin"),
                            Email = dr.GetString("email"),
                            Telefon = dr.GetString("telefon")
                        });
                    }
                }
            }
            return list;
        }

        public List<Personel> GetByDepartman(int departmanId)
        {
            var list = new List<Personel>();

            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string sql = @"SELECT p.*, d.departmanAd
                       FROM personel p
                       JOIN departman d ON d.departmanId = p.departmanId
                       WHERE p.departmanId = @depId";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@depId", departmanId);

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            list.Add(new Personel
                            {
                                PersonelId = dr.GetInt32("personelId"),
                                PersonelAd = dr.GetString("personelAd"),
                                PersonelSoyad = dr.GetString("personelSoyad"),
                                DepartmanId = dr.GetInt32("departmanId"),
                                Pozisyon = dr["pozisyon"] == DBNull.Value ? "" : dr.GetString("pozisyon"),
                                IseGirisTarihi = dr.GetDateTime("IseGirisTarihi"),
                                Durum = dr["durum"] == DBNull.Value ? "" : dr.GetString("durum"),
                                KalanIzin = dr.GetInt32("kalan_izin"),
                                Email = dr.GetString("email"),
                                Telefon = dr.GetString("telefon")
                            });
                        }
                    }
                }
            }
            return list;
        }

        public void Ekle(Personel p)
        {
            using (MySqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                string sql = @"
                INSERT INTO personel
                (personelAd, personelSoyad, departmanId, pozisyon, IseGirisTarihi, durum, kalan_izin, Email, Telefon)
                VALUES
                (@ad, @soyad, @departmanId, @pozisyon, @maas, @iseGiris, @durum, @kalanIzin, @email, @telefon)";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ad", p.PersonelAd);
                    cmd.Parameters.AddWithValue("@soyad", p.PersonelSoyad);
                    cmd.Parameters.AddWithValue("@departmanId", p.DepartmanId);
                    cmd.Parameters.AddWithValue("@pozisyon", p.Pozisyon);
                    cmd.Parameters.AddWithValue("@iseGiris", p.IseGirisTarihi);
                    cmd.Parameters.AddWithValue("@durum", p.Durum);
                    cmd.Parameters.AddWithValue("@kalanIzin", p.KalanIzin);
                    cmd.Parameters.AddWithValue("@email", p.Email);
                    cmd.Parameters.AddWithValue("@telefon", p.Telefon);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Guncelle(Personel p)
        {
            using (MySqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                string sql = @"
                UPDATE personel SET
                    personelAd = @ad,
                    personelSoyad = @soyad,
                    departmanId = @departmanId,
                    pozisyon = @pozisyon,
                    IseGirisTarihi = @iseGiris,
                    durum = @durum,
                    kalan_izin = @kalanIzin,
                    Email = @email,
                    Telefon = @telefon
                WHERE personelId = @id";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", p.PersonelId);
                    cmd.Parameters.AddWithValue("@ad", p.PersonelAd);
                    cmd.Parameters.AddWithValue("@soyad", p.PersonelSoyad);
                    cmd.Parameters.AddWithValue("@departmanId", p.DepartmanId);
                    cmd.Parameters.AddWithValue("@pozisyon", p.Pozisyon);
                    cmd.Parameters.AddWithValue("@iseGiris", p.IseGirisTarihi);
                    cmd.Parameters.AddWithValue("@durum", p.Durum);
                    cmd.Parameters.AddWithValue("@kalanIzin", p.KalanIzin);
                    cmd.Parameters.AddWithValue("@email", p.Email);
                    cmd.Parameters.AddWithValue("@telefon", p.Telefon);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void Sil(int personelId)
        {
            using (MySqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                string sql = "DELETE FROM personel WHERE personelId = @id";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", personelId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
