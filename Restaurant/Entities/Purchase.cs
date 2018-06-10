using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Entities
{
    public class Purchase
    {
        public int Id { get; set; }
        public int IdProduct { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public string Unit { get; set; }
        public double TotalAmount { get; set; }
    }
}
