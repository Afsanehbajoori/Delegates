using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public interface IUser
    {
         string Name { get; set; }

        ShoppingCarts ShoppingCarts { get; set; }
        decimal CalculateDiscountPrice(decimal totalprice);
    }
}
