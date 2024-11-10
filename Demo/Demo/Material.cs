using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Material
    {
        public int id { get; set; }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int typeId, quanityUpakovka, price;
        public int TypeId
        {
            get { return typeId; }
            set { typeId = value; }
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

        public Material(int typeId, string name, int quanityUpakovka, int price)
        {
            this.typeId = typeId;
            this.name = name;
            this.quanityUpakovka = quanityUpakovka;
            this.price = price;
        }
    }
}
