using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingList.Models
{
    public class ShoppingItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Quantity { get; set; }
        public bool Purchased { get; set; }
    }
}
