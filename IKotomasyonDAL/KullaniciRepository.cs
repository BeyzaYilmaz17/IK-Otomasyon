
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IKotomasyon.Entities;
using MySql.Data.MySqlClient;


namespace IKotomasyon.DAL
{
    public class KullaniciRepository
    {
        public Kullanici Login(string kullanici_adi, string sifre)
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();

                var cmd = new MySqlCommand(
                    "SELECT id, kullanici_adi, sifre, rol " +
                    "FROM kullanici " +
                    "WHERE kullanici_adi = @kAdi AND sifre = @sifre",
                    conn);

                cmd.Parameters.AddWithValue("@kAdi", kullanici_adi);
                cmd.Parameters.AddWithValue("@sifre", sifre);

                var dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    return new Kullanici
                    {
                        ID = dr.GetInt32("id"),
                        Kullanici_adi = dr.GetString("kullanici_adi"),
                        Sifre = dr.GetString("sifre"),
                        Rol = dr.GetString("rol")
                    };
                }

                return null;
            }
        }
    }
}
