using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class ShoppingCarts
    {
        public List<Product> products { get; set; } = new List<Product>();


        //make a delegate
        public delegate decimal CalculateDiscountPrice(decimal totalPrice);

        public decimal GetFinalPrice(CalculateDiscountPrice discountPrice )
        {
            decimal total = products.Sum(x => x.Price);
            return discountPrice(total);

            //return products.Sum(products=> products.Price);
        }
    }
}
