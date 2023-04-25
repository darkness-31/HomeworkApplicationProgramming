using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Persons;
using Xml;

namespace Task.Data
{
    internal class PersonGrid
    {
        public List<Person> Get(string path)
        {
            Editor xml = new Editor();
            return xml.Load<Person>(path);
        }

        public void Set(object persons,string path)
        {
            Editor xml = new Editor();
            xml.Save(persons as List<Person> ,path);
        }
    }
}
