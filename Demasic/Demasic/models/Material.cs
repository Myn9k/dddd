using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demasic
{
    public class Material
    {
        public int id { get; set; }

        private string name, type;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int quanityUpakovka, price;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public int QuanityUpakovka
        {
            get { return quanityUpakovka; }
            set { quanityUpakovka = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public Material() { }

        public Material(string type, string name, int quanityUpakovka, int price)
        {
            this.type = type;
            this.name = name;
            this.quanityUpakovka = quanityUpakovka;
            this.price = price;
        }
    }
}
