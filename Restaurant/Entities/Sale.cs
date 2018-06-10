using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Entities
{
    public class Sale
    {
        public int Id { get; set; }
        public int IdDish { get; set; }
        public int NumOfSales { get; set; }
        public double TotalAmount { get; set; }
    }
}
