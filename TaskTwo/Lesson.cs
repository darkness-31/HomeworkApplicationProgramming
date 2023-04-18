using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwo
{
    internal class Lesson
    {
        internal Lesson(string Name = "", int Count = 0) 
        {
            this.Name = Name;
            this.Count = Count;
        }

        public string name = string.Empty;
        public int Count { get; set; }
        public string Name
        {
            get => name;
            set
            {
                if (value == null)
                {
                    throw new Exception("Нет имени урока");
                }

                name = value;
            }
        }
    }
}
