using System.Collections.Generic;
using Countrys;
using Xml;

namespace Task.Data
{
    internal class CountryGrid
    {
        public List<Country> Get(string path)
        {
            Editor xml = new Editor();
            return xml.Load <Country>(path);
        }

        public void Set(object persons, string path)
        {
            Editor xml = new Editor();
            xml.Save(persons as List<Country>, path);
        }
    }
}
