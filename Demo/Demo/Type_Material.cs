using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Type_Material
    {
        public int id { get; set; }
        public string name;
        public float procent_braka;

        public string Name { 
            get { return name; }
            set { name = value; }
        }
        public float Procent_braka
        {
            get { return procent_braka; }
            set { procent_braka = value; }
        }

        public Type_Material() { }

        public Type_Material(string name, float procent_braka)
        {
            this.name = name;
            this.procent_braka = procent_braka;
        }
    }
}
