using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demasic
{
    public class Product
    {
        public int id { get; set; }

        public int min_price;
        public string name, description, necessary_materials, type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public int Min_price
        {
            get { return min_price; }
            set { min_price = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Necessary_materials
        {
            get { return necessary_materials; }
            set { necessary_materials = value; }
        }


        public Product() { }

        public Product(string type, string name, string description, int min_price, string necessary_materials)
        {
            this.type = type;
            this.name = name;
            this.description = description;
            this.min_price = min_price;
            this.necessary_materials = necessary_materials;

        }

    }
}