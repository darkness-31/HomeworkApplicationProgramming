using System.Data.SQLite;
using System.Dynamic;

namespace SQLite
{
    public class SQLite
    {
        string _Path { get; set; }
        SQLiteConnection _connection { get; set; }
        public SQLite(string path) 
        { 
            _Path = path;
            if (File.Exists(path))
                _connection = new SQLiteConnection(path);
        }

        public List<string> Get(string sql) 
        { 
            
        }
    }
}