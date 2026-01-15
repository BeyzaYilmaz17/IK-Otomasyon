using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IKotomasyon.Entities;
using MySql.Data.MySqlClient;

namespace IKotomasyon.DAL
{
    public class DepartmanRepository
    {
        public List<Departman> Listele()
        {
            var list = new List<Departman>();

            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand(
                    "SELECT departmanId, departmanAd, aciklama FROM departman",
                    conn
                );

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        list.Add(new Departman
                        {
                            DepartmanId = dr.GetInt32("departmanId"),
                            DepartmanAd = dr.GetString("departmanAd"),
                            Aciklama = dr.IsDBNull(dr.GetOrdinal("aciklama"))
                                ? ""
                                : dr.GetString("aciklama")
                        });
                    }
                }
            }
            return list;
        }

        public void Ekle(Departman d)
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand(
                    "INSERT INTO departman (departmanAd, aciklama) VALUES (@ad, @aciklama)",
                    conn
                );
                cmd.Parameters.AddWithValue("@ad", d.DepartmanAd);
                cmd.Parameters.AddWithValue("@aciklama", d.Aciklama);
                cmd.ExecuteNonQuery();
            }
        }

        public void Guncelle(Departman d)
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand(
                    "UPDATE departman SET departmanAd=@ad, aciklama=@aciklama WHERE departmanId=@id",
                    conn
                );
                cmd.Parameters.AddWithValue("@id", d.DepartmanId);
                cmd.Parameters.AddWithValue("@ad", d.DepartmanAd);
                cmd.Parameters.AddWithValue("@aciklama", d.Aciklama);
                cmd.ExecuteNonQuery();
            }
        }

        public void Sil(int id)
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand(
                    "DELETE FROM departman WHERE departmanId=@id",
                    conn
                );
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Departman> GetAll()
        {
            var list = new List<Departman>();

            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();

                string sql = "SELECT departmanId, departmanAd FROM departman";

                using (var cmd = new MySqlCommand(sql, conn))
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        list.Add(new Departman
                        {
                            DepartmanId = dr.GetInt32("departmanId"),
                            DepartmanAd = dr.GetString("departmanAd")
                        });
                    }
                }
            }

            return list;
        }

       

    }
}
