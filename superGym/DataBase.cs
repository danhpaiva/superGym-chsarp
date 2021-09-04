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

        private static SQLiteConnection ConnectDataBase()
        {
            conn = new SQLiteConnection("Data Source=D:\\work\\superGym-chsarp\\superGym\\database\\database.db");
            conn.Open();
            return conn;
        }

        public static DataTable GetAllUsers()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (var cmd = ConnectDataBase().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM USER ";
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd.CommandText, ConnectDataBase());

                    dataAdapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
