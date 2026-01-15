using IKotomasyon.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKotomasyon.DAL
{
   public class DuyuruRepository
    {
        public void Ekle(DuyuruKayit d)
        {
            using (MySqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                string sql = @"INSERT INTO duyuru (baslik, icerik, tarih)
                               VALUES (@baslik, @icerik, @tarih)";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@baslik", d.Baslik);
                    cmd.Parameters.AddWithValue("@icerik", d.Icerik);
                    cmd.Parameters.AddWithValue("@tarih", d.Tarih);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<DuyuruKayit> TumunuGetir()
        {
            var list = new List<DuyuruKayit>();

            using (MySqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                string sql = @"SELECT id, baslik, icerik, tarih
                               FROM duyuru
                               ORDER BY tarih DESC";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        list.Add(new DuyuruKayit
                        {
                            Id = dr.GetInt32("id"),
                            Baslik = dr.GetString("baslik"),
                            Icerik = dr.GetString("icerik"),
                            Tarih = dr.GetDateTime("tarih")
                        });
                    }
                }
            }



            return list;
        }

       

    }
}
