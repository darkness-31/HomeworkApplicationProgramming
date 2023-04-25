using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countrys
{
    [Serializable]
    public class Country
    {
        public Country() { }
        public Country(string Name, string Description, string City)
        {
            this.Name = Name;
            this.Description = Description;
            this.City = City;
        }
        public string Name { get; set; }
        public string Description { get; set; } = string.Empty;
        public string City { get; set; }
    }
}
