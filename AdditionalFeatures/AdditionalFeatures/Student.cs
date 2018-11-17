using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeatures
{
    class Student
    {
        public int id { get; set; }
        public string name { get; set; }

        public Student (int id, string name)
        { this.id = id;
          this.name = name;
        }

        public Student (int id) : this ( id, "")
        {
           
        }
        public Student(string name) : this(0, name)
        {

        }

    }
}
