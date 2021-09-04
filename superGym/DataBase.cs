using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace superGym
{
    class DataBase
    {
        private static SQLiteConnection conn;

        private static SQLiteConnection ConectarBanco()
        {
            conn = new SQLiteConnection("Data Soucr = D:\\work\\superGym-chsarp\\superGym\\database\\database.db");
            conn.Open();
            return conn;
        }
    }
}
