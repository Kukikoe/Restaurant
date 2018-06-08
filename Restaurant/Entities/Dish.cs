using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Entities
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RecipeId { get; set; }
        public int PortionSize { get; set; }
        public string Unit { get; set; }
        public int Price { get; set; }
    }
}
