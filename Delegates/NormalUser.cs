using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class NormalUser : IUser
    {
        public string Name { get ; set ; }
        public ShoppingCarts ShoppingCarts { get; set; } = new ShoppingCarts();

        public decimal CalculateDiscountPrice(decimal totalprice)
        {
            if (ShoppingCarts.products.Count > 5)
            {
                return totalprice * (1 - 0.30M);
            }
            else
            {
                return totalprice;
            }
        }
    }
}
