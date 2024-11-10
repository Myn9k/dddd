using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demasic
{
    public class Partner
    {
        public int id { get; set; }
        public int inn, rate;
        public string name, history, sell_place, email, fio, adress, type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public int Inn
        {
            get { return inn; }
            set { inn = value; }
        }
        public int Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string History
        {
            get { return history; }
            set { history = value; }
        }
        public string Sell_place
        {
            get { return sell_place; }
            set { sell_place = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Fio
        {
            get { return fio; }
            set { fio = value; }
        }
        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }

        public Partner() { }

        public Partner(string type, string name, string adress, int inn, string fio, string email, int rate, string sell_place, string history)
        {
            this.type = type;
            this.name = name;
            this.adress = adress;
            this.inn = inn;
            this.fio = fio;
            this.email = email;
            this.rate = rate;
            this.sell_place = sell_place;
            this.history = history;

        }

    }
}
