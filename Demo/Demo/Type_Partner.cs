using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Type_Partner
    {
        public int id { get; set; }

        public string name;

        public string Name 
        {
            get {  return name; }
            set { name = value; } 
        }

        public Type_Partner() {}

        public Type_Partner(string name) 
        {
            this.name = name;
        }
    }
}
