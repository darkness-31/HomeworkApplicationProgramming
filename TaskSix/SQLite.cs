using System;
using System.Data.SQLite;
using System.IO;

namespace TaskFour
{
    internal static class SQLite
    {
        static SQLiteConnection _BD { get; set; }
        public static void CheckConnect()
        {
            if (!File.Exists(Environment.CurrentDirectory + @"\source.sqlite"))
            {
                SQLiteConnection.CreateFile("source.sqlite");
            }

            string connectionString = "Data source=source.sqlite;Version=3";
            _BD = new SQLiteConnection(connectionString);

            var sql = "CREATE TABLE IF NOT EXISTS notebook ( description text, date int )";
            sql.SQLNonQuery();
        }

        public static void SQLNonQuery(this string sql)
        {
            _BD.Open();
            new SQLiteCommand(sql, _BD).ExecuteNonQuery();
            _BD.Close();
        } 
        public static string SQLNonQueryAsString(this string sql)
        {
            string temp = sql;
            _BD.Open();
            SQLiteDataReader reader = new SQLiteCommand(sql, _BD).ExecuteReader();
            while (reader.Read())
            {
                temp = reader[0].ToString();
            }
            _BD.Close();
            return temp;
        }
    }
}
