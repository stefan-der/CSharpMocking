using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata01.models
{
    public abstract class AShoppingCartItem
    {
        public String name { get; set; } = null;
        public ItemType ItemType { get; set; } = null;

    }
}
