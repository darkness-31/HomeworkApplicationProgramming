using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TaskEight.Data
{
    public enum PersonStatus
    {
        Unknown,
        GrandMother,
        GrandFather,
        Father,
        Mother,
        Son,
        Daughter
    }

    [Serializable]
    public class Person
    {
        public Person() { }
        public Person(string FirstName, string LastName, string MiddleName, PersonStatus Status) {
            this.FirstName = FirstName; 
            this.LastName = LastName;
            this.MiddleName = MiddleName;
            this.Status = Status;
        }

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public PersonStatus Status  { get; set; } = PersonStatus.Unknown;
    }
}
