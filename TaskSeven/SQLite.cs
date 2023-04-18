using System.Data.SQLite;
using System.Data;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace TaskSeven
{
    internal class SQLite
    {
        public SQLiteConnection _DB = null;
        string _Path = string.Empty;

        public SQLite(string path)
        {
            _Path = path;
            if (Check())
                _DB = new SQLiteConnection(string.Format("Data Source={0}",_Path));
        }

        public bool Check()
        {
            if (File.Exists(_Path))
            {
                return true;
            }
            return false;
        }

        public void SQLNonQuery(string sql)
        {
            if (_DB.Equals(null))
                return;

            _DB.Open();
            SQLiteCommand cmd = new SQLiteCommand(sql, _DB);
            cmd.ExecuteNonQuery();
            _DB.Close();
        }
        public DataTable SQLQueryAsDataTable(string sql)
        {
            if (_DB.Equals(null))
                return new DataTable();

            _DB.Open();
            DataTable dt = new DataTable();
            SQLiteDataReader dr = new SQLiteCommand(sql, _DB).ExecuteReader();

            for (var i = 0; i < dr.FieldCount; i++)
            {
                dt.Columns.Add(dr.GetName(i));
            }

            if (dr.HasRows)
                while (dr.Read())
                {
                    DataRow row = dt.NewRow();
                    for (var i = 0; i < dr.FieldCount; i++)
                        row.SetField(i, dr.GetValue(i));
                    dt.Rows.Add(row);
                }
            _DB.Close();
            return dt;
        }
        public List<string>[] SQLQueryAsList(string sql)
        {
            if (_DB.Equals(null))
                return new List<string>[0];

            SQLiteDataReader dr = new SQLiteCommand(sql, _DB).ExecuteReader();
            List<List<string>> lists = new List<List<string>>();
            _DB.Open();
            if (dr.HasRows)
                while (dr.Read())
                {
                    List<string> list = new List<string>();
                    for (var i = 0; i < dr.FieldCount; i++)
                        list.Add(dr.GetValue(i).ToString());
                    lists.Add(list);
                }
            _DB.Close();
            return lists.ToArray();
        }
    }
}
