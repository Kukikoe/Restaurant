using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Entities
{
    public class Layout
    {
        public int Id { get; set; }
        public int IdDish { get; set; }
        public int IdProduct { get; set; }
        public int Quantity { get; set; }
    }
}
