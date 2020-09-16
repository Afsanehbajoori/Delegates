using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            IUser normalUser = new NormalUser() { Name= "John"};
            IUser goldenUser = new GoldenUser() { Name = "Martin" };

            normalUser.ShoppingCarts= fillShoppingCarts();
            goldenUser.ShoppingCarts=fillShoppingCarts();

           /* decimal normalUserFinalPrice = normalUser.ShoppingCarts.GetFinalPrice()*/;// it can only calculate finalprice Whatever it is a goldenuser or normaiuser
            decimal normalUserFinalPrice = normalUser.ShoppingCarts.GetFinalPrice(normalUser.CalculateDiscountPrice); 
            decimal goldenUserFinalPrice = goldenUser.ShoppingCarts.GetFinalPrice(goldenUser.CalculateDiscountPrice);

            Console.WriteLine($"NormalUser: {normalUserFinalPrice:C2} \nGOldenUser :{goldenUserFinalPrice:C2} ");

            // we can use delegate to calclulate discount prise too. in the shoppingcarts class we add delegates


            Console.ReadLine();


            
        }

        public static ShoppingCarts fillShoppingCarts()   
        {
            ShoppingCarts cart = new ShoppingCarts();
            cart.products.Add(new Product() { Name="book1",Price=12M });
            cart.products.Add(new Product() { Name = "book2", Price = 10.5M });
            cart.products.Add(new Product() { Name = "book3", Price = 8.5M });
            cart.products.Add(new Product() { Name = "book4", Price = 4.8M });
            return cart;

        }
    }
}
