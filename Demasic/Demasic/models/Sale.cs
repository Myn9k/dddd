using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demasic.models
{
    public class Sale
    {
        public int Id { get; set; }
        public int PartnerId { get; set; }
        public string ProductName { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal Amount { get; set; }

        public Partner Partner { get; set; }
    }
}
