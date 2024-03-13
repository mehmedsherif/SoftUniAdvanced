using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.WildFarm
{
    public abstract class Food
    {
        public Food(int quantity)
        {
            Quantity = quantity;
        }
        public abstract int Quantity { get; set; }
    }
}
