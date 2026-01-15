using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using IKotomasyon.Entities;

namespace IKotomasyon.DAL
{
    public static class DbHelper
    {
        public static MySqlConnection GetConnection()
        {


            string cs = ConfigurationManager.ConnectionStrings["MyDb"].ConnectionString;
            return new MySqlConnection(cs);
        }

    }
}

