using System;
using NUnit.Framework;
using Kata01;


namespace Kata01.models
{
    public class Basics
    {
        [OneTimeSetUp]
        public void oneTimeSetup()
        {

        }

        [Category("Basics")]
        [Test]
        public void CreateShoppingCartItem(){
            ShoppingCart shopingCart = new ShoppingCart();
            NUnit.Framework.Assert.IsNotNull(shopingCart);
        }




    }
}
