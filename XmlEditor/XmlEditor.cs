using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Xml
{
    public class Editor
    {
        public List<T> Load<T>(string path)
        {
            XmlSerializer serialize = new XmlSerializer(typeof(T[]));
            FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate);
            T[] list = serialize.Deserialize(fileStream) as T[];
            fileStream.Close();
            return list.ToList() ?? new List<T>();
        }
        public void Save<T>(List<T> list, string path)
        {
            XmlSerializer serialize = new XmlSerializer(typeof(T[]));
            FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate);
            serialize.Serialize(fileStream, list.ToArray());
            fileStream.Close();
        }
    }
}
