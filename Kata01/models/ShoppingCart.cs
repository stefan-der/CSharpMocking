using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata01.models
{
    public class ShoppingCart
    {

        List<AShoppingCartItem> ShopingCartItems { get; set; } = null;

        public ShoppingCart()
        {
            this.ShopingCartItems = new List<AShoppingCartItem>();
        }
    }
}
